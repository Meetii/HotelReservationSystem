using HotelSystem.Domain.DomainModels;
using HotelSystem.Domain.DTO;
using HotelSystem.Repository.Interface;
using HotelSystem.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelSystem.Services.Implementation
{
    public class HotelService : IHotelService
    {

        private readonly IRepository<Hotel> _hotelRepository;
        private readonly IRepository<HotelInReservationCart> _hotelInReservationCartRepository;
        private readonly IUserRepository _userRepository;
        public HotelService(IRepository<Hotel> hotelRepository, IUserRepository userRepository, IRepository<HotelInReservationCart> hotelInReservationCartRepository)
        {
            _hotelRepository = hotelRepository;
            _userRepository = userRepository;
            _hotelInReservationCartRepository = hotelInReservationCartRepository;
        }

        public bool AddToHotelCart(AddToHotelCartDto item, string userID)
        {
            var user = this._userRepository.Get(userID);

            var userHotelCard = user.UserCart;


            if (item.HotelId != null && userHotelCard != null)
            {

                var hotel = this.GetDetailsForHotel(item.HotelId);

                if (hotel != null)
                {
                    HotelInReservationCart itemToAdd = new HotelInReservationCart
                    {
                        Hotel = hotel,
                        HotelId = hotel.Id,
                        ReservationCart = userHotelCard,
                        ReservationCartId = userHotelCard.Id,
                        checkIn = item.checkin,
                        checkout = item.checkout
                    };

                    this._hotelInReservationCartRepository.Insert(itemToAdd);
                    return true;
                   
                }
                return false; 
            };
            return false;
        }

        public void CreateNewHotel(Hotel p)
        {
            this._hotelRepository.Insert(p);
        }

        public void DeleteHotel(Guid id)
        {
            var hotel = this.GetDetailsForHotel(id);
            this._hotelRepository.Delete(hotel);      
        }

        public List<Hotel> GetAllHotels()
        {
            return this._hotelRepository.GetAll().ToList();
        }

        public Hotel GetDetailsForHotel(Guid? id)
        {
            return this._hotelRepository.Get(id);
        }

        public AddToHotelCartDto GetHotelCartInfo(Guid? id)
        {
            var hotel = this.GetDetailsForHotel(id);

            AddToHotelCartDto model = new AddToHotelCartDto
            {
                SelectedHotel = hotel,
                HotelId = hotel.Id,
                checkin = DateTime.Now,
                checkout = DateTime.Now
            };

            return model;
        }

        public void UpdateExistingHotel(Hotel p)
        {
            this._hotelRepository.Update(p);
        }
    }
}
