using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    abstract class Question
    {
        internal string QuestionToAsk { get; set; }
        internal string CorrectAnswer { get; set; }
        internal string UserInput { get; set; }
        internal bool IsCorrect { get; set; }
        internal Question(string questionToAsk)
        {
            QuestionToAsk = questionToAsk;
        }
        internal Question(string questionToAsk, string correctAnswer)
        {
            QuestionToAsk = questionToAsk;
            CorrectAnswer = correctAnswer;
        }
        internal virtual void Ask()
        {
            Console.WriteLine(QuestionToAsk);
            string userInput = Console.ReadLine();
            UserInput = userInput;
        }
        internal virtual void Grade()
        {
            if (UserInput.ToLower() == CorrectAnswer.ToLower())
            {
                IsCorrect = true;
            }
            else
            {
                IsCorrect = false;
            }
        }
    }
}