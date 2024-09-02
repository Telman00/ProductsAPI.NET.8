using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Models;

namespace ProductsAPI.Controllers
{
   //localhost:5000/api/products
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private static List<Product>? _products;

        public ProductsController()
        {
        _products = new List<Product>
{
    new() {ProductId = 1, ProductName = "IPhone 14", Price = 60000, IsActive = true },
    new() {ProductId = 2, ProductName = "IPhone 15", Price = 65000, IsActive = true },
    new() {ProductId = 3, ProductName = "IPhone 16", Price = 70000, IsActive = true },
    new() {ProductId = 4, ProductName = "IPhone 17", Price = 75000, IsActive = true }
};

}
           
        //localhost:5000/api/products => GET
[HttpGet]

public IActionResult GetProducts()
{
    if(_products == null)
    {
        return NotFound();
    }

return Ok(_products);
}


//localhost:5000/api/products/1 => GET
[HttpGet("{id}")]

public IActionResult GetProduct(int? id)
{
    if (id == null)
    {
        return NotFound();
    }

var p = _products?.FirstOrDefault(i => i.ProductId == id);

if(p == null)
    {
        return NotFound();
    }

return Ok(p);

        }
    }
}
