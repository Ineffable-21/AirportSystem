using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna.Models
{
    public class UserLoginLog
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
