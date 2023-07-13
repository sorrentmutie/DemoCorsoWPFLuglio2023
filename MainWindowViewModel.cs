using DemoCorsoWPF.Customers;
using DemoCorsoWPF.Models;
using DemoCorsoWPF.Orders;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Controls.Primitives;

namespace DemoCorsoWPF;

public class MainWindowViewModel : BaseViewModel
{
    private CustomersListViewModel? customersListViewModel;
    private OrdersListViewModel? ordersListViewModel;

    public RelayCommand<string>? NavigateCommand { get; set; }

    private BaseViewModel? currentViewModel;
    public BaseViewModel? CurrentViewModel
    {
        get { return currentViewModel; }
        set { SetProperty(ref currentViewModel, value); }
    }



    public MainWindowViewModel(CustomersListViewModel customersListViewModel,
                               OrdersListViewModel ordersListViewModel)
    {

        NavigateCommand = new RelayCommand<string>(
            onNavigate);

        this.customersListViewModel = customersListViewModel;
        this.ordersListViewModel = ordersListViewModel;

        customersListViewModel.ViewOrdersChanged += OnViewOrders;

        CurrentViewModel = customersListViewModel;
    }

    private void OnViewOrders(int obj)
    {
        ordersListViewModel!.CustomerId = obj;  
        CurrentViewModel = ordersListViewModel;
    }

    private void onNavigate(string obj)
    {
        switch (obj)
        {
            case "customers":
            default:
                CurrentViewModel = customersListViewModel;
                break;
            case "orders":
                CurrentViewModel = ordersListViewModel;
                break;
        }
    }
}
