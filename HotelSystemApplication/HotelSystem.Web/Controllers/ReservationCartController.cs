/*using HotelSystem.Web.Data;
using HotelSystem.Domain.DomainModels;
using HotelSystem.Domain.DTO;
using HotelSystem.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HotelSystem.Web.Controllers
{
    public class ReservationCartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<HotelApplicationUser> _userManager;
        public ReservationCartController(ApplicationDbContext context, UserManager<HotelApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            //with NameIdentifier we get the ID of the user!
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInUser = await _context.Users
                .Where(z => z.Id==userId)
                .Include(z=>z.UserCart)
                .Include(z=>z.UserCart.HotelInReservationCarts)
                .Include("UserCart.HotelInReservationCarts.Hotel")
                .FirstOrDefaultAsync();

            var userShoppingCart = loggedInUser.UserCart;
            var hotelprice = userShoppingCart.HotelInReservationCarts.Select(z => new
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

            //var allHotels = userShoppingCart.HotelInReservationCarts.Select(z => z.Hotel).ToList();
            
            return View(hotelCartDtoItem);
        }

        public async Task<IActionResult> DeleteHotelFromReservationCart(Guid hotelid)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var loggedInUser = await _context.Users
                .Where(z => z.Id == userId)
                .Include(z => z.UserCart)
                .Include(z => z.UserCart.HotelInReservationCarts)
                .Include("UserCart.HotelInReservationCarts.Hotel")
                .FirstOrDefaultAsync();

            var userHotelCart = loggedInUser.UserCart;

            var reservationToDelete = userHotelCart.HotelInReservationCarts
                .Where(z => z.Hotel.Id.Equals(hotelid))
                .FirstOrDefault();

            userHotelCart.HotelInReservationCarts.Remove(reservationToDelete);
            

            _context.Update(userHotelCart);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "ReservationCart");
        }

        public async Task<IActionResult> OrderNow()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInUser = await _context.Users
                .Where(z => z.Id == userId)
                .Include(z => z.UserCart)
                .Include(z => z.UserCart.HotelInReservationCarts)
                .Include("UserCart.HotelInReservationCarts.Hotel")
                .FirstOrDefaultAsync();

            var userHotelCart = loggedInUser.UserCart;


            Order orderItem = new Order
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                User = loggedInUser
            };


            _context.Add(orderItem);
           // await _context.SaveChangesAsync();

            List<HotelInOrder> hotelInOrders = new List<HotelInOrder>();
            hotelInOrders = userHotelCart.HotelInReservationCarts
                .Select(z => new HotelInOrder
                {
                    OrderId = orderItem.Id,
                    HotelId = z.Hotel.Id,
                    SelectedHotel = z.Hotel,
                    UserOrder = orderItem
                }).ToList();

            foreach (var item in hotelInOrders)
            {
                    _context.Add(item);
                   // await _context.SaveChangesAsync();
            }

            loggedInUser.UserCart.HotelInReservationCarts.Clear();
            
            _context.Update(loggedInUser);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "ReservationCart");
        }
    }
}
*/