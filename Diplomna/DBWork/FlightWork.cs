using Diplomna.DataAccess;
using Diplomna.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna.DBWork
{
    internal class FlightWork(DBDataAccess dbContext)
    {
        private readonly DBDataAccess _dbContext = dbContext;
        public List<Flight> GetAllFlights()
        {
            #pragma warning disable IDE0305 // Simplify collection initialization
            return _dbContext.Flights.ToList();
            #pragma warning restore IDE0305 // Simplify collection initialization
        }
        public void CreateFlight(Flight flight)
        {
            _dbContext.Flights.Add(flight);
            _dbContext.SaveChanges();
        }

        public void UpdateFlight(Flight flight)
        {
            _dbContext.Flights.Update(flight);
            _dbContext.SaveChanges();
        }

        public void DeleteFlight(int Flightid)
        {
            var flight = _dbContext.Flights.Find(Flightid);
            if (flight != null)
            {
                _dbContext.Flights.Remove(flight);
                _dbContext.SaveChanges();
            }
        }
    }
}
