using AndroidAPI.Models.ResponceTech;

namespace AndroidAPI.Interface;

public interface ITechData
{
    List<TechnicResponse> GetTechnic();
    List<TechnicResponse> GetTechnicByCategory(string category);
    TechnicResponse GetTechnicById(int id);
    List<TechnicResponse> GetSearchResult(string searchString);
    List<string> GetCategories();
}