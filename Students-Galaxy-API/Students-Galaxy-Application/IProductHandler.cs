using Students_Galaxy_Infrastructure.Data;

namespace Students_Galaxy_Application
{
    public interface IProductHandler
    {
        public IEnumerable<Product> GetProducts();
        public int AddProduct(Product product);
        public int UpdateProduct(Product product);
        public int RemoveProduct(Product product);
    }
}
