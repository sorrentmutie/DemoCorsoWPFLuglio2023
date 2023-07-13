using Microsoft.Extensions.DependencyInjection;
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

namespace DemoCorsoWPF.Customers
{
    /// <summary>
    /// Logica di interazione per CustomersList.xaml
    /// </summary>
    public partial class CustomersList : UserControl
    {
        public CustomersList()
        {
           
            var customersData = 
                App.AppHost!.Services.GetRequiredService<ICustomersData>();

            var viewModel = App.AppHost!.Services.GetRequiredService<CustomersListViewModel>();
            DataContext = viewModel;
            InitializeComponent();
        }

       
    }
}
