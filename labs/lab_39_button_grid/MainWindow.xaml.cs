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

namespace lab_39_button_grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> buttons = new List<Button>();
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise()
        {
            for (int i = 0; i < 100; i++)
            {
                var b = new Button();
                int buttonNumber = (i + 1);
                b.Name = "Button" + buttonNumber.ToString();
                b.Content = buttonNumber.ToString();
                b.Click += new RoutedEventHandler(button_click);
                buttons.Add(b);
                MainGrid.Children.Add(b);
                Grid.SetColumn(b, i % 10);
                Grid.SetRow(b, i / 10);
                // generate a random number between 0 and 5
                var randomColorNumber = RandomNumberGenerator();
                // match number with enum number (use casting)
                System.Threading.Thread.Sleep(15);
                var randomColor = (colours)randomColorNumber;



                // set color of button to be the chosen colour
                switch (randomColorNumber)
                {
                    case 0:
                        b.Background = Brushes.Blue;
                        break;
                    case 1:
                        b.Background = Brushes.Red;
                        break;
                    case 2:
                        b.Background = Brushes.Green;
                        break;
                    case 3:
                        b.Background = Brushes.Yellow;
                        break;
                    case 4:
                        b.Background = Brushes.Purple;
                        break;
                    case 5:
                        b.Background = Brushes.Pink;
                        break;
                    default:
                        b.Background = Brushes.Transparent;
                        break;
                }

                Color newColour = (Color)ColorConverter.ConvertFromString(randomColor.ToString());
                SolidColorBrush brush = new SolidColorBrush(newColour);
                b.Background = brush;
            }
        }


        private void button_click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            MessageBox.Show($"{b.Name} is at row {Grid.GetRow(b)} and " +
                $"column {Grid.GetColumn(b)} and the colour is {""}");
            // can we tell the colour??  (homework)

            var brush = b.Background;
            SolidColorBrush solidcolorbrush = brush as SolidColorBrush;
 
 

            MessageBox.Show("color is " + solidcolorbrush.Color);
            // https://docs.microsoft.com/en-us/previous-versions/windows/desktop/windows-media-center-sdk/bb189018(v%3Dmsdn.10)
        }
        private int RandomNumberGenerator()
        {

            var random = new Random();
            var randomNumber = random.Next(0, 5);
            return randomNumber;

        }

    }

    enum colours
    {
        blue,red,green, yellow, purple,pink
    }

}
