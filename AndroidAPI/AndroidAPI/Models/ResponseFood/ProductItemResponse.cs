namespace AndroidAPI.Models.Responce;

public class ProductItemResponse
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public string? Category { get; set; }
    public Dictionary<string, double>? Price { get; set; }

    public ProductItemResponse(int id, string name, string description, string imageUrl, string category, Dictionary<string, double> price)
    {
        Id = id;
        Name = name;
        Description = description;
        ImageUrl = imageUrl;
        Category = category;
        Price = price;
    }
}