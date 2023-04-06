namespace AndroidAPI.Models.ResponceTech;

public class TechnicResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Dictionary<string, string> Colors { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }

    public TechnicResponse(int id, string name, Dictionary<string, string> colors, string description, double price, string category)
    {
        Id = id;
        Name = name;
        Colors = colors;
        Description = description;
        Price = price;
        Category = category;
    }
}