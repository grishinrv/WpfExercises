using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using WpfExercises.Model;

namespace WpfExercises.ViewModels
{
    public class QuestionEditorViewModel : INotifyPropertyChanged
    {
        public QuestionEditorViewModel()
        {
            _currentQuestion = new Question(
                "Текст по умолчанию", 
                new List<Answer>()
                { 
                    new Answer(){IsRightAnswer = true, Text = "Первый вариант ответа" },
                    new Answer(){IsRightAnswer = false, Text = "Второй вариант ответа" },
                    new Answer(){IsRightAnswer = false, Text = "Третий вариант ответа" },
                    new Answer(){IsRightAnswer = false, Text = "Четвертый вариант ответа" }
                });
            Answers = new ObservableCollection<Answer>();
            foreach (var item in _currentQuestion.Answers)
            {
                Answers.Add(item);
            }
            Answers.CollectionChanged += AnswersObservableCollectionChanged;
        }

        public string CurrentQuestionText
        {
            get => _currentQuestion.Text;
            set
            {
                _currentQuestion.Text = value;
                NotifyPropertyChanged(nameof(CurrentQuestionText));
            }
        }

        public ObservableCollection<Answer> Answers { get; set; }

        private Question _currentQuestion;
        public Question CurrentQuestion 
        {
            get => _currentQuestion;
            set 
            {
                _currentQuestion = value;
                NotifyPropertyChanged(nameof(CurrentQuestion));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void AnswersObservableCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in e.NewItems)
            {
                _currentQuestion.Answers.Add((Answer)item);
            }
            foreach (var item in e.OldItems)
            {
                _currentQuestion.Answers.Remove((Answer)item);
            }
        }
    }
}
