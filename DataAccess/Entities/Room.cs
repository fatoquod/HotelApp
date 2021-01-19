using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.DataAccess.Entities
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }
        public int? RoomTypeId { get; set; }
        public virtual RoomType RoomType { get; set; }
        public int? RoomStateId { get; set; }
        public virtual RoomState RoomState { get; set; }
        public ICollection<Visitor> Visitors { get; set; } // add virtual
    }
}
