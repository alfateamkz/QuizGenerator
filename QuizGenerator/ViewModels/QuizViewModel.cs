using System;
using System.Collections.Generic;
using System.Text;
using QuizGenerator.Logic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QuizGenerator.ViewModels
{
    public class QuizViewModel : INotifyPropertyChanged
    {
        Quiz Quiz { get; set; }
        public QuizViewModel()
        {
     
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        private Difficulty difficulty;
        public Difficulty Difficulty
        {
            get { return difficulty; }
            set
            {
                difficulty = value;
                OnPropertyChanged("Difficulty");
            }
        }
        private QuizQuestion question;
        public QuizQuestion Question
        {
            get { return question; }
            set
            {
                question = value;
                OnPropertyChanged("Question");
            }
        }


        private RelayCommand _createCommand;
        public RelayCommand CreateCommand 
        {
            get
            {
                return _createCommand ?? (_createCommand = new RelayCommand(obj =>
                    {
                        Quiz = new Quiz(Difficulty, Title);
                    }));
            }
        }
        private RelayCommand _addQuestionCommand;
        public RelayCommand AddQuestionCommand
        {
            get
            {
                return _addQuestionCommand ?? (_addQuestionCommand = new RelayCommand(obj =>
                {
                    if (Quiz != null)
                    {
                        Quiz.AddQuestion(Question);
                    }
                }));
            }
        }

        private RelayCommand _saveQuiz;
        public RelayCommand SaveQuiz
        {
            get
            {
                return _saveQuiz ?? (_saveQuiz = new RelayCommand(obj =>
                {
                    if (Quiz != null)
                    {
                        QuizRepository.AddQuiz(Quiz);
                    }
                }));
            }
        }
    }
}
