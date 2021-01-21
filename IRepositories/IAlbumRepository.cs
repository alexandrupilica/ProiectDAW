using ProiectDAW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.IRepositories
{
    public interface IAlbumRepository : IGenericRepository<Album>
    {
        Album GetByIdJoined(int id);
    }
}
