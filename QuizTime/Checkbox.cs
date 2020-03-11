using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QuizTime
{
    class Checkbox : Question
    {
        internal List<string> AnswerChoices { get; set; }
        internal List<string> CorrectAnswers { get; set; }

        internal Checkbox(string questionToAsk, string answer1, string answer2, string answer3, string answer4, int indexOfCorrectAnswer1, int indexOfCorrectAnswer2) : base(questionToAsk)
        {
            List<string> answerChoices = new List<string>();
            List<string> correctAnswers = new List<string>();
            answerChoices.Add(answer1);
            answerChoices.Add(answer2);
            answerChoices.Add(answer3);
            answerChoices.Add(answer4);
            correctAnswers.Add(answerChoices[indexOfCorrectAnswer1]);
            correctAnswers.Add(answerChoices[indexOfCorrectAnswer2]);
            AnswerChoices = answerChoices;
            CorrectAnswers = correctAnswers;
        }
        internal Checkbox(string questionToAsk, string answer1, string answer2, string answer3, string answer4, int indexOfCorrectAnswer1, int indexOfCorrectAnswer2, int indexOfCorrectAnswer3) : base(questionToAsk)
        {
            List<string> answerChoices = new List<string>();
            List<string> correctAnswers = new List<string>();
            answerChoices.Add(answer1);
            answerChoices.Add(answer2);
            answerChoices.Add(answer3);
            answerChoices.Add(answer4);
            correctAnswers.Add(answerChoices[indexOfCorrectAnswer1]);
            correctAnswers.Add(answerChoices[indexOfCorrectAnswer2]);
            correctAnswers.Add(answerChoices[indexOfCorrectAnswer3]);
            AnswerChoices = answerChoices;
            CorrectAnswers = correctAnswers;
        }
        internal Checkbox(string questionToAsk, string answer1, string answer2, string answer3, string answer4, int indexOfCorrectAnswer1, int indexOfCorrectAnswer2, int indexOfCorrectAnswer3, int indexOfCorrectAnswer4) : base(questionToAsk)
        {
            List<string> answerChoices = new List<string>();
            List<string> correctAnswers = new List<string>();
            answerChoices.Add(answer1);
            answerChoices.Add(answer2);
            answerChoices.Add(answer3);
            answerChoices.Add(answer4);
            correctAnswers.Add(answerChoices[indexOfCorrectAnswer1]);
            correctAnswers.Add(answerChoices[indexOfCorrectAnswer2]);
            correctAnswers.Add(answerChoices[indexOfCorrectAnswer3]);
            correctAnswers.Add(answerChoices[indexOfCorrectAnswer4]);
            AnswerChoices = answerChoices;
            CorrectAnswers = correctAnswers;
        }
        internal override void Ask()
        {
            Console.WriteLine("CHECKBOX: Select more than one answer separated by commas.");
            Console.WriteLine(QuestionToAsk);
            Console.WriteLine($"A) {AnswerChoices[0]}\nB) {AnswerChoices[1]}\nC) {AnswerChoices[2]}\nD) {AnswerChoices[3]}");
            string userInput = Console.ReadLine();
            UserInput = userInput;
        }
        internal override void Grade()
        {
            string[] arrUserInput = UserInput.Split(",");
            List<string> listUserInput = new List<string>();
            List<string> correctAnswers = new List<string>();
            foreach(string str in arrUserInput)
            {
                listUserInput.Add(str.ToLower());
            }
            foreach(string str in CorrectAnswers)
            {

                correctAnswers.Add(str.ToLower());
            }
            listUserInput.OrderBy(x => x);
            correctAnswers.OrderBy(x => x);
            if (listUserInput.SequenceEqual(correctAnswers))
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
