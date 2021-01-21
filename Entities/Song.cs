using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Entities
{
    public class Song : BaseEntity
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual Album Album { get; set; }
        public virtual List<SongArtist> SongArtists { get; set; }
        public int ProducerId { get; set; }
    }
}
