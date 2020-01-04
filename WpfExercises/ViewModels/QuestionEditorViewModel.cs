using System.Collections.Generic;
using System.ComponentModel;
using WpfExercises.Model;

namespace WpfExercises.ViewModels
{
    public class QuestionEditorViewModel : INotifyPropertyChanged
    {
        public QuestionEditorViewModel()
        {
            _currentQuestion = new Question("Текст по умолчанию", new List<Answer>());
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
    }
}
