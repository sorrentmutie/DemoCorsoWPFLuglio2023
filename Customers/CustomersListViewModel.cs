using DemoCorsoWPF.Models;
using System;
using System.Collections.ObjectModel;

namespace DemoCorsoWPF.Customers
{
    public class CustomersListViewModel: BaseViewModel
    {
        private readonly ICustomersData? customersData;
        //    = new  MockCustomersData();

        public ObservableCollection<Customer> Customers { get; }
            = new ObservableCollection<Customer>();

        private Customer? selectedCustomer;
        public Customer? SelectedCustomer
        {
            get { return selectedCustomer; }
            set
            {
                    SetProperty(ref selectedCustomer, value);
                    DeleteCommand.RaiseCanExecuteChanged();
            }
        }

        public RelayCommand AddCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand<Customer> ViewOrdersCommand { get; set; }
        public event Action<int> ViewOrdersChanged = delegate { }; 



        public CustomersListViewModel(ICustomersData customersData)
        {
            AddCommand = new RelayCommand(OnAdd, CanExecuteAdd);
            DeleteCommand = new RelayCommand(OnDelete, CanExecuteDelete);
            ViewOrdersCommand = new RelayCommand<Customer>(OnViewOrders);


            this.customersData = customersData;
                  
        }

        private void OnViewOrders(Customer customer)
        {
           ViewOrdersChanged(customer.Id);
        }

        private bool CanExecuteDelete()
        {
            return SelectedCustomer != null;
        }

        private void OnDelete()
        {
            if(selectedCustomer != null)
            {
                Customers.Remove(selectedCustomer);
            }
        }

        private bool CanExecuteAdd()
        {
            return true;
        }

        private void OnAdd()
        {
            Customers.Add(new Customer { Id = 4, FirstName = "Pippo", LastName = "Franco"});
        }

        public async void LoadData()
        {
            Customers.Clear();
            if(customersData != null)
            {
                var customers = await this.customersData.GetCustomers();
                if (customers != null)
                {
                    foreach (var customer in customers)
                    {
                        Customers.Add(customer);
                    }
                }
            }
        }
    }
}
