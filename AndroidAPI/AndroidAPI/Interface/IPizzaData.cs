using AndroidAPI.Models.Responce;

namespace AndroidAPI.Interface;

public interface IPizzaData
{
    List<List<ProductItemResponse>> GetMenu();
    List<string> GetCategories();
    ProductItemResponse? GetProductById(int id);
    List<ProductItemResponse> GetSearchResult(string searchString);
    List<ProductItemResponse> GetTechnicByCategory(string category);
    
}