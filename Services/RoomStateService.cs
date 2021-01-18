using System.Threading.Tasks;
using HotelApp.DataAccess;
using HotelApp.DataAccess.Entities;
using HotelApp.Models;
using HotelApp.Models.User;
using HotelApp.Services.Interfaces;

namespace HotelApp.Services
{
    public class RoomStateService:IRoomStateService
    {
        private readonly HotelContext _hotelContext;

        public RoomStateService(HotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }
        
         public async Task<int> AddRoomState(RoomStateModel roomStateModel)
         {
             var roomState = new RoomState()
             {
                 Name = roomStateModel.Name
             };
            await _hotelContext.RoomStates.AddAsync(roomState);
            await _hotelContext.SaveChangesAsync();
            return roomState.Id;
        }
    }
}