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
    public class ReservationCartService : IReservationCartService
    {
        private readonly IRepository<ReservationCart> _reservationCartRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<HotelInOrder> _hotelInOrderRepository;
        private readonly IUserRepository _userRepository;

        public ReservationCartService(IRepository<ReservationCart> reservationCartRepository, IUserRepository userRepository, IRepository<Order> orderRepository, IRepository<HotelInOrder> hotelInOrderRepository)
        {
            _reservationCartRepository = reservationCartRepository;
            _userRepository = userRepository;
            _orderRepository = orderRepository;
            _hotelInOrderRepository = hotelInOrderRepository;
        }

        public bool deleteHotelFromReservationCart(string userId,Guid id)
        {
            if (!string.IsNullOrEmpty(userId) && id != null)
            {

                var loggedInUser = this._userRepository.Get(userId);

                var userHotelCart = loggedInUser.UserCart;

                var reservationToDelete = userHotelCart.HotelInReservationCarts
                    .Where(z => z.Hotel.Id.Equals(id))
                    .FirstOrDefault();

                userHotelCart.HotelInReservationCarts.Remove(reservationToDelete);


                this._reservationCartRepository.Update(userHotelCart);
                return true;
            }
            return false;
        }

        public HotelCartDto getReservationCartInfo(string userId)
        {
            var loggedInUser = this._userRepository.Get(userId);

            var userShoppingCart = loggedInUser.UserCart;

            var allHotels = userShoppingCart.HotelInReservationCarts.ToList();

            var hotelprice = allHotels.Select(z => new
            {
                HotelPrice = z.Hotel.Price
            }).ToList();

            var total = 0;

            foreach (var item in hotelprice)
            {
                total += item.HotelPrice;
            }

            HotelCartDto hotelCartDtoItem = new HotelCartDto
            {
                HotelInReservationCarts = userShoppingCart.HotelInReservationCarts.ToList(),
                TotalPrice = total
            };
            return hotelCartDtoItem;
            
        }

        public bool orderNow(string userId)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                var loggedInUser = this._userRepository.Get(userId);

                var userHotelCart = loggedInUser.UserCart;


                Order orderItem = new Order
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    User = loggedInUser
                };


                this._orderRepository.Insert(orderItem);

                List<HotelInOrder> hotelInOrders = new List<HotelInOrder>();

                var result = userHotelCart.HotelInReservationCarts
                     .Select(z => new HotelInOrder
                     {
                         //Id = Guid.NewGuid(),
                         OrderId = orderItem.Id,
                         HotelId = z.Hotel.Id,
                         SelectedHotel = z.Hotel,
                         UserOrder = orderItem
                     }).ToList();

                hotelInOrders.AddRange(result);

                foreach (var item in hotelInOrders)
                {
                    this._hotelInOrderRepository.Insert(item);

                }
               

                loggedInUser.UserCart.HotelInReservationCarts.Clear();

                this._userRepository.Update(loggedInUser);
                return true;
            }
            return false;
        }
    }
}
