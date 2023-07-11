namespace DemoCorsoWPF.Models;

public class MyData
{
    public MyColor? MyColor { get; set; }
    public string? Name { get; set; } 
}

public class MyColor
{
    public string? ColorName { get; set; } = "Red";
}