using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProiectDAW.Entities;

namespace ProiectDAW.IServices
{
    public interface IProducerService
    {
        List<Producer> GetAll();
        Producer GetById(int id);
        bool Insert(Producer producer);
        bool Update(Producer producer);
        bool Delete(int id);
    }
}
