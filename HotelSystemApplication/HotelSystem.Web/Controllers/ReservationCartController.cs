using HotelSystem.Domain.DomainModels;
using HotelSystem.Domain.DTO;
using HotelSystem.Domain.Identity;
using HotelSystem.Repository;
using HotelSystem.Services.Interface;
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
        private readonly IReservationCartService _reservationCartService;
        private readonly UserManager<HotelApplicationUser> _userManager;
        public ReservationCartController(IReservationCartService reservationCartService, UserManager<HotelApplicationUser> userManager)
        {
            _reservationCartService = reservationCartService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            //with NameIdentifier we get the ID of the user!
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View(this._reservationCartService.getReservationCartInfo(userId));
        }

        public IActionResult DeleteHotelFromReservationCart(Guid hotelid)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = this._reservationCartService.deleteHotelFromReservationCart(userId, hotelid);

            if (result)
            {
                return RedirectToAction("Index", "ReservationCart");
            }
            else
            {
                return RedirectToAction("Index", "ReservationCart");
            }

        }

        public IActionResult OrderNow()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = this._reservationCartService.orderNow(userId);

            if (result) {

                return RedirectToAction("Index", "ReservationCart");
            }
            else
            {
                return RedirectToAction("Index", "ReservationCart");
            }
        }
    }
}
