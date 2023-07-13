using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCorsoWPF.Orders;

public interface IOrdersData
{
    Task<List<Order>> GetOrders();
}
