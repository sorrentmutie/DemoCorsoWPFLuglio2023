using DemoCorsoWPF.Customers;
using DemoCorsoWPF.Data;
using DemoCorsoWPF.Models;
using DemoCorsoWPF.Orders;
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
        public MainWindow(CustomersListViewModel customersListViewModel, 
            OrdersListViewModel ordersListViewModel)
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(customersListViewModel, ordersListViewModel);
        }

       

        

    }
}
