using Microsoft.EntityFrameworkCore;
using s21284_KOL2_APBD.Entities.Models;

namespace s21284_KOL2_APBD.Entities
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Album> Album { get; set; }
        public DbSet<Musician> Musician { get; set; }
        public DbSet<MusicianTrack> MusicianTrack { get; set; }
        public DbSet<MusicLabel> MusicLabel { get; set; }
        public DbSet<Track> Track { get; set; }
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(e =>
            {
                e.ToTable("Album");
               
                e.HasKey(e => e.IdAlbum);

                e.Property(e => e.AlbumName).HasMaxLength(30).IsRequired();
                e.Property(e => e.PublishDate);
                e.Property(e => e.IdMusicLabel);

                e.HasData(
                    new Album
                    {
                        IdAlbum = 1,
                        AlbumName = "NNN",
                        PublishDate = DateTime.Now,
                    }
                );
            });

            modelBuilder.Entity<Musician>(e =>
            {
                e.ToTable("Musician");
                e.HasKey(e => e.IdMusician);

                e.Property(e => e.FirstName).HasMaxLength(30).IsRequired();
                e.Property(e => e.LastName).HasMaxLength(50).IsRequired();
                e.Property(e => e.NickName).HasMaxLength(20);

                e.HasData(
                    new Musician
                    {
                        IdMusician = 1,
                        FirstName = "Mateusz",
                        LastName = "Kowalski",
                        NickName =  "Jack"
                    }
                );
            });

        }
    }
}