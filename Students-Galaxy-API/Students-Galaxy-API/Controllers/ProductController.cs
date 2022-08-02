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
        private readonly IProductHandler _productHandler;

        public ProductController(ILogger<ProductController> logger, IProductHandler productHandler)
        {
            _logger = logger;
            _productHandler = productHandler;
        }

        [HttpGet]
        public ServiceResponse GetProducts()
        {
            var products = _productHandler.GetProducts();
            return ResponseType.Success(products);
        }

        [HttpPost]
        public ServiceResponse AddProducts([FromBody] ProductMaster product)
        {
            var result = _productHandler.AddProduct(product);
            return ResponseType.Success(result);
        }

        [HttpPut]
        public ServiceResponse UpdateProducts([FromBody] ProductMaster product)
        {
            var result = _productHandler.UpdateProduct(product);
            return ResponseType.Success(result);
        }
    }
}