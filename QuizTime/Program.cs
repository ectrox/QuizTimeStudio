using System;

namespace QuizTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz first = new Quiz();
            Question trueFalse = new TrueFalse("The moon is in space.", "true");
            Question multiChoice = new MultipleChoice("What year is it?", "2020", "1904", "happy birthday", "2017", 0);
            first.Add(trueFalse);
            first.Add(multiChoice);
            first.Run();


        }
    }
}
