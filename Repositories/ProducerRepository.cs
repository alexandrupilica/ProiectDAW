using Microsoft.EntityFrameworkCore;
using ProiectDAW.Data;
using ProiectDAW.Entities;
using ProiectDAW.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Repositories
{
    public class ProducerRepository : GenericRepository<Producer>, IProducerRepository
    {
        public ProducerRepository(AppDbContext _context) : base(_context)
        {

        }
        public Producer GetByIdJoined(int id)
        {
            var producer = _context.Producers.Where(x => x.Id == id)
                .Include(x => x.Song)
                .FirstOrDefault();

            return producer;
        }
    }
}
