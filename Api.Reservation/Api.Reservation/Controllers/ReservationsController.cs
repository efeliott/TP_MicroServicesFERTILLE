using Api.Reservation.Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace Api.Reservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        /// <summary>
        /// The reservation service
        /// </summary>
        private readonly IReservationService _reservationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationsController"/> class.
        /// </summary>
        /// <param name="reservationService">The reservation service.</param>
        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        // GET: api/Reservations
        [HttpGet]
        [ProducesResponseType(typeof(List<Datas.Entities.Reservation>), 200)]
        public async Task<IActionResult> GetReservationsAsync()
        {
            return Ok(await _reservationService.GetReservationsAsync());
        }

    }
}
