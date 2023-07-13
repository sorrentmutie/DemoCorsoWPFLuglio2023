using System;

namespace DemoCorsoWPF.Orders;

public class Order
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public int CustomerId { get; set; }
    public DateTime? CreatedDate { get; set; } = DateTime.Now;
}
