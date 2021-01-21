using ProiectDAW.Entities;
using ProiectDAW.IRepositories;
using ProiectDAW.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository _repository;
        public AlbumService(IAlbumRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var album = _repository.FindById(id);
            _repository.Delete(album);
            return _repository.SaveChanges();
        }

        public List<Album> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Album GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(Album album)
        {
            _repository.Create(album);
            return _repository.SaveChanges();
        }

        public bool Update(Album album)
        {
            _repository.Update(album);
            return _repository.SaveChanges();
        }
    }
}
