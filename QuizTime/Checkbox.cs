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

    }
}
