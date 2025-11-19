namespace MathQuizWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NumberOfQuestionsUpDown = new NumericUpDown();
            panel1 = new Panel();
            radioButton8 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            panel2 = new Panel();
            radioButton9 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnStartQuiz = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtbAnswer = new TextBox();
            lblCouldnotConvert = new Label();
            lblRealQuestion = new Label();
            lblQuestionNumber = new Label();
            btnNextQuestion = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tabPage3 = new TabPage();
            lblNumberOfRightAns = new Label();
            lblOpType = new Label();
            lblNumberOfWrongAns = new Label();
            lblQuestionsNumber = new Label();
            lblFinalResult = new Label();
            lblQuizLevel = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumberOfQuestionsUpDown).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 131);
            label1.Name = "label1";
            label1.Size = new Size(222, 35);
            label1.TabIndex = 0;
            label1.Text = "Number of Questions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 238);
            label2.Name = "label2";
            label2.Size = new Size(117, 35);
            label2.TabIndex = 1;
            label2.Text = "Quiz Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 367);
            label3.Name = "label3";
            label3.Size = new Size(223, 35);
            label3.TabIndex = 2;
            label3.Text = "Quiz Operation Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(325, 17);
            label4.Name = "label4";
            label4.Size = new Size(345, 65);
            label4.TabIndex = 3;
            label4.Text = "Math Quiz Game";
            // 
            // NumberOfQuestionsUpDown
            // 
            NumberOfQuestionsUpDown.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumberOfQuestionsUpDown.Location = new Point(316, 131);
            NumberOfQuestionsUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            NumberOfQuestionsUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberOfQuestionsUpDown.Name = "NumberOfQuestionsUpDown";
            NumberOfQuestionsUpDown.Size = new Size(150, 40);
            NumberOfQuestionsUpDown.TabIndex = 4;
            NumberOfQuestionsUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumberOfQuestionsUpDown.ValueChanged += NumberOfQuestionsUpDown_ValueChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton8);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton6);
            panel1.Font = new Font("Segoe Script", 10.8F);
            panel1.Location = new Point(316, 215);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 74);
            panel1.TabIndex = 5;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(433, 23);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(73, 33);
            radioButton8.TabIndex = 4;
            radioButton8.Text = "Mix";
            radioButton8.UseVisualStyleBackColor = true;
            radioButton8.CheckedChanged += rbLevels_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(18, 23);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(79, 33);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Easy";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += rbLevels_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(156, 23);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(73, 33);
            radioButton5.TabIndex = 4;
            radioButton5.Text = "Mid";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += rbLevels_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(291, 23);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(82, 33);
            radioButton6.TabIndex = 5;
            radioButton6.Text = "Hard";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += rbLevels_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton9);
            panel2.Controls.Add(radioButton7);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Font = new Font("Segoe Script", 10.8F);
            panel2.Location = new Point(316, 346);
            panel2.Name = "panel2";
            panel2.Size = new Size(625, 74);
            panel2.TabIndex = 6;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(499, 24);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(73, 33);
            radioButton9.TabIndex = 4;
            radioButton9.Text = "Mix";
            radioButton9.UseVisualStyleBackColor = true;
            radioButton9.CheckedChanged += rbOperationType_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(382, 24);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(69, 33);
            radioButton7.TabIndex = 3;
            radioButton7.Text = "Div";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += NumberOfQuestionsUpDown_ValueChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(262, 24);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(72, 33);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Mul";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += rbOperationType_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(142, 24);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 33);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Sub";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += rbOperationType_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(19, 24);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 33);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Add";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += rbOperationType_CheckedChanged;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.BackColor = SystemColors.ActiveCaptionText;
            btnStartQuiz.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartQuiz.Location = new Point(743, 453);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new Size(217, 55);
            btnStartQuiz.TabIndex = 7;
            btnStartQuiz.Text = "Start The Quiz";
            btnStartQuiz.UseVisualStyleBackColor = false;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(992, 564);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnStartQuiz);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(NumberOfQuestionsUpDown);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(984, 531);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Math Quiz Game";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ActiveCaptionText;
            tabPage2.Controls.Add(txtbAnswer);
            tabPage2.Controls.Add(lblCouldnotConvert);
            tabPage2.Controls.Add(lblRealQuestion);
            tabPage2.Controls.Add(lblQuestionNumber);
            tabPage2.Controls.Add(btnNextQuestion);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(984, 531);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quiz";
            // 
            // txtbAnswer
            // 
            txtbAnswer.BackColor = SystemColors.ActiveCaptionText;
            txtbAnswer.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbAnswer.ForeColor = SystemColors.Control;
            txtbAnswer.Location = new Point(410, 340);
            txtbAnswer.Name = "txtbAnswer";
            txtbAnswer.Size = new Size(207, 39);
            txtbAnswer.TabIndex = 19;
            txtbAnswer.Text = "0";
            txtbAnswer.TextChanged += txtbAnswer_TextChanged;
            // 
            // lblCouldnotConvert
            // 
            lblCouldnotConvert.AutoSize = true;
            lblCouldnotConvert.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCouldnotConvert.ForeColor = Color.Red;
            lblCouldnotConvert.Location = new Point(360, 390);
            lblCouldnotConvert.Name = "lblCouldnotConvert";
            lblCouldnotConvert.Size = new Size(0, 33);
            lblCouldnotConvert.TabIndex = 17;
            // 
            // lblRealQuestion
            // 
            lblRealQuestion.AutoSize = true;
            lblRealQuestion.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRealQuestion.Location = new Point(451, 190);
            lblRealQuestion.Name = "lblRealQuestion";
            lblRealQuestion.Size = new Size(110, 33);
            lblRealQuestion.TabIndex = 16;
            lblRealQuestion.Text = "Question";
            // 
            // lblQuestionNumber
            // 
            lblQuestionNumber.AutoSize = true;
            lblQuestionNumber.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestionNumber.Location = new Point(430, 106);
            lblQuestionNumber.Name = "lblQuestionNumber";
            lblQuestionNumber.Size = new Size(101, 33);
            lblQuestionNumber.TabIndex = 15;
            lblQuestionNumber.Text = "Number";
            // 
            // btnNextQuestion
            // 
            btnNextQuestion.BackColor = SystemColors.ActiveCaptionText;
            btnNextQuestion.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextQuestion.ForeColor = SystemColors.Control;
            btnNextQuestion.Location = new Point(381, 443);
            btnNextQuestion.Name = "btnNextQuestion";
            btnNextQuestion.Size = new Size(261, 56);
            btnNextQuestion.TabIndex = 13;
            btnNextQuestion.Text = "Next Question";
            btnNextQuestion.UseVisualStyleBackColor = false;
            btnNextQuestion.Click += btnNextQuestion_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(492, 274);
            label5.Name = "label5";
            label5.Size = new Size(30, 38);
            label5.TabIndex = 11;
            label5.Text = "=";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(301, 106);
            label6.Name = "label6";
            label6.Size = new Size(110, 33);
            label6.TabIndex = 10;
            label6.Text = "Question";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(451, 23);
            label7.Name = "label7";
            label7.Size = new Size(115, 57);
            label7.TabIndex = 9;
            label7.Text = "Quiz";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ActiveCaptionText;
            tabPage3.Controls.Add(lblNumberOfRightAns);
            tabPage3.Controls.Add(lblOpType);
            tabPage3.Controls.Add(lblNumberOfWrongAns);
            tabPage3.Controls.Add(lblQuestionsNumber);
            tabPage3.Controls.Add(lblFinalResult);
            tabPage3.Controls.Add(lblQuizLevel);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.ForeColor = SystemColors.Control;
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(984, 531);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Result";
            // 
            // lblNumberOfRightAns
            // 
            lblNumberOfRightAns.AutoSize = true;
            lblNumberOfRightAns.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfRightAns.Location = new Point(816, 277);
            lblNumberOfRightAns.Name = "lblNumberOfRightAns";
            lblNumberOfRightAns.Size = new Size(160, 33);
            lblNumberOfRightAns.TabIndex = 11;
            lblNumberOfRightAns.Text = "right answers";
            // 
            // lblOpType
            // 
            lblOpType.AutoSize = true;
            lblOpType.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpType.Location = new Point(816, 445);
            lblOpType.Name = "lblOpType";
            lblOpType.Size = new Size(170, 33);
            lblOpType.TabIndex = 10;
            lblOpType.Text = "operation type";
            // 
            // lblNumberOfWrongAns
            // 
            lblNumberOfWrongAns.AutoSize = true;
            lblNumberOfWrongAns.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberOfWrongAns.Location = new Point(816, 102);
            lblNumberOfWrongAns.Name = "lblNumberOfWrongAns";
            lblNumberOfWrongAns.Size = new Size(170, 33);
            lblNumberOfWrongAns.TabIndex = 9;
            lblNumberOfWrongAns.Text = "wrong answers";
            // 
            // lblQuestionsNumber
            // 
            lblQuestionsNumber.AutoSize = true;
            lblQuestionsNumber.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestionsNumber.Location = new Point(299, 277);
            lblQuestionsNumber.Name = "lblQuestionsNumber";
            lblQuestionsNumber.Size = new Size(210, 33);
            lblQuestionsNumber.TabIndex = 8;
            lblQuestionsNumber.Text = "Questions number";
            // 
            // lblFinalResult
            // 
            lblFinalResult.AutoSize = true;
            lblFinalResult.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalResult.Location = new Point(299, 102);
            lblFinalResult.Name = "lblFinalResult";
            lblFinalResult.Size = new Size(140, 33);
            lblFinalResult.TabIndex = 7;
            lblFinalResult.Text = "Final result";
            // 
            // lblQuizLevel
            // 
            lblQuizLevel.AutoSize = true;
            lblQuizLevel.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuizLevel.Location = new Point(299, 445);
            lblQuizLevel.Name = "lblQuizLevel";
            lblQuizLevel.Size = new Size(126, 33);
            lblQuizLevel.TabIndex = 6;
            lblQuizLevel.Text = "Quiz level";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(519, 277);
            label13.Name = "label13";
            label13.Size = new Size(281, 33);
            label13.TabIndex = 5;
            label13.Text = "Number of right answers";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(519, 445);
            label12.Name = "label12";
            label12.Size = new Size(232, 33);
            label12.TabIndex = 4;
            label12.Text = "Quiz operation type";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(76, 277);
            label11.Name = "label11";
            label11.Size = new Size(210, 33);
            label11.TabIndex = 3;
            label11.Text = "Questions number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(76, 102);
            label10.Name = "label10";
            label10.Size = new Size(165, 33);
            label10.TabIndex = 2;
            label10.Text = "Final result is";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(519, 102);
            label9.Name = "label9";
            label9.Size = new Size(291, 33);
            label9.TabIndex = 1;
            label9.Text = "Number of wrong answers";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(76, 445);
            label8.Name = "label8";
            label8.Size = new Size(126, 33);
            label8.TabIndex = 0;
            label8.Text = "Quiz level";
            // 
            // Form1
            // 
            AcceptButton = btnNextQuestion;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1016, 588);
            Controls.Add(tabControl1);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumberOfQuestionsUpDown).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown NumberOfQuestionsUpDown;
        private Panel panel1;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Panel panel2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton7;
        private Button btnStartQuiz;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblQuestionNumber;
        private Button btnNextQuestion;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblRealQuestion;
        private TabPage tabPage3;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label lblNumberOfRightAns;
        private Label lblOpType;
        private Label lblNumberOfWrongAns;
        private Label lblQuestionsNumber;
        private Label lblFinalResult;
        private Label lblQuizLevel;
        private Label lblCouldnotConvert;
        private MaskedTextBox msktxtbAnswer;
        private TextBox txtbAnswer;
    }
}
