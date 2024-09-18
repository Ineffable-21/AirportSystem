using Diplomna.DataAccess;
using Diplomna.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Diplomna.DBWork
{
    internal class TicketSoldWork(DBDataAccess dbContext)
    {
        private readonly DBDataAccess _dbContext = dbContext;

        public List<TicketSold> GetAllTickets()
        {
            #pragma warning disable IDE0305 // Simplify collection initialization
            return _dbContext.TicketsSold.ToList();
            #pragma warning restore IDE0305 // Simplify collection initialization
        }

        public void CreateTickets(TicketSold tickets)
        {
            _dbContext.TicketsSold.Add(tickets);
            _dbContext.SaveChanges();
        }

        public void UpdateTickets(TicketSold tickets)
        {
            _dbContext.TicketsSold.Update(tickets);
            _dbContext.SaveChanges();
        }

        public void DeleteTickets(int ticketsId)
        {
            var ticket = _dbContext.TicketsSold.Find(ticketsId);
            if (ticket != null)
            {
                _dbContext.TicketsSold.Remove(ticket);
                _dbContext.SaveChanges();
            }
        }

        public Plane GetPlaneByFlightId(int flightId)
        {
            var flight = _dbContext.Flights.FirstOrDefault(f => f.Id == flightId);

            var plane = _dbContext.Planes.FirstOrDefault(p => p.Id == flight!.PlaneId);

            if (plane == null)
            {
                return null!;
            }
            return plane;
        }
    }
}
