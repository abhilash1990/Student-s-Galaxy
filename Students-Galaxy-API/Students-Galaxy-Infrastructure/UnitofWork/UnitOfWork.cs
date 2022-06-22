using Students_Galaxy_Infrastructure.Contexts;
using Students_Galaxy_Infrastructure.Repositories;

namespace Students_Galaxy_Infrastructure.UnitofWork
{
    public class UnitOfWork
    {
        private InventoryManagementContext _context;
        private IProductRepository productRepository { get; set; }

        public UnitOfWork(InventoryManagementContext context)
        {
            _context = context;
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new ProductRepository(_context);
                }
                return productRepository;
            }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
