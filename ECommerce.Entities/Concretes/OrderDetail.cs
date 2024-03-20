using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Concretes
{
    public abstract class OrderDetail:BaseEntity
    {
        public int ProductID { get; set; }
        public int OrderID { get; set; }


        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
