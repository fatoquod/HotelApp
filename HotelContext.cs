using HotelApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp
{
    public class HotelContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomState> RoomStates { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=HotelDB;Username=postgres;Password=12345");
            base.OnConfiguring(optionsBuilder);
        } 
    }

    
    
}