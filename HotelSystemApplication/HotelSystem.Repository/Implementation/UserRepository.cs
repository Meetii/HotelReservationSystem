using HotelSystem.Domain.Identity;
using HotelSystem.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelSystem.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<HotelApplicationUser> entities;
        string errorMessage = string.Empty;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<HotelApplicationUser>();
        }

        public IEnumerable<HotelApplicationUser> GetAll()
        {
            return entities.AsEnumerable();
        }

        public HotelApplicationUser Get(string id)
        {
                 return entities
                .Include(z=>z.UserCart)
                .Include("UserCart.HotelInReservationCarts")
                .Include("UserCart.HotelInReservationCarts.Hotel")
                .SingleOrDefault(s => s.Id == id);
        }

        public void Insert(HotelApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }
        public void Update(HotelApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }
        public void Delete(HotelApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
