using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGenerator.Logic
{
    public class Quiz
    {
        public List<QuizQuestion> QuizQuestions { get; set; }
        public Difficulty Difficulty { get; set; }
        public string Title { get; set; }
        public int RightAnswers { get; set; } = 0;
        public int Counter { get; set; } = 0;
        public Quiz(Difficulty difficulty, string title)
        {
            this.Difficulty = difficulty;
            this.Title = title;
        }

        public void AddQuestion(QuizQuestion question)
        {
            QuizQuestions.Add(question);
        }
        public void Answer(int variant)
        {

            if (Counter > QuizQuestions.Count)
            {
                throw new Exception("Вопросы закончились");
            }

            switch (variant)
            {
                case 1:
                    if(QuizQuestions[Counter].Variant1.IsRight)
                    {
                        RightAnswers++;
                    }
                    break;
                case 2:
                    if (QuizQuestions[Counter].Variant2.IsRight)
                    {
                        RightAnswers++;
                    }
                    break;
                case 3:
                    if (QuizQuestions[Counter].Variant3.IsRight)
                    {
                        RightAnswers++;
                    }
                    break;
                case 4:
                    if (QuizQuestions[Counter].Variant4.IsRight)
                    {
                        RightAnswers++;
                    }
                    break;
            }
            Counter++;
        }
    }
}
