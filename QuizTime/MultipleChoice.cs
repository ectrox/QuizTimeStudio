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
            CorrectAnswer = AnswerChoices[indexOfCorrectAnswer];
        }
        internal override void Ask()
        {
            Console.WriteLine(QuestionToAsk);
            Console.WriteLine($"1) {AnswerChoices[0]}\n2) {AnswerChoices[1]}\n3) {AnswerChoices[2]}\n4) {AnswerChoices[3]}");
            string userInput = Console.ReadLine();
            UserInput = userInput;
        }
    }
}
