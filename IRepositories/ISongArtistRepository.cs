using ProiectDAW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.IRepositories
{
    public interface ISongArtistRepository : IGenericRepository<SongArtist>
    {
        SongArtist GetByIdJoined(int id);
    }
}
