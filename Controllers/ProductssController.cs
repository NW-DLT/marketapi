using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using back4ker4.Models;
using Microsoft.EntityFrameworkCore;

namespace back4ker4.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductssController : ControllerBase
    {
        private readonly AppDBContent _context;

        public ProductssController(AppDBContent context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
