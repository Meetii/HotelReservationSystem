using HotelSystem.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSystem.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<HotelApplicationUser> GetAll();
        HotelApplicationUser Get(string id);
        void Insert(HotelApplicationUser entity);
        void Update(HotelApplicationUser entity);
        void Delete(HotelApplicationUser entity);
    }
}
