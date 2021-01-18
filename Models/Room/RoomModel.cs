namespace HotelApp.Models.Room
{
    public class RoomModel
    {
        public int Number { get; set; }
        public int Capacity { get; set; }
        public int? RoomTypeId { get; set; }
        public int? RoomStateId { get; set; }
    }
}