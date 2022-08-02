using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Galaxy_Infrastructure.Data
{
    public class Purchase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int NumberReceived { get; set; }
        public DateTime PurchaseDate { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
