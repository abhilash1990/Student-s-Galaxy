using Microsoft.AspNetCore.Mvc;
using Students_Galaxy_Infrastructure.Data;
using Students_Galaxy_Infrastructure.UnitofWork;

namespace Students_Galaxy_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly UnitOfWork _unitofWork;

        public ProductController(ILogger<ProductController> logger, UnitOfWork unitofWork)
        {
            _logger = logger;
            _unitofWork = unitofWork;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _unitofWork.ProductRepository.GetAll();
        }
    }
}