using System;

namespace HotelApp.Models
{
    public class VisitorModel
    {

        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public decimal TotalCost { get; set; }
        public int? RoomId { get; set; }
    }
}