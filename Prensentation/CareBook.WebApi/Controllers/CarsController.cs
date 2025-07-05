using CareBook.Application.Features.CQRS.Comments.CarCommands;
using CareBook.Application.Features.CQRS.Handlers.CarHandlers;
using CareBook.Application.Features.CQRS.Handlers.CarHandlers;
using CareBook.Application.Features.CQRS.Queries.CarQueries;
using CareBook.Application.Features.Mediator.Queries.StatisticsQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CareBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CreateCarCommandHandler _createCarCommadHandler;
        private readonly GetCarByIDQueryHandler _getCarByIdQueryHandler;
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly UpdateCarCommandsHandler _updateCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;
        private readonly GetLast5CarWithBrandQueryHandler _getLast5CarWithQueryHandler;
        
        public CarsController(CreateCarCommandHandler createCarCommadHandler, GetCarWithBrandQueryHandler getCarWithBrandQueryHandler, GetCarByIDQueryHandler getCarByIdQueryHandler, GetCarQueryHandler getCarQueryHandler, UpdateCarCommandsHandler updateCarCommandHandler, RemoveCarCommandHandler removeCarCommandHandler, GetLast5CarWithBrandQueryHandler getLast5CarWithQueryHandler)
        {
            _createCarCommadHandler = createCarCommadHandler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _getCarQueryHandler = getCarQueryHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
            _getLast5CarWithQueryHandler = getLast5CarWithQueryHandler;

        }
        [HttpGet]
        public async Task<IActionResult> CarList()
        {
            var values = await _getCarQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var values = await _getCarByIdQueryHandler.Handle(new GetCarByIDQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommands command)
        {
            await _createCarCommadHandler.Handle(command);
            return Ok("Araç Bilgisi Eklenmiştir.");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            await _removeCarCommandHandler.Handle(new RemoveCarCommands(id));
            return Ok("Araç Bilgisi Silinmiştir.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommands command)
        {
            await _updateCarCommandHandler.Handle(command);
            return Ok("Araç Bilgisi Güncellenmiştir.");
        }
        [HttpGet("GetCarWithBrand")]
        public IActionResult GetCarWithBrand()
        {
            var values = _getCarWithBrandQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("GetLast5CarWithBrand")]
        public IActionResult GetLast5CarWithBrand()
        {
            var values = _getLast5CarWithQueryHandler.Handle();
            return Ok(values);
        }
        
    }
}
