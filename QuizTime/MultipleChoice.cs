using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class MultipleChoice : Question
    {
        internal List<string> AnswerChoices { get; set; }
        internal MultipleChoice(string questionToAsk, string answer1, string answer2, string answer3, string answer4, int indexOfCorrectAnswer) : base(questionToAsk)
        {
            List<string> answerChoices = new List<string>();
            answerChoices.Add(answer1);
            answerChoices.Add(answer2);
            answerChoices.Add(answer3);
            answerChoices.Add(answer4);
            AnswerChoices = answerChoices;
            CorrectAnswer = answerChoices[indexOfCorrectAnswer];
        }
        internal override void Ask()
        {
            Console.WriteLine("MULTIPLE CHOICE");
            Console.WriteLine(QuestionToAsk);
            Console.WriteLine($"A) {AnswerChoices[0]}\nB) {AnswerChoices[1]}\nC) {AnswerChoices[2]}\nD) {AnswerChoices[3]}");
            string userInput = Console.ReadLine();
            string newUserInput;

            // Convert user input to a form that can be accurately graded.

            if (userInput.ToLower() == "a" || userInput.ToLower() == AnswerChoices[0])
            {
                newUserInput = AnswerChoices[0];
            }
            else if (userInput.ToLower() == "b" || userInput.ToLower() == AnswerChoices[1])
            {
                newUserInput = AnswerChoices[1];
            }
            else if (userInput.ToLower() == "c" || userInput.ToLower() == AnswerChoices[2])
            {
                newUserInput = AnswerChoices[2];
            }
            else if (userInput.ToLower() == "d" || userInput.ToLower() == AnswerChoices[3])
            {
                newUserInput = AnswerChoices[3];
            }
            else
            {
                newUserInput = null;
            }

            UserInput = newUserInput;
        }
    }
}
