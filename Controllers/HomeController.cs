using System.Threading.Tasks;
using HotelApp.Entities;
using HotelApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly HotelContext _hotelContext;

        public HomeController(HotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }

        [HttpPost("add-user")]
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

        public string Say()
        {
            return "Hello";
        }
        public async Task<string> SayAsync()
        {
            return await Task.Run(Say);
        }
        [HttpGet]
        public string Index()
        {
            return "Кукеч";
        }
    }
    
}