using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using HotelSystem.Services.Interface;
using HotelSystem.Domain.DomainModels;
using HotelSystem.Domain.DTO;

namespace HotelSystem.Web.Controllers
{
    public class HotelsController : Controller
    {
        private readonly IHotelService _hotelService;
       // private readonly UserManager<HotelApplicationUser> _userManager;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
           // _userManager = userManager;
        }

        // GET: Hotels
        public IActionResult Index()
        {
            var allHotels = this._hotelService.GetAllHotels();
            return View(allHotels);
        }

        public IActionResult AddHotelToCard(Guid? id)
        {
            var model = this._hotelService.GetHotelCartInfo(id);
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddHotelToCard([Bind("HotelId","checkin","checkout")] AddToHotelCartDto item)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = this._hotelService.AddToHotelCart(item, userId);

            if(result)
            {
                return RedirectToAction("Index", "Hotels");
            }
            
            return View(item);
        }

        // GET: Hotels/Details/5
        public  IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = this._hotelService.GetDetailsForHotel(id);
            
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        // GET: Hotels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hotels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,HotelName,HotelImage,City,HotelDescription,Price,Stars")] Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                this._hotelService.CreateNewHotel(hotel);
                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
        }

        // GET: Hotels/Edit/5
        public  IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = this._hotelService.GetDetailsForHotel(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return View(hotel);
        }

        // POST: Hotels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,HotelName,HotelImage,City,HotelDescription,Price,Stars")] Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._hotelService.UpdateExistingHotel(hotel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelExists(hotel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
        }

        // GET: Hotels/Delete/5
        public  IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = this._hotelService.GetDetailsForHotel(id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        // POST: Hotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            this._hotelService.DeleteHotel(id);
            return RedirectToAction(nameof(Index));
        }

        private bool HotelExists(Guid id)
        {
            return this._hotelService.GetDetailsForHotel(id) != null;
        }
    }
}
