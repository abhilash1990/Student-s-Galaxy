using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Galaxy_Infrastructure.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int NumberShipped { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
