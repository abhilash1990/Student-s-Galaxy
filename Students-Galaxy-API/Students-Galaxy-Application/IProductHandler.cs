using Students_Galaxy_Infrastructure.Data;

namespace Students_Galaxy_Application
{
    public interface IProductHandler
    {
        public IEnumerable<ProductMaster> GetProducts();
        public int AddProduct(ProductMaster product);
        public int UpdateProduct(ProductMaster product);
        public int RemoveProduct(ProductMaster product);
    }
}
