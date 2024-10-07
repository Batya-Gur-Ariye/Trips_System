using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_Trips_Core.IServices;
using Project_Trips_Core.ModelDto;
using Project_Trips_Core.Services;
using Project_Trips_Data.Models;

namespace Project_Trips_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        private readonly ITripService _tripsService;
        public TripsController(ITripService tripsService)
        {
            _tripsService = tripsService;
        }

        [HttpGet]
        [Route(nameof(GetAll))]
        public async Task<List<TripDto>> GetAll()
        {
            return await _tripsService.GetAllTrips();
        }

        [HttpGet]
        [Route(nameof(GetFutureTrips))]
        public async Task<List<TripDto>> GetFutureTrips()
        {
            return await _tripsService.GetFutureTrips();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route(nameof(AddTrip))]

        public async Task<ActionResult<bool>> AddTrip( TripDto t)
        {
            if(await _tripsService.AddTrip(t))
                return Ok(true);
            return BadRequest();
        }

        [HttpPut]      
        [Route(nameof(UpdateTrip))]
        public async Task<ActionResult<bool>> UpdateTrip(TripDto trip)
        {         
            if (await _tripsService.UpdateTrip(trip))
                return Ok(true);
            return NotFound();
        }
    }
}
