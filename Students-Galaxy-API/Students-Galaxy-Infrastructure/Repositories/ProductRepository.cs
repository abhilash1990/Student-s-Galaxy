using Students_Galaxy_Infrastructure.Contexts;
using Students_Galaxy_Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Galaxy_Infrastructure.Repositories
{
    class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(InventoryManagementContext context) : base(context)
        {

        }
    }
}
