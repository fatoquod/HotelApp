using HotelApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.DataAccess
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomState> RoomStates { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
    }
}