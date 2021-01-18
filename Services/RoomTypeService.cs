using System.ComponentModel.Design;
using System.Threading.Tasks;
using HotelApp.DataAccess;
using HotelApp.DataAccess.Entities;
using HotelApp.Models;
using HotelApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Services
{
    public class RoomTypeService:IRoomTypeService

    {
    private readonly HotelContext _hotelContext;

    public RoomTypeService(HotelContext hotelContext)
    {
        _hotelContext = hotelContext;
    }

    public async Task<int> AddRoomType([FromBody] RoomTypeModel roomTypeModel)
    {
        var roomType = new RoomType()
        {
            Name = roomTypeModel.Name,
            Price = roomTypeModel.Price,

        };
        await _hotelContext.RoomTypes.AddAsync(roomType);
        await _hotelContext.SaveChangesAsync();
        return roomType.RoomTypeId;
    }
    }
}