using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Galaxy_Infrastructure.Data
{
    public class PurchaseDetail
    {
        public int Id { get; set; }
        public virtual Purchase Purchase { get; set; }
        public virtual ProductMaster Product { get; set; }
    }
}
