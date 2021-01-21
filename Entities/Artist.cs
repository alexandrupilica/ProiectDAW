using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Entities
{
    public class Artist : BaseEntity
    {
        public string name { get; set; }
        public string nationality { get; set; }
        
        public virtual List<SongArtist> SongArtists { get; set; }
        public virtual List<AlbumArtist> AlbumArtists { get; set; }
    }
}
