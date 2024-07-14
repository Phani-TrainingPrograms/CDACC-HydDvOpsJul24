using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleWebApi.Data;
using SampleWebApi.Models;

//In real time, U shall have a service that implements the logic of db connection and getting the data, and thru DI feature, we shall use the interface object to call the methods. 
namespace SampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly OnlineShoppingDbContext _context;

        public ProductsController(OnlineShoppingDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetAllProducts() => await _context.Products.ToListAsync();
    }
}
