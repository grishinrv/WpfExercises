using System;
using System.Collections.Generic;

namespace WpfExercises.Model
{
    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; private set; }

        public Question(string text, List<Answer> answers)
        {
            Text = text;
            Answers = answers;
        }
    }
}
