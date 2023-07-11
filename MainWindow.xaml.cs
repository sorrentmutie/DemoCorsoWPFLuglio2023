using DemoCorsoWPF.Data;
using DemoCorsoWPF.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.ObjectModel;
using System.Windows;


namespace DemoCorsoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDataAccess dataAccess;
        private readonly SecondWindow secondWindow;
        private readonly IConfiguration configuration;
        private Customer customer = new() { Id = 1};
        public ObservableCollection<Customer> 
            Customers { get; set; } = new();

        public MainWindow(IDataAccess dataAccess, 
            SecondWindow secondWindow,
            IConfiguration configuration)
        {
            InitializeComponent();
            //var myData = new MyData() 
            //{ MyColor = new MyColor { ColorName = "Blue"},
            //  Name = "Mario Rossi"};
            //myStackPanel.DataContext = myData;
            customer.FirstName = "Mario";
            customer.LastName = "Rossi";
            customer.PhoneNumber = "1234567890";
            DataContext = customer;
            LoadData();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            customer.FirstName = "Luigi";
        }

        private void LoadData()
        {
            //Customers.Add(
            //    new Customer { Id = 1, FirstName = "Mario", LastName = "Rossi", PhoneNumber = "1234567890" });
            Customers.Add(customer);
            Customers.Add(
                new Customer { Id = 2, FirstName = "Luigi", LastName = "Verdi", PhoneNumber = "1234567890" });
            Customers.Add(
                   new Customer { Id = 3, FirstName = "Giovanni", LastName = "Bianchi", PhoneNumber = "1234567890" });
        
           // myDataGrid.ItemsSource = Customers;
            myDataGrid.DataContext = this;
        }

    }
}
