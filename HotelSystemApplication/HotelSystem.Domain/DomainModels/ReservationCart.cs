using HotelSystem.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSystem.Domain.DomainModels
{
    public class ReservationCart : BaseEntity
    {
      //  public Guid Id { get; set; }
      //  public DateTime checkIn { get; set; }
      //  public DateTime checkout { get; set; }
        public string OwnerId { get; set; }
        public HotelApplicationUser Owner { get; set; }
        public virtual ICollection<HotelInReservationCart> HotelInReservationCarts { get; set; }
    }
}
