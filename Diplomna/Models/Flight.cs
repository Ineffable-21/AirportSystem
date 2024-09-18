using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string? FromAirport { get; set; }
        public string? ToAirport { get; set; }
        public DateTime TakeOffTime { get; set; }
        public DateTime LandingTime { get; set; }
        public int FreeSpaces { get; set; }
        public int PlaneId { get; set; }
        public string? FlightSituationId { get; set; }
        public string? Reason { get; set; }
        public int? DelayMinutes { get; set; }
        public bool? ShouldReturnMoney { get; set; }
    }
}
