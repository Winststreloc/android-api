using AndroidAPI.Models.Enums;

namespace AndroidAPI.Models;

public class Pizza
{
    public int Id { get; set; }
    public string Name { get; set; }
    public PizzaSize Size { get; set; }
}