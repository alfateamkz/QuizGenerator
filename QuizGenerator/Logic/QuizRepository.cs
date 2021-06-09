using System;
using System.Collections.Generic;
using System.Text;

namespace QuizGenerator.Logic
{
    public static class QuizRepository
    {
        public static List<Quiz> Quizzes { get; set; }

        public static void AddQuiz(Quiz quiz)
        {
            Quizzes.Add(quiz);
        }
    }
}
