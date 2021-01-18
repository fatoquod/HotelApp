using System.Threading.Tasks;
using HotelApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Services.Interfaces
{
    public interface IRoomTypeService
    {
        Task<int> AddRoomType([FromBody] RoomTypeModel roomTypeModel);
    }
}