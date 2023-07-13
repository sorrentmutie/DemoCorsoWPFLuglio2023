using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoCorsoWPF.Orders;

public class MockOrdersData : IOrdersData
{
    public async Task<List<Order>> GetOrders()
    {
        await DoSomethingAsync();
        return new List<Order>()
        {
            new Order { Id = 1, CreatedDate = DateTime.Now, CustomerId = 1, Description = "Ordine 1" },
            new Order { Id = 2, CreatedDate = DateTime.Now, CustomerId = 1, Description = "Ordine 2" },
            new Order { Id = 3, CreatedDate = DateTime.Now, CustomerId = 1, Description = "Ordine 3" },
            new Order { Id = 4, CreatedDate = DateTime.Now, CustomerId = 2, Description = "Ordine 4" },
            new Order { Id = 5, CreatedDate = DateTime.Now, CustomerId = 2, Description = "Ordine 5" },
            new Order { Id = 6, CreatedDate = DateTime.Now, CustomerId = 2, Description = "Ordine 6" },

        };
    }

    private Task DoSomethingAsync()
    {
        return Task.CompletedTask;
    }
}
