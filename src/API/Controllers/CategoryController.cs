using BLL.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private IUnitOfWork _uof;

        public CategoryController(IUnitOfWork uof)
        {
            _uof = uof;
        }

        [HttpGet]
        public async Task<ActionResult> GetCategories()
        {
            var categories = await _uof.CategoryRepository.GetCategories();

            if (categories.Count() > 0)
                return Ok(categories);

            return Ok();
        }
    }
}
