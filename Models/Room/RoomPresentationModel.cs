namespace HotelApp.Models.Room
{
    public class RoomPresentationModel
    {
        public int RoomId { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }
        public int? RoomTypeId { get; set; }
        public int? RoomStateId { get; set; }
    }
}