using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_38_stack_panel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<String> questions = new List<String>();
        public List<QuestionBank> questionswithanswers = new List<QuestionBank>();

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise()
        {
            StackPanel01.Visibility = Visibility.Visible;
            StackPanel02.Visibility = Visibility.Hidden;
            StackPanel03.Visibility = Visibility.Hidden;

            questions.Add("What is the capital of Italy");
            questions.Add("What is the capital of Mongolia");
            questions.Add("How do you spell Llanfair..... fully");
            questions.Add("What is 1/0 * 3");
            questions.Add("Who is the president of Singapore");

            var qanda01 = new QuestionBank("What is the capital of Italy", "Rome" , 100); 
            var qanda02 = new QuestionBank("What is the capital of Mongolia", "Who Knows", 2000);
            var qanda03 = new QuestionBank("How do you spell Llanfair..... fully", 
                                "Llanfairpwllgwyngyllgogerychwyrndrobwllllantysiliogogogoch", 50_000);
            var qanda04 = new QuestionBank("What is 1/0 * 3", "Undefined", 1000);
            var qanda05 = new QuestionBank("Who is the president of Singapore", "", 500);

            // Classwork and home work
            // Create a game to randomly show one of the questions.  
            // Have a text box to receive the answer.
            // If it's right display appropriate message and add to total points
            // If wrong zero points and appropriate message
            // Create a winning condition
            // Add some imagery as well???

        }

        private void ShowPanel01(object sender, EventArgs e)
        {
            StackPanel01.Visibility = Visibility.Visible;
            StackPanel02.Visibility = Visibility.Hidden;
            StackPanel03.Visibility = Visibility.Hidden;
        }

        private void ShowPanel02(object sender, EventArgs e)
        {
            StackPanel01.Visibility = Visibility.Hidden;
            StackPanel02.Visibility = Visibility.Visible;
            StackPanel03.Visibility = Visibility.Hidden;
        }

        private void ShowPanel03(object sender, EventArgs e)
        {
            StackPanel01.Visibility = Visibility.Hidden;
            StackPanel02.Visibility = Visibility.Hidden;
            StackPanel03.Visibility = Visibility.Visible;
        }
    }


    public class QuestionBank
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Points { get; set; }

        public QuestionBank(string question, string answer, int points)
        {
            this.Question = question;
            this.Answer = answer;
            this.Points = points;
        }
    }
}


