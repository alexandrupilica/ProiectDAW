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
    public class SongArtistRepository : GenericRepository<SongArtist>, ISongArtistRepository
    {
        public SongArtistRepository(AppDbContext _context) : base(_context)
        {

        }
        public SongArtist GetByIdJoined(int id)
        {
            var songArtist = _context.SongArtists.Where(x => x.Id == id)
                .Include(x => x.Song)
                .Include(x => x.Artist)
                .FirstOrDefault();

            return songArtist;
        }
    }
}
