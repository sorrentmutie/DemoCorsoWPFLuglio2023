using DemoCorsoWPF.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoCorsoWPF.Customers;

public interface ICustomersData
{
    Task<List<Customer>?> GetCustomers();
    Task<Customer?> GetCustomer(int id);
    Task AddCustomer(Customer customer);
}
