using Diplomna.DataAccess;
using Diplomna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna.DBWork
{
    internal class UserLoginLogWork(DBDataAccess dbContext)
    {
        private readonly DBDataAccess _dbContext = dbContext;

        public List<UserLoginLog> GetAllLogs()
        {
            #pragma warning disable IDE0305 // Simplify collection initialization
            return _dbContext.UserLoginLog.ToList();
            #pragma warning restore IDE0305 // Simplify collection initialization
        }

        public void CreateLogs(UserLoginLog logs)
        {
            _dbContext.UserLoginLog.Add(logs);
            _dbContext.SaveChanges();
        }

        public void UpdateLogs(UserLoginLog logs)
        {
            _dbContext.UserLoginLog.Update(logs);
            _dbContext.SaveChanges();
        }

        public void DeleteLogs(int userLoginLogsId)
        {
            var log = _dbContext.UserLoginLog.Find(userLoginLogsId);
            if (log != null)
            {
                _dbContext.UserLoginLog.Remove(log);
                _dbContext.SaveChanges();
            }
        }
    }
}

