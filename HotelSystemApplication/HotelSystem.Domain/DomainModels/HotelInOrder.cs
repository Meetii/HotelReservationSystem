using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSystem.Domain.DomainModels
{
    public class HotelInOrder : BaseEntity
    {
        public Guid HotelId { get; set; }
        public Hotel SelectedHotel { get; set; }
        public Guid OrderId { get; set; }
        public Order UserOrder { get; set; }
    }
}
