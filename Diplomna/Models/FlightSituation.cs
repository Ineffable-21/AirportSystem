using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna.Models
{
    public class FlightSituation
    {
        [Key]
        public string? FlightSituationName { get; set; }
    }
}
