
using AndroidAPI.Interface;

using AndroidAPI.Models.Responce;
using Microsoft.AspNetCore.Mvc;

namespace AndroidAPI.Controllers;

[Route("product")]
public class PizzaController : Controller
{
    private readonly IPizzaData _pizzaData;


    public PizzaController(IPizzaData pizzaData)
    {
        _pizzaData = pizzaData;
    }

    [HttpGet("get-menu")]
    public List<List<ProductItemResponse>> GetMenu()
    {
        return _pizzaData.GetMenu();
    }
    
    [HttpGet("get-categories")]
    public List<string> GetCategories()
    {
        return _pizzaData.GetCategories();
    }

    [HttpGet("get-product-by-id")]
    public ProductItemResponse GetProductById([FromQuery]int id)
    {
        return _pizzaData.GetProductById(id);
    }
    
    [HttpGet("get-product-by-category")]
    public List<ProductItemResponse> GetTechnicByCategory([FromQuery]string category)
    {
        return _pizzaData.GetTechnicByCategory(category);
    }
    
    [HttpGet("search")]
    public List<ProductItemResponse> SearchItem([FromQuery]string search)
    {
        return _pizzaData.GetSearchResult(search);
    }
}