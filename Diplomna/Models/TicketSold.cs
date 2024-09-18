using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna.Models
{
    public class TicketSold
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int FlightsId { get; set; }
        public decimal? FinalPrice { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
