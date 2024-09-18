using Diplomna.DataAccess;
using Diplomna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna.DBWork
{
    internal class ClientWork(DBDataAccess dbContext)
    {
        private readonly DBDataAccess _dbContext = dbContext;

        public List<Client> GetAllClients()
        {
            #pragma warning disable IDE0305 // Simplify collection initialization
            return _dbContext.Clients.ToList();
            #pragma warning restore IDE0305 // Simplify collection initialization
        }

        public void CreateClient(Client client)
        {
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();
        }

        public void UpdateClient(Client client)
        {
            _dbContext.Clients.Update(client);
            _dbContext.SaveChanges();
        }

        public void DeleteClient(int clientId)
        {
            var client = _dbContext.Clients.Find(clientId);
            if (client != null)
            {
                _dbContext.Clients.Remove(client);
                _dbContext.SaveChanges();
            }
        }

        public List<Client> FilterClients(string? name = null, DateTime? dateOfBirth = null, string? sexId = null, string? phoneNumber = null, string? emailAddress = null)
        {
            var qClientFilter = _dbContext.Clients.AsQueryable();

            if (!string.IsNullOrWhiteSpace(name))
            {
                qClientFilter = qClientFilter.Where(c => c.Name!.Contains(name));
            }

            if (dateOfBirth.HasValue)
            {
                qClientFilter = qClientFilter.Where(c => c.DateOfBirth == dateOfBirth.Value);
            }

            if (!string.IsNullOrWhiteSpace(sexId))
            {
                qClientFilter = qClientFilter.Where(c => c.SexId == sexId);
            }

            if (!string.IsNullOrWhiteSpace(phoneNumber))
            {
                qClientFilter = qClientFilter.Where(c => c.PhoneNumber!.Contains(phoneNumber));
            }

            if (!string.IsNullOrWhiteSpace(emailAddress))
            {
                qClientFilter = qClientFilter.Where(c => c.EmailAddress!.Contains(emailAddress));
            }

            return [.. qClientFilter];
        }
    }
}
