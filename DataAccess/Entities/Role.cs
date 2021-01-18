﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.DataAccess.Entities
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}