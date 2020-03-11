using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Checkbox : Question
    {
        internal List<string> AnswerChoices { get; set; }
        internal List<string> CorrectAnswers { get; set; }
        internal Checkbox(string questionToAsk, string answer1, string answer2, string answer3, string answer4, string correctAnswer1) : base(questionToAsk)
        {
            List<string> answerChoices = new List<string>();
            List<string> correctAnswers = new List<string>();
            answerChoices.Add(answer1);
            answerChoices.Add(answer2);
            answerChoices.Add(answer3);
            answerChoices.Add(answer4);
            correctAnswers.Add(correctAnswer1);
            AnswerChoices = answerChoices;
            CorrectAnswers = correctAnswers;
           
        }
        internal Checkbox(string questionToAsk, string answer1, string answer2, string answer3, string answer4, string correctAnswer1, string correctAnswer2) : base(questionToAsk)
        {
            List<string> answerChoices = new List<string>();
            List<string> correctAnswers = new List<string>();
            answerChoices.Add(answer1);
            answerChoices.Add(answer2);
            answerChoices.Add(answer3);
            answerChoices.Add(answer4);
            correctAnswers.Add(correctAnswer1);
            correctAnswers.Add(correctAnswer2);
            AnswerChoices = answerChoices;
            CorrectAnswers = correctAnswers;

        }
        internal Checkbox(string questionToAsk, string answer1, string answer2, string answer3, string answer4, string correctAnswer1, string correctAnswer2, string correctAnswer3) : base(questionToAsk)
        {
            List<string> answerChoices = new List<string>();
            List<string> correctAnswers = new List<string>();
            answerChoices.Add(answer1);
            answerChoices.Add(answer2);
            answerChoices.Add(answer3);
            answerChoices.Add(answer4);
            correctAnswers.Add(correctAnswer1);
            correctAnswers.Add(correctAnswer2);
            correctAnswers.Add(correctAnswer3);
            AnswerChoices = answerChoices;
            CorrectAnswers = correctAnswers;

        }
        internal Checkbox(string questionToAsk, string answer1, string answer2, string answer3, string answer4, string correctAnswer1, string correctAnswer2, string correctAnswer3, string correctAnswer4) : base(questionToAsk)
        {
            List<string> answerChoices = new List<string>();
            List<string> correctAnswers = new List<string>();
            answerChoices.Add(answer1);
            answerChoices.Add(answer2);
            answerChoices.Add(answer3);
            answerChoices.Add(answer4);
            correctAnswers.Add(correctAnswer1);
            correctAnswers.Add(correctAnswer2);
            correctAnswers.Add(correctAnswer3);
            correctAnswers.Add(correctAnswer4);
            AnswerChoices = answerChoices;
            CorrectAnswers = correctAnswers;
        }
        internal override void Ask()
        {
            Console.WriteLine("CHECKBOX\nYou may select more than one answer, separated by commas.");
            Console.WriteLine(QuestionToAsk);
            Console.WriteLine($"A) {AnswerChoices[0]}\nB) {AnswerChoices[1]}\nC) {AnswerChoices[2]}\nD) {AnswerChoices[3]}");
            string userInput = Console.ReadLine();

            // Convert user input to a form that can be accurately graded.

            if (userInput.ToLower().Contains("a") || userInput.ToLower().Contains(AnswerChoices[0]))
            {
                IsCorrect = true;
            }

            if (userInput.ToLower().Contains("b") || userInput.ToLower().Contains(AnswerChoices[1]))
            {
                IsCorrect = true;
            }

            if (userInput.ToLower().Contains("c") || userInput.ToLower().Contains(AnswerChoices[2]))
            {
                IsCorrect = true;
            }

            if (userInput.ToLower().Contains("d") || userInput.ToLower().Contains(AnswerChoices[0]))
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
