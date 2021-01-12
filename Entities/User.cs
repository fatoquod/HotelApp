using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Entities
{
    public class User
    {
        
        [Key]
        public int UserId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public virtual Role Role { get; set; }
        
    }                                      
}                       