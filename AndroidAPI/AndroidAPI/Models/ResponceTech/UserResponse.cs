namespace AndroidAPI.Models.ResponceTech;

public class UserResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Age { get; set; }
    public string HashPassword { get; set; }
    public string Email { get; set; }
    public string Number { get; set; }
    public string Address { get; set; }
    public int DiscountPoints { get; set; }
    public List<HistoryOrderResponce> Carts { get; set; }
    public string DateOfBirth { get; set; }
}