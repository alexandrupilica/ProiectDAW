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
    public class ArtistRepository : GenericRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(AppDbContext _context) : base(_context)
        {

        }

        public Artist GetByIdJoined(int id)
        {
            var artist = _context.Artists.Where(x => x.Id == id)
                .Include(x => x.SongArtists)
                .Include(x => x.AlbumArtists)
                .FirstOrDefault();

            return artist;
        }
    }
}
