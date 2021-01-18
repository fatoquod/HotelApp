using System.Threading.Tasks;
using HotelApp.DataAccess;
using HotelApp.Models;
using HotelApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelApp.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    public class VisitorController:Controller
    {
        private readonly HotelContext _hotelContext;
        private readonly IVisitorService _service;

        public VisitorController(HotelContext hotelContext, IVisitorService service)
        {
            _hotelContext = hotelContext;
            _service = service;
        }
        [HttpPost("add-visitor")]
        public async Task<int> AddVisitor([FromBody] VisitorModel visitorModel) =>
            await _service.AddVisitor(visitorModel);
    }
}