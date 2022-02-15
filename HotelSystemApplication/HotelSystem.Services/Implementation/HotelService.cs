using HotelSystem.Domain.DomainModels;
using HotelSystem.Domain.DTO;
using HotelSystem.Repository.Interface;
using HotelSystem.Services.Interface;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<HotelService> _logger;
        public HotelService(IRepository<Hotel> hotelRepository, ILogger<HotelService> logger, IUserRepository userRepository, IRepository<HotelInReservationCart> hotelInReservationCartRepository)
        {
            _hotelRepository = hotelRepository;
            _userRepository = userRepository;
            _hotelInReservationCartRepository = hotelInReservationCartRepository;
            _logger = logger;
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
                        //Id = Guid.NewGuid(),
                        Hotel = hotel,
                        HotelId = hotel.Id,
                        ReservationCart = userHotelCard,
                        ReservationCartId = userHotelCard.Id,
                        checkIn = item.checkin,
                        checkout = item.checkout
                    };

                    this._hotelInReservationCartRepository.Insert(itemToAdd);
                    _logger.LogInformation("Hotel was successfully added into ReservationCart");
                    return true;
                   
                }
                return false; 
            };
            _logger.LogInformation("Something isn't right. HotelId or UserReservationCart amay be unavailable");
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
            _logger.LogInformation("GetAllHotels was called:)");
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
