﻿using System;
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

namespace lab_37_WPF_grid_click
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
            Initialize();
        }

        void Initialize()
        {

            for (int i = 0; i < 9; i++)
            {
                var b = new Button();
                int buttonNumber = i + 1;
                b.Name = "Button" + buttonNumber;
                b.Content = buttonNumber;
                b.Click += new RoutedEventHandler(button_click);
                buttons.Add(b);
                //switch (i)
                //{
                //    case 0:
                //        Grid.SetColumn(b, 0);
                //        Grid.SetRow(b, 0);
                //        break;
                //    case 1:
                //        Grid.SetColumn(b, 1);
                //        Grid.SetRow(b, 0);
                //        break;
                //    case 2:
                //        Grid.SetColumn(b, 2);
                //        Grid.SetRow(b, 0);
                //        break;
                //    case 3:
                //        Grid.SetColumn(b, 0);
                //        Grid.SetRow(b, 1);
                //        break;
                //    case 4:
                //        Grid.SetColumn(b, 1);
                //        Grid.SetRow(b, 1);
                //        break;
                //    case 5:
                //        Grid.SetColumn(b, 2);
                //        Grid.SetRow(b, 1);

                //        break;
                //}

                Grid.SetColumn(b, i % 3);
                Grid.SetRow(b, i / 3);

                Grid01.Children.Add(b);
            }


        }


        private void button_click(object sender,EventArgs e)
        {
            var b = (Button)sender;
            MessageBox.Show($"You clicked button {b.Name} on Row {Grid.GetRow(b)} and col {Grid.GetColumn(b)}");
        }

    }
}
                                                                                            