using System.Threading.Tasks;
using HotelApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Services.Interfaces
{
    public interface IRoomStateService
    {
        Task<int> AddRoomState(RoomStateModel roomStateModel);
    }
}