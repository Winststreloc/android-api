using AndroidAPI.Interface;
using AndroidAPI.Models.ResponceTech;
using Microsoft.AspNetCore.Mvc;

namespace AndroidAPI.Controllers;

[Route("[controller]")]
public class TechnicController : Controller
{
    private readonly ITechData _techData;


    public TechnicController(ITechData techData)
    {
        _techData = techData;
    }

    [HttpGet("get-technic")]
    public List<TechnicResponse> GetMenu()
    {
        return _techData.GetTechnic();
    }

    [HttpGet("get-tech-by-category")]
    public List<TechnicResponse> GetTechnicByCategory([FromQuery]string category)
    {
        return _techData.GetTechnicByCategory(category);
    }
    
    [HttpGet("get-tech-by-id")]
    public TechnicResponse GetTechnicById([FromQuery]int id)
    {
        return _techData.GetTechnicById(id);
    }
    
    [HttpGet("search")]
    public List<TechnicResponse> SearchItem([FromQuery]string search)
    {
        return _techData.GetSearchResult(search);
    }
    
    [HttpGet("get-categories")]
    public List<string> GetCategories()
    {
        return _techData.GetCategories();
    }
}