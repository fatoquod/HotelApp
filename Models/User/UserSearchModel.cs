namespace HotelApp.Models.User
{
    public class UserSearchModel
    {
        public int StartRow { get; set; }
        public int EndRow { get; set; }
        public UserShortModel User { get; set; }
    }
}