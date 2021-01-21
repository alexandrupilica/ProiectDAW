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
    public class AlbumArtistRepository : GenericRepository<AlbumArtist>, IAlbumArtistRepository
    {
        public AlbumArtistRepository(AppDbContext _context) : base(_context)
        {

        }
        public AlbumArtist GetByIdJoined(int id)
        {
            var albumArtist = _context.AlbumArtists.Where(x => x.Id == id)
                .Include(x => x.Album)
                .Include(x => x.Artist)
                .FirstOrDefault();

            return albumArtist;
        }
    }
}
