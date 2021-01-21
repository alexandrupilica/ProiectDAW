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
        public class AlbumRepository : GenericRepository<Album>, IAlbumRepository
        {
            public AlbumRepository(AppDbContext _context) : base(_context)
            {

            }
            public Album GetByIdJoined(int id)
            {
                var album = _context.Albums.Where(x => x.Id == id)
                    .Include(x => x.AlbumArtists)
                    .FirstOrDefault();

                return album;
            }
        }
}
