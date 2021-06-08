using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGenerator.Logic
{
    public class QuizQuestion
    {
        public string QuestionText { get; set; }
        public QuestionVariant Variant1 { get; set; }
        public QuestionVariant Variant2 { get; set; }
        public QuestionVariant Variant3 { get; set; }
        public QuestionVariant Variant4 { get; set; }

    }
    public class QuestionVariant
    {
        public string Text { get; set; }
        public bool IsRight { get; set; }
        public QuestionVariant(string text, bool flag)
        {
            this.IsRight = flag;
            this.Text = text;
        }
    }
}
