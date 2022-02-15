using HotelSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem.Services.Interface
{
    public interface IReservationCartService
    {
        HotelCartDto getReservationCartInfo(string userId);
        bool deleteHotelFromReservationCart(string userId, Guid id);
        bool orderNow(string userId);
    }
}
