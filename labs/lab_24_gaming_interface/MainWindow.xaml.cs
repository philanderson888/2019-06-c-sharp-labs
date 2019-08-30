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
using System.IO;

namespace lab_24_gaming_interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
            if (File.Exists("Title.txt"))
            {
                WelcomeLabel.Content = File.ReadAllText("Title.txt");
                InputName.Text = WelcomeLabel.Content.ToString();
            }
            else
            {
                File.Create("Title.txt");
            }
        }

        void Initialise()
        {
            Panel.SetZIndex(Stackpanel01, 1);
            Panel.SetZIndex(Stackpanel02, -1);
        }

        // When keyup event takes place, object will be item which caused the
        // event ie key we pressed eg letter 'h'.  EventArgs is an array of STRINGS
        // which contains any relevant data for that event.
        private void KeyUp_ChangeTitle(object sender, EventArgs e)
        {
            WelcomeLabel.Content = InputName.Text;
            File.WriteAllText("Title.txt", InputName.Text);
        }


        private void MouseEnter_ChangeColor(object sender, EventArgs e)
        {
            // fix this code !!!
         //   InputName.Background = new Color.FromRgb(100, 100, 100));
        }


        private void ChangeEditMode(object sender, EventArgs e)
        {
            // fix this code!!!!!
            if (EditMode.IsChecked==true)
            {
                InputName.IsReadOnly = false;
            }
            else
            {
                InputName.IsReadOnly = true;
            }

            Panel.SetZIndex(Stackpanel01, Canvas.GetZIndex(Stackpanel01) * -1);
            Panel.SetZIndex(Stackpanel02, Canvas.GetZIndex(Stackpanel02) * -1);
           
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            
            Stackpanel01.BringIntoView();
            var w = new WindowPopUp();
            w.Show();
        }
        /*
* 
* <Grid.Background>
<ImageBrush ImageSource="/lab_52_wpf_grid;component/Images/" />
<ImageBrush ImageSource="pack://application:,,,/Images/snakes-and-ladders.jpg" />
</Grid.Background>
* */



    }
}
