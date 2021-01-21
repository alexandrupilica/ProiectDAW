using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectDAW.Data;
using ProiectDAW.Entities;
using ProiectDAW.IRepositories;

namespace ProiectDAW.Repositories
{
    public class SongRepository : GenericRepository<Song>, ISongRepository
    {
        public SongRepository(AppDbContext _context) : base(_context)
        {

        }

        public Song GetByIdJoined(int id)
        {
            var song = _context.Songs.Where(x => x.Id == id)
                .Include(x => x.SongArtists).FirstOrDefault();

            return song;
        }
    }
}
