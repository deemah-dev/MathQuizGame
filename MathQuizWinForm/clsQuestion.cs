using System;
namespace MathQuizWinForm
{
    public enum Level
    {
        Easy = 1,
        Mid = 2,
        Hard = 3,
        MixLevel = 4
    }
    public enum Operator
    {
        Add = 1,
        Sub = 2,
        Multi = 3,
        Div = 4,
        MixOperator = 5
    }
    internal class clsQuestion
    {
        public int Number1 { get; set; }

        public int Number2 { get; set; }

        public Level Level { get; set; }

        public Operator Operator { get; set; }

        public int UserAnswer { get; set; }

        public int CorrectAnswer { get; set; }

        public byte QuestionNumber { get; set; }

        public bool Result { get; set; }
    }
}
