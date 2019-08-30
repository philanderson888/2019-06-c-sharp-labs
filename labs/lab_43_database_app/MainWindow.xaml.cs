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

namespace lab_43_database_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers;
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
                customers = db.Customers.ToList();
            }
            ListBoxCustomers.ItemsSource = customers;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            // if ButtonAdd content = "Clear" then clear all textboxes 
            // out and set content back to 'add'
            if (ButtonAdd.Content.ToString() == "Clear")
            {
                TextBoxID.Text = "TEST1";
                TextBoxName.Text = "Phil";
                TextBoxCompany.Text = "Company";
                TextBoxCity.Text = "City";
                TextBoxCountry.Text = "Country";
                ButtonAdd.Content = "Add"; 
            }

            else if(TextBoxID.Text !="" && TextBoxCompany.Text != "")
            {
                MessageBox.Show("about to add a new customer");
                var newCustomer = new Customer() {
                    CustomerID  = TextBoxID.Text,
                    ContactName  = TextBoxName.Text,
                    City  = TextBoxCity.Text,
                    Country  =TextBoxCountry.Text
                };

                // unbind listbox first
                ListBoxCustomers.ItemsSource = null;
                customers = null;
                // add new customer
                using (var db  = new NorthwindEntities())
                {
                    db.Customers.Add(newCustomer);
                    db.SaveChanges();
                    customers = db.Customers.ToList();
                }

                ListBoxCustomers.ItemsSource = customers;
                ButtonAdd.Content = "Clear";

            }
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonEdit.Content.ToString() == "Edit")
            {
                TextBoxID.IsEnabled = true;
                TextBoxName.IsEnabled = true;
                TextBoxCity.IsEnabled = true;
                TextBoxCompany.IsEnabled = true;
                TextBoxCountry.IsEnabled = true;
                TextBoxID.Background = Brushes.White;
                TextBoxName.Background = Brushes.White;
                TextBoxCompany.Background = Brushes.White;
                TextBoxCity.Background = Brushes.White;
                TextBoxCountry.Background = Brushes.White;
                ButtonEdit.Content = "Save";
            }
            else if(ButtonEdit.Content.ToString() == "Save")
            {
                if (customer != null)
                {
                    using (var db = new NorthwindEntities())
                    {
                        var customerToEdit = db.Customers
                            .Where(c => c.CustomerID == customer.CustomerID)
                            .FirstOrDefault();
                        MessageBox.Show($"customer ready to edit {customerToEdit.CustomerID}");
                        customerToEdit.ContactName = TextBoxName.Text;
                        customerToEdit.CompanyName = TextBoxCompany.Text;
                        customerToEdit.City = TextBoxCity.Text;
                        customerToEdit.Country = TextBoxCountry.Text;
                        db.SaveChanges();
                        // refresh view
                        ListBoxCustomers.ItemsSource = null;  // disconnect listbox from formal customer list
                                                              // because we are about to change it
                        customers = db.Customers.ToList();    // get a new list from db
                        ListBoxCustomers.ItemsSource = customers;
                    }
                }
            }

        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonDelete.Content.ToString() == "Delete")
            {
                if (customer == null)
                {
                    MessageBox.Show("no customer selected");
                    return;
                }
                ButtonDelete.Content = "Confirm";
                ButtonDelete.Background = Brushes.Red;
            }
            else if (ButtonDelete.Content.ToString() == "Confirm")
            {
                // find record by ID and delete it
                using (var db = new NorthwindEntities())
                { 
                    var customerToDelete = db.Customers.Find(customer.CustomerID);
                    db.Customers.Remove(customerToDelete);
                    db.SaveChanges();
                    // refresh
                    ListBoxCustomers.ItemsSource = null;
                    customers = db.Customers.ToList();
                    ListBoxCustomers.ItemsSource = customers;
                }

            }
        }

        private void ListBoxCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ButtonAdd.Content = "Clear";

            customer = (Customer)ListBoxCustomers.SelectedItem;

            if (customer != null)
            {
                ListBoxLog.Items.Insert(0, " ");
                ListBoxLog.Items.Insert(0, DateTime.Now);
                ListBoxLog.Items.Insert(0, "Customer Selected");
                //ListBoxLog.Items.Insert(0,$"{customer.CustomerID,-7},{customer.ContactName} from {customer.City}");

                // fill text boxes
                TextBoxID.Text = customer.CustomerID;
                TextBoxName.Text = customer.ContactName;
                TextBoxCity.Text = customer.City;
                TextBoxCountry.Text = customer.Country;
                TextBoxCompany.Text = customer.CompanyName;
                // set to read only also
                TextBoxID.IsEnabled = false;
                TextBoxName.IsEnabled = false;
                TextBoxCity.IsEnabled = false;
                TextBoxCompany.IsEnabled = false;
                TextBoxCountry.IsEnabled = false;
            }

            
        }
    }
}
