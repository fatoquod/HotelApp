using System.Collections.Generic;
using System.Threading.Tasks;
using HotelApp.Models;
using HotelApp.Models.Room;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Services.Interfaces
{
    public interface IRoomService
    {
        Task<ICollection<RoomPresentationModel>> GetRooms();
        Task<int> AddRoom([FromBody] RoomModel roomModel);
    }
}