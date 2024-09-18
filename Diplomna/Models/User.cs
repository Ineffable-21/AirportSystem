using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna.Models
{
    public class User
    {
        public int? Id { get; set; }
        public string? UserTypeId { get; set; }
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? SexId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? UserName { get; set; }
        public string? HashedUserPassword { get; set; }
        public string? Salt { get; set; }
        public DateTime LastLogin { get; set; }
        public int FailedLoginCount { get; set; }
        public bool LockedUser { get; set; }
    }
}
