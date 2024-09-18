using Diplomna.DataAccess;
using Diplomna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomna.DBWork
{
    class PlaneWork(DBDataAccess dbContext)
    {
        private readonly DBDataAccess _dbContext = dbContext;
        public List<Plane> GetAllPlanes()
        {
            #pragma warning disable IDE0305 // Simplify collection initialization
            return _dbContext.Planes.ToList();
            #pragma warning restore IDE0305 // Simplify collection initialization
        }
        public void CreatePlane(Plane plane)
        {
            _dbContext.Planes.Add(plane);
            _dbContext.SaveChanges();
        }

        public void UpdatePlane(Plane plane)
        {
            _dbContext.Planes.Update(plane);
            _dbContext.SaveChanges();
        }

        public void DeletePlane(int Planeid)
        {
            var plane = _dbContext.Planes.Find(Planeid);
            if (plane != null)
            {
                _dbContext.Planes.Remove(plane);
                _dbContext.SaveChanges();
            }
        }
    }
}
