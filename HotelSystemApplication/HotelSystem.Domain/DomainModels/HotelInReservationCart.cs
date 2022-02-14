using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSystem.Domain.DomainModels
{
    public class HotelInReservationCart : BaseEntity
    {
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkout { get; set; }
       // public int Price { get; set; }
        public Guid ReservationCartId { get; set; }
        public ReservationCart ReservationCart { get; set; }

    }
}
