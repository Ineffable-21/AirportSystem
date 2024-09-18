using Diplomna.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Diplomna.DataAccess
{
    public class DBDataAccess(DbContextOptions<DBDataAccess> options) : DbContext(options)
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightSituation> FlightSituation { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Sex> Sexes { get; set; }
        public DbSet<TicketSold> TicketsSold { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersType> UsersTypes { get; set; }
        public DbSet<UserLoginLog> UserLoginLog { get; set; }
    }
}
