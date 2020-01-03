using System.Collections.Generic;
using System.Windows;
using WpfExercises.Model;
using WpfExercises.ViewModels;
using WpfExercises.Views;

namespace WpfExercises
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var form = new QuestionEditor();
            var dataContext = new QuestionEditorViewModel();
            dataContext.CurrentQuestion = new Question("Текст вопроса", new List<Answer>());
            form.DataContext = dataContext;
            form.Show();
        }
    }
}
