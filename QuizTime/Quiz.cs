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
        internal void Display()
        {
            foreach (Question question in Questions)
            {
                question.Ask();
            }
        }

        
    }
}
