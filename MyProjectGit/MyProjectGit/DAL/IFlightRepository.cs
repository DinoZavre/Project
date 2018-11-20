using System;
using MyProjectGit.Entities;

namespace MyProjectGit.DAL
{
    public interface IFlightRepository
    {
        void Create(Flight flight);
        void Deleted(Flight flight);
        Flight Get(Guid Id);
        void Update(Flight flight);
    }
}