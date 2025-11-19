namespace MathQuizWinForm
{
    internal class clsQuiz
    {
        public List<clsQuestion> Questions = new();

        public byte QuestionsNumber { get; set; } = 1;

        public Level Level { get; set; } = Level.Easy;

        public Operator Operator { get; set; } = Operator.Add;

        public byte NumberOfRightAnswers { get; set; }

        public byte NumberOfWrongAnswers { get; set; }

        public bool Result { get; set; }
    }
}
