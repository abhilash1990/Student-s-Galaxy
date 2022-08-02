using Students_Galaxy_Domain;
using Students_Galaxy_Infrastructure.Data;
using Students_Galaxy_Infrastructure.UnitofWork;

namespace Students_Galaxy_Application
{
    public class ProductHandler : IProductHandler
    {
        private readonly UnitOfWork _unitofWork;
        private readonly IProductManagement _productManagement;

        public ProductHandler(UnitOfWork unitofWork, IProductManagement productManagement)
        {
            _unitofWork = unitofWork;
            _productManagement = productManagement;
        }

        public IEnumerable<ProductMaster> GetProducts()
        {
            return _unitofWork.ProductRepository.GetAll();
        }

        public int AddProduct(ProductMaster product)
        {
            _unitofWork.ProductRepository.Add(product);
            return _unitofWork.Save();
        }

        public int UpdateProduct(ProductMaster product)
        {
            _unitofWork.ProductRepository.Update(product);
            return _unitofWork.Save();
        }

        public int RemoveProduct(ProductMaster product)
        {
            _unitofWork.ProductRepository.Remove(product);
            return _unitofWork.Save();
        }
    }
}
