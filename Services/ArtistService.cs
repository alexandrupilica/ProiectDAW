using ProiectDAW.Entities;
using ProiectDAW.IRepositories;
using ProiectDAW.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Services
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _repository;
        public ArtistService(IArtistRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var artist = _repository.FindById(id);
            _repository.Delete(artist);
            return _repository.SaveChanges();
        }

        public List<Artist> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Artist GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(Artist artist)
        {
            _repository.Create(artist);
            return _repository.SaveChanges();
        }

        public bool Update(Artist artist)
        {
            _repository.Update(artist);
            return _repository.SaveChanges();
        }
    }
}
