using HotelSystem.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSystem.Domain.DTO

{
    public class HotelCartDto
    {
        public List<HotelInReservationCart> HotelInReservationCarts { get; set; }
        public int TotalPrice { get; set; }

    }
}
