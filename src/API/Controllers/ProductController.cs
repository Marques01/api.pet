using BLL.Models;
using BLL.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IUnitOfWork _uof;

        public ProductController(IUnitOfWork uof)
        {
            _uof = uof;
        }

        [HttpGet]
        public async Task<ActionResult> Products()
        {
            var products = await _uof.ProductRepository.GetProductsAsync();

            if (products.Count() > 0)
                return Ok(products);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Product product)
        {
            await _uof.ProductRepository.CreateAsync(product);

            await _uof.CommitAsync();

            return Ok();
        }        
    }
}
