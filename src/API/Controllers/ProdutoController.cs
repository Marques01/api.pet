using BLL.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private IUnitOfWork _uof;

        public ProdutoController(IUnitOfWork uof)
        {
            _uof = uof;
        }
    }
}
