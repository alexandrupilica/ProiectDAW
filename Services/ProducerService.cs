using ProiectDAW.Entities;
using ProiectDAW.IRepositories;
using ProiectDAW.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Services
{
    public class ProducerService : IProducerService
    {
        private readonly IProducerRepository _repository;
        public ProducerService(IProducerRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var producer = _repository.FindById(id);
            _repository.Delete(producer);
            return _repository.SaveChanges();
        }

        public List<Producer> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Producer GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(Producer producer)
        {
            _repository.Create(producer);
            return _repository.SaveChanges();
        }

        public bool Update(Producer producer)
        {
            _repository.Update(producer);
            return _repository.SaveChanges();
        }
    }
}
