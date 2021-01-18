using System.Collections.Generic;
using System.Threading.Tasks;
using HotelApp.DataAccess;
using HotelApp.Models.Room;
using HotelApp.Services;
using HotelApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomsController : Controller
    {
        private readonly IRoomService _service;

        public RoomsController(IRoomService service, HotelContext hotelContext)
        {
            _service = service;
        }
        [HttpGet("get-room-represent")]
        public async Task<ICollection<RoomPresentationModel>> GetRooms() =>
            await _service.GetRooms();

        [HttpPost("add-room")]
        public async Task<int> AddRoom(RoomModel roomModel) =>
            await _service.AddRoom(roomModel);
        
    }
}