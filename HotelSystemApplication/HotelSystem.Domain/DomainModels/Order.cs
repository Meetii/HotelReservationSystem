using HotelSystem.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSystem.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        
        public string UserId { get; set; }
        public HotelApplicationUser User { get; set; }
        public virtual ICollection<HotelInOrder> Hotels { get; set; }
    }
}
