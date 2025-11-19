namespace MathQuizWinForm
{
    public partial class Form1 : Form
    {
        clsQuiz quiz = new clsQuiz();
        private Random Random = new Random();
        byte CurrentQuestionNumber = 1;

        public Form1()
        {
            InitializeComponent();
            tabControl1.SelectedTab = tabPage1;
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
        }

        private void NumberOfQuestionsUpDown_ValueChanged(object sender, EventArgs e)
        {
            quiz.QuestionsNumber = Convert.ToByte(NumberOfQuestionsUpDown.Value);
        }

        private Level GetLevelByButtonText(string StrLevel)
        {
            switch (StrLevel)
            {
                case "Easy":
                    return Level.Easy;
                case "Mid":
                    return Level.Mid;
                case "Hard":
                    return Level.Hard;
                case "Mix":
                    return Level.MixLevel;
            }
            return Level.MixLevel;
        }

        private void rbLevels_CheckedChanged(object sender, EventArgs e)
        {
            string StrLevel = ((RadioButton)sender).Text;
            quiz.Level = GetLevelByButtonText(StrLevel);
        }

        private Operator GetOperatorByButtonText(string StrOperator)
        {
            switch (StrOperator)
            {
                case "Add":
                    return Operator.Add;
                case "Sub":
                    return Operator.Sub;
                case "Mul":
                    return Operator.Multi;
                case "Div":
                    return Operator.Div;
                case "Mix":
                    return Operator.MixOperator;
            }
            return Operator.MixOperator;
        }

        private void rbOperationType_CheckedChanged(object sender, EventArgs e)
        {
            string StrOperator = ((RadioButton)sender).Text;
            quiz.Operator = GetOperatorByButtonText(StrOperator);
        }

        private string GetFinalResultText()
        {
            if (quiz.Result)
                return "Pass";
            return "Failed";
        }

        private void PrintFinalResults()
        {
            lblFinalResult.Text = GetFinalResultText();
            lblNumberOfRightAns.Text = quiz.NumberOfRightAnswers.ToString();
            lblNumberOfWrongAns.Text = quiz.NumberOfWrongAnswers.ToString();
            lblOpType.Text = quiz.Operator.ToString();
            lblQuestionsNumber.Text = quiz.QuestionsNumber.ToString();
            lblQuizLevel.Text = quiz.Level.ToString();
        }

        private void GetNextQuestion()
        {
            if(btnNextQuestion.Text == "Show Results")
            {
                PrintFinalResults();
                tabPage3.Enabled = true;
                tabControl1.SelectedTab = tabPage3;
                tabPage2.Enabled = false;
            }
            else
            {

                RefreshQuestion();
                RefreshCurrentQuestionNumber();
            }
        }

        private void RefreshCurrentQuestionNumber()
        {
            lblQuestionNumber.Text = CurrentQuestionNumber.ToString();
            if(CurrentQuestionNumber < quiz.QuestionsNumber)
                CurrentQuestionNumber++;
            else if(CurrentQuestionNumber == quiz.QuestionsNumber)
                btnNextQuestion.Text = "Show Results";
        }

        private char GetOperatorSympol()
        {
            switch (quiz.Operator)
            {
                case Operator.Add:
                    return '+';
                case Operator.Sub:
                    return '-';
                case Operator.Multi:
                    return '*';
                case Operator.Div:
                    return '/';
            }
            return '!';
        }

        private string QuestionToString()
        {
            return $"{quiz.Questions[CurrentQuestionNumber - 1].Number1} {Convert.ToString(GetOperatorSympol())} {quiz.Questions[CurrentQuestionNumber - 1].Number2}";
        }

        private void RefreshQuestion()
        {
            lblRealQuestion.Text = QuestionToString();
        }

        private int Calculate(int Number1, int Number2, Operator Operator)
        {
            switch (Operator)
            {
                case Operator.Add:
                    return Number1 + Number2;
                case Operator.Sub:
                    return Number1 - Number2;
                case Operator.Multi:
                    return Number1 * Number2;
                case Operator.Div:
                    return Number1 / Number2;
            }
            return 0;
        }

        private clsQuestion MakeQuestionAndGetTheRightAnswer()
        {
            clsQuestion question = new clsQuestion();
            if (quiz.Level == Level.MixLevel)
            {
                quiz.Level = (Level)Random.Next(1, 3);
            }
            if (quiz.Operator == Operator.MixOperator)
            {
                quiz.Operator = (Operator)Random.Next(1, 4);
            }
            question.Operator = quiz.Operator;
            question.Level = quiz.Level;

            switch (quiz.Level)
            {
                case Level.Easy:
                    question.Number1 = Random.Next(1, 10);
                    question.Number2 = Random.Next(1, 10);
                    question.CorrectAnswer = Calculate(question.Number1, question.Number2, question.Operator);
                    return question;
                case Level.Mid:
                    question.Number1 = Random.Next(10, 100);
                    question.Number2 = Random.Next(10, 100);
                    question.CorrectAnswer = Calculate(question.Number1, question.Number2, question.Operator);
                    return question;
                case Level.Hard:
                    question.Number1 = Random.Next(10, 100);
                    question.Number2 = Random.Next(100, 1000);
                    question.CorrectAnswer = Calculate(question.Number1, question.Number2, question.Operator);
                    return question;
            }
            return question;
        }

        private void FillQuestionsList()
        {
            for (int i = 0; i < quiz.QuestionsNumber; i++)
            {
                quiz.Questions.Add(MakeQuestionAndGetTheRightAnswer());
            }
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            FillQuestionsList();
            RefreshQuestion();
            RefreshCurrentQuestionNumber();
            tabPage2.Enabled = true;
            tabPage1.Enabled = false;
            tabControl1.SelectedTab = tabPage2;
        }

        private void GetUserAnswer()
        {
            try
            {
                quiz.Questions[CurrentQuestionNumber - 1].UserAnswer = Convert.ToInt32(txtbAnswer.Text);
                lblCouldnotConvert.Text = "";
                btnNextQuestion.Enabled = true;
            }
            catch
            {
                lblCouldnotConvert.Text = "Answer Must Be A Number";
                btnNextQuestion.Enabled = false;
            }
        }

        private void RefreshFinalResult()
        {
            quiz.Result = quiz.NumberOfRightAnswers >= quiz.NumberOfWrongAnswers ? true : false;
        }

        private void CheckAnswer()
        {
            if (quiz.Questions[CurrentQuestionNumber - 1].UserAnswer != quiz.Questions[CurrentQuestionNumber - 1].CorrectAnswer)
            {
                quiz.Questions[CurrentQuestionNumber - 1].Result = false;
                quiz.NumberOfWrongAnswers++;
            }
            else
            {
                quiz.Questions[CurrentQuestionNumber - 1].Result = true;
                quiz.NumberOfRightAnswers++;
            }
            RefreshFinalResult();
        }

        private void txtbAnswer_TextChanged(object sender, EventArgs e)
        {
            GetUserAnswer();
            CheckAnswer();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            GetNextQuestion();
        }
    }
}