using Microsoft.AspNetCore.Mvc;
using back4ker4.Models;
using Microsoft.EntityFrameworkCore;


namespace back4ker4.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly AppDBContent _context;

        public ProductsController(AppDBContent context)
        {
            _context = context;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            try
            {
                return await _context.Products.ToListAsync();
            }
            catch
            {
                return BadRequest();
            }
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            try
            {
                return await _context.Products.FindAsync(id);
            }
            catch
            {
                return BadRequest();
            }
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async void Post([FromBody] Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async void Put(int id, [FromBody] Product product)
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}


