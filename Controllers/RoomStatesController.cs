using System.Threading.Tasks;
using HotelApp.DataAccess;
using HotelApp.Models;
using HotelApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomState : Controller
    {
        private readonly HotelContext _hotelContext;
        private readonly IRoomStateService _service;

        public RoomState(HotelContext hotelContext, IRoomStateService service)
        {
            _hotelContext = hotelContext;
            _service = service;
        }
        [HttpPost("add-room-state")]
        public async Task<int> AddRoomState(RoomStateModel roomStateModel) =>
            await _service.AddRoomState(roomStateModel);
        
    }
}