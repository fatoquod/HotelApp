using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace HotelApp.Entities
{
    public class Visitor
    {
        [Key]
        public int VisitorId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string SecondName { get; set; }
        [StringLength(50)]
        public string Patronymic { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ArrivalDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DepartureDate { get; set; }
        public decimal TotalCost;
        public int? RoomId { get; set; }
        public virtual Room Room { get; set; }
    }
}