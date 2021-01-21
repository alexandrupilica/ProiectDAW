using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectDAW.Entities;

namespace ProiectDAW.IServices
{
    public interface IArtistService
    {
        List<Artist> GetAll();
        Artist GetById(int id);
        bool Insert(Artist artist);
        bool Update(Artist artist);
        bool Delete(int id);
    }
}
