using ECommerce.Entities.Abstracts;
using ECommerce.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entities.Concretes
{
    public abstract class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public abstract int ID { get; set; }
        public abstract DateTime CreatedDate { get; set; }
        public abstract DateTime? ModifiedDate { get; set; }
        public abstract DateTime? DeletedDate { get; set; }
        public abstract DataStatus Status { get; set; }
    }
}
