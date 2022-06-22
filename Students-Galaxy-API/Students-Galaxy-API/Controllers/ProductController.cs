using Microsoft.AspNetCore.Mvc;
using Students_Galaxy_Application;
using Students_Galaxy_Common.ServiceResponse;
using Students_Galaxy_Infrastructure.Data;

namespace Students_Galaxy_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductHandler _productManagement;

        public ProductController(ILogger<ProductController> logger, IProductHandler productManagement)
        {
            _logger = logger;
            _productManagement = productManagement;
        }

        [HttpGet]
        public ServiceResponse GetProducts()
        {
            var products = _productManagement.GetProducts();
            return ResponseType.Success(products);
        }

        [HttpPost]
        public ServiceResponse AddProducts([FromBody] Product product)
        {
            var result = _productManagement.AddProduct(product);
            return ResponseType.Success(result);
        }

        [HttpPut]
        public ServiceResponse UpdateProducts([FromBody] Product product)
        {
            var result = _productManagement.UpdateProduct(product);
            return ResponseType.Success(result);
        }
    }
}