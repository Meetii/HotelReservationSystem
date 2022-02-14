using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSystem.Domain.DomainModels
{
    public class Hotel : BaseEntity
    {
        [Required]
        public string HotelName { get; set; }
        [Required]
        public string HotelImage { get; set; }
        [Required]
        public string City { get; set; }
        public string HotelDescription { get; set; }
        [Required]
        public int Price { get; set; }
        public int Stars { get; set; }
        public virtual ICollection<HotelInReservationCart> HotelInReservationCarts { get; set; }
        public virtual ICollection<HotelInOrder> Orders { get; set; }

    }
}
