using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectDAW.Entities;


namespace ProiectDAW.IServices
{
    public interface IAlbumArtistService
    {
        List<AlbumArtist> GetAll();
        AlbumArtist GetById(int id);
        bool Insert(AlbumArtist albumArtist);
        bool Update(AlbumArtist albumArtist);
        bool Delete(int id);
    }
}
