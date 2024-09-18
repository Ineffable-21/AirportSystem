using Diplomna.DataAccess;
using Diplomna.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna.DBWork
{
    internal class UserWork(DBDataAccess dbContext)
    {
        private readonly DBDataAccess _dbContext = dbContext;

        public List<Models.User> GetAllUsers()
        {
            #pragma warning disable IDE0305 // Simplify collection initialization
            return _dbContext.Users.ToList();
            #pragma warning restore IDE0305 // Simplify collection initialization
        }

        public void CreateUsers(Models.User users)
        {
            _dbContext.Users.Add(users);
            _dbContext.SaveChanges();
        }

        public void UpdateUsers(Models.User users)
        {
            _dbContext.Users.Update(users);
            _dbContext.SaveChanges();
        }

        public void AddLastLoginToUsers(int? usersId)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == usersId);
            if (user != null)
            {
                user.LastLogin = DateTime.Now;
                _dbContext.SaveChanges();
            }
        }

        public void DeleteUsers(int usersId)
        {
            var user = _dbContext.Users.Find(usersId);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }
    }
}
