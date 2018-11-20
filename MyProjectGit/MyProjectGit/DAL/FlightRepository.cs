using MyProjectGit.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProjectGit.DAL
{
    public class FlightRepository : IFlightRepository
    {
        public void Create (Flight flight)
        {
        }
        public void Deleted(Flight flight)
        {
            throw new NotImplementedException();
        }

        public void Update (Flight flight)
        {
            throw new NotImplementedException();
        }
        public Flight Get (Guid Id )
        {
            throw new NotImplementedException();
        }
        
        
    }
}
