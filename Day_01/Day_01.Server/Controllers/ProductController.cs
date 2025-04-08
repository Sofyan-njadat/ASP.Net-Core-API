using Day_01.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day_01.Server.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly MyDbContext _context;

        public ProductController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            var product = _context.Products.ToList();
            return Ok(product);
        }

        [HttpGet("First Product")]
        public IActionResult GetFirstProduct()
        {
            var FirstProduct = _context.Products.First();
            return Ok(FirstProduct);
        }

        [HttpGet("Product ID")]
        public IActionResult GetID(int Id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == Id);
            if (product != null)
            {
                return Ok(product);
            }
            else
            {
                return NotFound("Product not found");
            }
        }

        [HttpGet("Product Name")]
        public IActionResult GetProductName(string name)
        {
            var product = _context.Products.FirstOrDefault(p => p.Name == name);
            if (product != null)
            {
                return Ok(product);
            }
            else
            {
                return NotFound("Product not found");
            }
        }



    }
}
