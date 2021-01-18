using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HotelApp.DataAccess;
using HotelApp.DataAccess.Entities;
using HotelApp.Models;
using HotelApp.Models.User;
using HotelApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly HotelContext _hotelContext;
        private readonly IUserService _userService;
        
        public UsersController(HotelContext hotelContext, IUserService userService)
        {
            _hotelContext = hotelContext;
            _userService = userService;
        }

        [HttpPost("add-user")]
        public async Task<int> AddUser([FromBody] UserModel userModel) =>
            await _userService.AddUser(userModel);

        [HttpDelete("del-user/{userId}")]
        public async Task<IActionResult> DelUser([FromRoute] int userId) =>
           await _userService.DelUser(userId);

        [HttpPut]
        [Route("update-user/{userId}")]
        public async Task<IActionResult> UpdateUser([FromRoute] int userId, [FromBody] UserModel userModel) =>
            await _userService.UpdateUser(userId, userModel);

        [HttpGet("{userId}")]
        public async Task<UserModel> GetUser(int userId)=>
             await _userService.GetById(userId);
        
        [HttpGet]
        public async Task<ICollection<User>> GetUsers()
        {
            var users = await _hotelContext.Users.OrderBy(a=>a.Login).ToListAsync();
            return users;
        }

        /// <summary>
        /// Поиск по пользователям
        /// </summary>
        /// <param name="userSearchModel"></param>
        /// <returns></returns>
        [HttpGet("search-user")]
        public async Task<ICollection<User>> SearchUser([FromQuery] UserSearchModel userSearchModel) =>
            await _userService.SearchUser(userSearchModel);

        [HttpGet]
        [Route("get-logins")]
        public async Task<ICollection<UserLoginModel>> GetLogins() =>
            await _userService.GetLogins();

    }
}