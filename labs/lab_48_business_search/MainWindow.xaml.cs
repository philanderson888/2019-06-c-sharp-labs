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

namespace lab_48_business_search
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers;
        List<Customer> searchCustomers;
        List<String> cities;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise()
        {
            using (var db= new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                cities =
                    (from c in db.Customers
                     select c.City).Distinct().ToList();
                   

                
            }
            ListViewCustomers.ItemsSource = customers;
            ComboBoxCity.ItemsSource = cities;
        }

        private void ComboBoxCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var city = ComboBoxCity.SelectedItem;
            using (var db = new NorthwindEntities())
            {
                searchCustomers = db.Customers.Where(c => c.City == city.ToString()).ToList();
            }
            ListViewCustomers.ItemsSource = null;
            ListViewCustomers.ItemsSource = searchCustomers;
        }
    }
}
