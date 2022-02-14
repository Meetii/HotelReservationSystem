using HotelSystem.Domain.DomainModels;
using HotelSystem.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace HotelSystem.Repository
{
    public class ApplicationDbContext : IdentityDbContext<HotelApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<ReservationCart> ReservationCarts { get; set; }
        public virtual DbSet<HotelInReservationCart> HotelInReservationCarts { get; set; }
        public virtual DbSet<HotelInOrder> HotelInOrders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Hotel>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<ReservationCart>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<HotelInReservationCart>()
                .HasKey(z => new { z.HotelId, z.ReservationCartId });

            builder.Entity<HotelInReservationCart>()
                .HasOne(z => z.Hotel)
                .WithMany(z => z.HotelInReservationCarts)
                .HasForeignKey(z => z.ReservationCartId);

            builder.Entity<HotelInReservationCart>()
                .HasOne(z => z.ReservationCart)
                .WithMany(z => z.HotelInReservationCarts)
                .HasForeignKey(z => z.HotelId);

            builder.Entity<ReservationCart>()
                .HasOne<HotelApplicationUser>(z => z.Owner)
                .WithOne(z => z.UserCart)
                .HasForeignKey<ReservationCart>(z => z.OwnerId);

            builder.Entity<HotelInOrder>()
                .HasKey(z => new { z.HotelId, z.OrderId });

            builder.Entity<HotelInOrder>()
                .HasOne(z => z.SelectedHotel)
                .WithMany(z => z.Orders)
                .HasForeignKey(z => z.HotelId);

            builder.Entity<HotelInOrder>()
                .HasOne(z => z.UserOrder)
                .WithMany(z => z.Hotels)
                .HasForeignKey(z => z.OrderId);

        }
    }
}
