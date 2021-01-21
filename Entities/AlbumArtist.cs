using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Entities
{
    public class AlbumArtist : BaseEntity
    {
        public int AlbumId { get; set; }
        public int ArtistId { get; set; }

        public virtual Album Album { get; set; }
        public virtual Artist Artist { get; set; }

        public virtual List<AlbumArtist> AlbumArtists { get; set; }
    }
}
