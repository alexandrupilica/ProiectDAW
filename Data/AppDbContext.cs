using Microsoft.EntityFrameworkCore;
using ProiectDAW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.Data
{
    public class AppDbContext : DbContext
    {
        //one-to-one
        public DbSet<Producer> Producers { get; set; }

        //many-to-many
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; } //also one-to-many
        public DbSet<SongArtist> SongArtists { get; set; }
        public DbSet<AlbumArtist> AlbumArtists { get; set; }
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //one-to-one
            builder.Entity<Producer>()
                .HasOne(x => x.Song)
                .WithOne(y => y.Producer)
                .HasForeignKey<Song>
                (z => z.ProducerId);

            //one-to-many
            builder.Entity<Album>()
                .HasMany(x => x.Songs)
                .WithOne(y => y.Album);

            //many-to-many
            builder.Entity<SongArtist>()
              .HasKey(mg => new { mg.SongId, mg.ArtistId });

            builder.Entity<SongArtist>()
                .HasOne<Song>(x => x.Song)
                .WithMany(y => y.SongArtists)
                .HasForeignKey(z => z.SongId);

            builder.Entity<SongArtist>()
                .HasOne<Artist>(x => x.Artist)
                .WithMany(y => y.SongArtists)
                .HasForeignKey(z => z.ArtistId);
            
            builder.Entity<AlbumArtist>()
             .HasKey(mg => new { mg.AlbumId, mg.ArtistId });

            builder.Entity<AlbumArtist>()
                .HasOne<Album>(x => x.Album)
                .WithMany(y => y.AlbumArtists)
                .HasForeignKey(z => z.AlbumId);

            builder.Entity<AlbumArtist>()
                .HasOne<Artist>(x => x.Artist)
                .WithMany(y => y.AlbumArtists)
                .HasForeignKey(z => z.ArtistId);

            base.OnModelCreating(builder);








        }
    }
}