using System;

namespace QuizTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz first = new Quiz();
            Question trueFalse = new TrueFalse("The moon is in space.", "true");
            first.Add(trueFalse);
            first.Display();


        }
    }
}
