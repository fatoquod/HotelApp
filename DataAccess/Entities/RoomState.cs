using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.DataAccess.Entities
{
    public class RoomState
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)] 
        public string Name { get; set; }
        public ICollection<Room> Rooms { get; set; } //add virtual
        //add ctor with init collection
    }
}
