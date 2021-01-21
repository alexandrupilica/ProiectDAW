using ProiectDAW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.IRepositories
{
    public interface IArtistRepository : IGenericRepository<Artist>
    {
        Artist GetByIdJoined(int id);
    }
}
