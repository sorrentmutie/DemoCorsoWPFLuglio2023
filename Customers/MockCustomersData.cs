using DemoCorsoWPF.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCorsoWPF.Customers;

public class MockCustomersData : ICustomersData
{
    private static List<Customer> customers 
        = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "Mario", LastName = "Rossi", PhoneNumber = "1234567890" },   
            new Customer { Id = 2, FirstName = "Luigi", LastName = "Verdi", PhoneNumber = "1234567890" },
            new Customer { Id = 3, FirstName = "Paolo", LastName = "Bianchi", PhoneNumber = "1234567890" },
        };


    public async Task AddCustomer(Customer customer)
    {
        await DoSomethingAsync();
        customers.Add(customer);
    }

    public async Task<Customer?> GetCustomer(int id)
    {
        await DoSomethingAsync();
        return customers.FirstOrDefault(c => c.Id == id);
    }

    public async Task<List<Customer>?> GetCustomers()
    {
        await DoSomethingAsync();
        return customers;
    }

    private Task DoSomethingAsync() {
        return Task.CompletedTask;
    }
}

