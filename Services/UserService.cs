

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApp.DataAccess;
using HotelApp.DataAccess.Entities;
using HotelApp.Models.User;
using HotelApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelApp.Services
{
    public class UserService:IUserService
    {
        private readonly HotelContext _hotelContext;

        public UserService(HotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }

        public async Task<UserModel> GetById(int userId)
        {
            var user = await _hotelContext.Users.Select(a => new UserModel()
            {
                Login = a.Login,
                Name = a.Name,
                SecondName = a.SecondName,
                UserId = a.UserId
            }).SingleOrDefaultAsync(a => a.UserId == userId) ?? throw new Exception("User is null");
            
            return user;
        }
        
        public async Task<IActionResult> UpdateUser([FromRoute] int userId, [FromBody] UserModel userModel)
        {
            var user = await _hotelContext.Users.SingleOrDefaultAsync(a => a.UserId == userId) ??
                       throw new Exception($"ID - {userId} не найден!");
            user.Login = userModel.Login;
            user.Name = userModel.Name;
            user.SecondName = userModel.SecondName;
            user.Password = userModel.Password;
            _hotelContext.Users.Update(user);
            await _hotelContext.SaveChangesAsync();
            return null;
        }
        public async Task<IActionResult> DelUser([FromRoute] int userId)
        {
            var user = await _hotelContext.Users.SingleOrDefaultAsync(a => a.UserId == userId);
            _hotelContext.Users.Remove(user);
            await _hotelContext.SaveChangesAsync();
            return null;
        }
        public async Task<int> AddUser([FromBody] UserModel userModel)
        {
            
            var user = new User
            {
                Name = userModel.Name,
                Login = userModel.Login,
                SecondName = userModel.SecondName,
                Password = userModel.Password
            };
            await _hotelContext.Users.AddAsync(user);
            await _hotelContext.SaveChangesAsync();
            return user.UserId;
        }
        public async Task<ICollection<User>> SearchUser([FromQuery] UserSearchModel userSearchModel)
        {
            var usersQuery=_hotelContext.Users.AsQueryable();
            if (userSearchModel.User!=null)
            {
                usersQuery =  usersQuery.Where(a =>
                    a.Name.Contains(userSearchModel.User.Name) ||
                    a.SecondName.Contains(userSearchModel.User.SecondName) ||
                    a.Login.Contains(userSearchModel.User.Login));
            }
            usersQuery = usersQuery.OrderBy(a=>a.UserId).Skip(userSearchModel.StartRow)
                .Take(userSearchModel.EndRow - userSearchModel.StartRow);
            var users = await usersQuery.ToListAsync();
            return users;
        }
        public async Task<ICollection<UserLoginModel>> GetLogins()
        {
            var users = await _hotelContext.Users.Select(a => new UserLoginModel()
            {
                Login = a.Login,
                UserId = a.UserId
            }).ToListAsync();
            return users;
        }
    }
}