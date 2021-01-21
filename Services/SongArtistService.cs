using ProiectDAW.Entities;
using ProiectDAW.IRepositories;
using ProiectDAW.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Services
{
    public class SongArtistService : ISongArtistService
    {
        private readonly ISongArtistRepository _repository;
        public SongArtistService(ISongArtistRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var songArtist = _repository.FindById(id);
            _repository.Delete(songArtist);
            return _repository.SaveChanges();
        }

        public List<SongArtist> GetAll()
        {
            return _repository.GetAllActive();
        }

        public SongArtist GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(SongArtist songArtist)
        {
            _repository.Create(songArtist);
            return _repository.SaveChanges();
        }

        public bool Update(SongArtist songArtist)
        {
            _repository.Update(songArtist);
            return _repository.SaveChanges();
        }
    }
}
