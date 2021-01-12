using System.Collections;
using System.Collections.Generic;

namespace HotelApp.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}