

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApp.DataAccess;
using HotelApp.DataAccess.Entities;
using HotelApp.Models.Room;
using HotelApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace HotelApp.Services
{
    public class RoomService:IRoomService
    {
        private readonly HotelContext _hotelContext;

        public RoomService(HotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }

        public async Task<ICollection<RoomPresentationModel>> GetRooms()
        {
            var rooms = await _hotelContext.Rooms.Select(a => new RoomPresentationModel()
            {
                 RoomId = a.RoomId,
                 Number = a.Number,
                 Capacity = a.Capacity,
                 RoomStateId = a.RoomStateId,
                 RoomTypeId = a.RoomTypeId
            }).ToListAsync();
            return rooms;
        }

        public async Task<int> AddRoom(RoomModel roomModel)
        {
            var room = new Room()
            {
               Capacity = roomModel.Capacity,
               Number = roomModel.Number,
               RoomTypeId = roomModel.RoomTypeId,
               RoomStateId = roomModel.RoomStateId
            };
            
            
            await _hotelContext.Rooms.AddAsync(room);
            await _hotelContext.SaveChangesAsync();
            return room.RoomId;
        }
    }
}