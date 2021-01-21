using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectDAW.Entities;

namespace ProiectDAW.IServices
{
    public interface ISongArtistService
    {
        List<SongArtist> GetAll();
        SongArtist GetById(int id);
        bool Insert(SongArtist songArtist);
        bool Update(SongArtist songArtist);
        bool Delete(int id);
    }
}
