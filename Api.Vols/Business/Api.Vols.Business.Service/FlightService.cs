using Api.Vols.Datas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Vols.Business.Service
{
    public class FlightService
    {
        /// <summary>
        /// The flight repository
        /// </summary>
        private readonly IFlightRepository _flightRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="FlightService"/> class.
        /// </summary>
        /// <param name="flightRepository">The flight repository.</param>
        public FlightService (IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }
    }
}
