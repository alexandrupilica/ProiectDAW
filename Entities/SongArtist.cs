using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Entities
{
    public class SongArtist : BaseEntity
    {
        public int SongId { get; set; }
        public int ArtistId { get; set; }

        public virtual Song Song { get; set; }
        public virtual Artist Artist { get; set; }

        public virtual List<SongArtist> SongArtists { get; set; }
    }
}
