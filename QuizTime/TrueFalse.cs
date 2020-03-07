using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    internal class TrueFalse : Question
    {
        internal TrueFalse(string questionToAsk, string correctAnswer) : base(questionToAsk, correctAnswer) { }
        internal override void Ask()
        {
            Console.WriteLine("TRUE / FALSE");
            Console.WriteLine(QuestionToAsk);
            string userInput = Console.ReadLine().ToLower();
            if (userInput != "true" && userInput != "false" )
            {
                Console.WriteLine("Invalid response!");
                Ask();
            }
            else
            {
                UserInput = userInput;
            }
        }
        
    }
}
