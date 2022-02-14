
using HotelSystem.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSystem.Domain.DTO

{
    public class AddToHotelCartDto
    {
        public Hotel SelectedHotel { get; set; }
        public Guid HotelId { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
        //public int Price { get; set; }
    }
}
