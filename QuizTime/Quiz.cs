using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Quiz
    {
        internal string Name { get; set; }
        internal List<Question> Questions { get; set; }
        internal Quiz()
        {
            Name = "my quiz";
            Questions = new List<Question>();
        }
        internal Quiz(string name)
        {
            Name = name;
            Questions = new List<Question>();
        }
        internal void Add(Question toAdd)
        {
            Questions.Add(toAdd);
        }
        internal void Run()
        {
            Console.WriteLine("Welcome to Quiz Time! Type your answers and press enter to submit. Goodluck!\n");
            foreach (Question question in Questions)
            {
                question.Ask();
                question.Grade();
                Console.WriteLine("\n");
            }
            Grade();
        }
        internal void Grade()
        {
            List<Question> answeredCorrectly = new List<Question>();

            foreach (Question question in Questions)
            {
                if (question.IsCorrect)
                {
                    answeredCorrectly.Add(question);
                }
            }

            double answeredCorrectlyDbl = Convert.ToDouble(answeredCorrectly.Count);
            double questionsDbl = Convert.ToDouble(Questions.Count);

            Console.WriteLine($"You answered {answeredCorrectly.Count}/{Questions.Count} questions correctly. Score: {(answeredCorrectlyDbl / questionsDbl) * 100 }%");
        
        }
        
    }
}
