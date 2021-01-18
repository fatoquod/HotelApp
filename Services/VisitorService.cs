using System.Threading.Tasks;
using HotelApp.DataAccess;
using HotelApp.DataAccess.Entities;
using HotelApp.Models;
using HotelApp.Services.Interfaces;

namespace HotelApp.Services
{
    public class VisitorService:IVisitorService
    {
        private readonly HotelContext _hotelContext;

        public VisitorService(HotelContext hotelContext)
        {
            _hotelContext = hotelContext;
        }

        public async Task<int> AddVisitor(VisitorModel visitorModel)
        {
            var visitor = new Visitor()
            {
                Name = visitorModel.Name,
                SecondName = visitorModel.SecondName,
                Patronymic = visitorModel.Patronymic,
                RoomId = visitorModel.RoomId,
                ArrivalDate = visitorModel.ArrivalDate,
                DepartureDate = visitorModel.DepartureDate,
                TotalCost = visitorModel.TotalCost
            };
            await _hotelContext.Visitors.AddAsync(visitor);
            await _hotelContext.SaveChangesAsync();
            return visitor.VisitorId;
        }
    }
}