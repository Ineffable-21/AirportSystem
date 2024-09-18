using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna.Models
{
    public class Plane
    {
        public int Id { get; set; }
        public int TotalSpaces { get; set; }
        public bool CanFly { get; set; }
        public bool HasEconomySeats { get; set; }
        public int? EconomyTicketsCount { get; set; }
        public decimal? EconomyTicketsPrice { get; set; }
        public bool HasBusinessSeats { get; set; }
        public int? BusinessTicketsCount { get; set; }
        public decimal? BusinessTicketsPrice { get; set; }
        public bool HasFirstClassSeats { get; set; }
        public int? FirstClassTicketsCount { get; set; }
        public decimal? FirstClassTicketsPrice { get; set; }
    }
}
