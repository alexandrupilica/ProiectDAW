using ProiectDAW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.IRepositories
{
    public interface IProducerRepository : IGenericRepository<Producer>
    {
        Producer GetByIdJoined(int id);
    }
}
