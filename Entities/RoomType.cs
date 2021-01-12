using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.Entities
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        [StringLength(20)] 
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
        
}