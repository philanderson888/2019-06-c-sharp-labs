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

namespace WPF_Data_Grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Customer customer;

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise()
        {
            using (var db = new NorthwindEntities())
            {
                DataGrid01.ItemsSource = db.Customers.ToList();
            }
        }

        private void DataGrid01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = (Customer)DataGrid01.SelectedItem;
        }

        private void SaveCellChanges(object sender, EventArgs e)
        {
            if (customer != null)
            {
                MessageBox.Show($"cell has changed for customer {customer.CustomerID} of type {sender.GetType()}");
            }
        }
    }
}
