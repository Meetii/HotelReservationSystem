using HotelSystem.Domain.DomainModels;
using HotelSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem.Services.Interface
{
    public interface IHotelService
    {
        List<Hotel> GetAllHotels();
        Hotel GetDetailsForHotel(Guid? id);
        void CreateNewHotel(Hotel p);
        void UpdateExistingHotel(Hotel p);
        AddToHotelCartDto GetHotelCartInfo(Guid? id);
        void DeleteHotel(Guid id);
        bool AddToHotelCart(AddToHotelCartDto item, string userID);
    }
}
