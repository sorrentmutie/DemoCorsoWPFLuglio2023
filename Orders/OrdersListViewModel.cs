using DemoCorsoWPF.Models;
using System.CodeDom;
using System.Collections.ObjectModel;
using System.Linq;

namespace DemoCorsoWPF.Orders;

public class OrdersListViewModel: BaseViewModel
{
    private readonly IOrdersData? ordersData;

    public ObservableCollection<Order> Orders { get; set; }
        = new ObservableCollection<Order>();

    private int customerId;
    public int CustomerId
    {
        get { return customerId; }
        set { SetProperty(ref customerId, value); }
    }

  
    public OrdersListViewModel(IOrdersData ordersData)
    {
        this.ordersData = ordersData;

       

    }

    public async void LoadOrders()
    {


        Orders.Clear();

        if(ordersData != null )
        {
            var orders = await ordersData.GetOrders();
            if (CustomerId == 0)
            {
                foreach (var order in orders)
                {
                    Orders.Add(order);
                }
            } else
            {
                var filteredOrders = orders.Where(o => o.CustomerId == CustomerId);
                foreach (var order in filteredOrders)
                {
                    Orders.Add(order);
                }

            }

        }
    }

}
