using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Entities
{
    public class Album : BaseEntity
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public virtual List<Song> Songs { get; set; }
        public virtual List<AlbumArtist> AlbumArtists { get; set; }
    }
}
