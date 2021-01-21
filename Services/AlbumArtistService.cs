using ProiectDAW.Entities;
using ProiectDAW.IRepositories;
using ProiectDAW.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Services
{
    public class AlbumArtistService : IAlbumArtistService
    {
        private readonly IAlbumArtistRepository _repository;
        public AlbumArtistService(IAlbumArtistRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var albumArtist = _repository.FindById(id);
            _repository.Delete(albumArtist);
            return _repository.SaveChanges();
        }

        public List<AlbumArtist> GetAll()
        {
            return _repository.GetAllActive();
        }

        public AlbumArtist GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(AlbumArtist albumArtist)
        {
            _repository.Create(albumArtist);
            return _repository.SaveChanges();
        }

        public bool Update(AlbumArtist albumArtist)
        {
            _repository.Update(albumArtist);
            return _repository.SaveChanges();
        }
    }
}
