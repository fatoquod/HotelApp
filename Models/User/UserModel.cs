namespace HotelApp.Models.User
{/// <summary>
    /// Модель пользователя
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// ID 
        /// </summary>
        public int UserId { get; set; }
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
        /// <summary>
        /// Пароль 
        /// </summary>
        public string Password { get; set; }
   
    }
}