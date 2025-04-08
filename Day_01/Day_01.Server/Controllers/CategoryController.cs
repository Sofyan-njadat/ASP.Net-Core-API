using Day_01.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_01.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly MyDbContext _context;

        public CategoryController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _context.Categories.ToList();
            return Ok(categories);
        }

        [HttpGet("First Category")]
        public IActionResult GetFirstCategories()
        {
            var categories = _context.Categories.First();
            return Ok(categories);
        }

        [HttpGet("Category ID")]
        public IActionResult GetId(int Id)
        {
            var catgry = _context.Categories.FirstOrDefault(x => x.CategoryId == Id);
            if (catgry != null)
            {
                return Ok(catgry);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("Category Name")]
        public IActionResult GetCategoryName(string name)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryName == name);
            if (category != null)
            {

                return Ok(category);
            }
            else
            {
                return NotFound();
            }
        }
        

    }
}
