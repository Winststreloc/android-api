namespace AndroidAPI.Models.Responce;

public class UserItemResponse
{ 
    public string Id { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }
    public string HashPassword { get; set; }
    public string Date { get; set; }
    public string DateRegistration { get; set; }
    public double? TotalSpend { get; set; }
    public List<HistoryOrderItemResponce> OrderHistory { get; set; }
    public int? OrderCount { get; set; }
    public List<string> Address { get; set; }
    public int? Discount { get; set; }
    public double NextDiscountSum { get; set; }
}