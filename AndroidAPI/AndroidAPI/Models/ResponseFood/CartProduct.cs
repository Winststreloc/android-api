namespace AndroidAPI.Models.Responce;

public class CartProductItemResponse
{
    public CartProductItemResponse(int id, string name, string imageUrl, double prise, string productParameter,
        int countProductInCart)
    {
        Id = id;
        Name = name;
        ImageUrl = imageUrl;
        Prise = prise;
        ProductParameter = productParameter;
        CountProductInCart = countProductInCart;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public double Prise { get; set; }
    public string ProductParameter { get; set; }
    public int CountProductInCart { get; set; }
}