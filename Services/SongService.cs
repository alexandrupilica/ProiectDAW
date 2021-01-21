using ProiectDAW.Entities;
using ProiectDAW.IRepositories;
using ProiectDAW.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Services
{
    public class SongService : ISongService
    {
        private readonly ISongRepository _repository;
        public SongService(ISongRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var song = _repository.FindById(id);
            _repository.Delete(song);
            return _repository.SaveChanges();
        }

        public List<Song> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Song GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(Song song)
        {
            _repository.Create(song);
            return _repository.SaveChanges();
        }

        public bool Update(Song song)
        {
            _repository.Update(song);
            return _repository.SaveChanges();
        }
    }
}
