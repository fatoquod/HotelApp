namespace HotelApp.Models.User
{
    /// <summary>
    /// Модель поиска пользователей
    /// </summary>
    public class UserShortModel
    {
        /// <summary>
        /// Имя 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Фамилия 
        /// </summary>
        public string SecondName { get; set; }
        /// <summary>
        /// Логин 
        /// </summary>
        public string Login { get; set; }
    }
}