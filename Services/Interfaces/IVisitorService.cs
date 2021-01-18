using System.Threading.Tasks;
using HotelApp.Models;

namespace HotelApp.Services.Interfaces
{
    public interface IVisitorService
    {
        public Task<int> AddVisitor(VisitorModel visitorModel);
    }
}