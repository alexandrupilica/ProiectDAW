using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectDAW.Entities;

namespace ProiectDAW.IServices
{
    public interface IAlbumService
    {
        List<Album> GetAll();
        Album GetById(int id);
        bool Insert(Album album);
        bool Update(Album album);
        bool Delete(int id);
    }
}
