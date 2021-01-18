using System.Collections.Generic;
using System.Threading.Tasks;
using HotelApp.DataAccess.Entities;
using HotelApp.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserModel> GetById(int userId);
        Task<IActionResult> UpdateUser(int userId, UserModel userModel);
        Task<IActionResult> DelUser(int userId);
        Task<int> AddUser([FromBody] UserModel userModel);
        Task<ICollection<User>> SearchUser([FromQuery] UserSearchModel userSearchModel);
        Task<ICollection<UserLoginModel>> GetLogins();
    }
}