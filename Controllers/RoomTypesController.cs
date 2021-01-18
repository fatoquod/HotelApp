using System.Threading.Tasks;
using HotelApp.DataAccess;
using HotelApp.DataAccess.Entities;
using HotelApp.Models;
using HotelApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    [ApiController] 
    [Route("api/[controller]")]
    public class RoomTypesController : Controller
    {
        private readonly IRoomTypeService _service;

        public RoomTypesController(HotelContext hotelContext, IRoomTypeService service)
        {
            _service = service;
        }

        [HttpPost("add-roomType")]
        public async Task<int> AddRoomType([FromBody] RoomTypeModel roomTypeModel) =>
            await _service.AddRoomType(roomTypeModel);

    }
}