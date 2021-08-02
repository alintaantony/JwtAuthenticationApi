using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace JwtAuthenticationApi.Models
{
    public partial class SpotifyDemoDbContext : DbContext
    {
        public SpotifyDemoDbContext()
        {
        }

        public SpotifyDemoDbContext(DbContextOptions<SpotifyDemoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LikedSongs> LikedSongs { get; set; }
        public virtual DbSet<PlaylistDetails> PlaylistDetails { get; set; }
        public virtual DbSet<SongDetails> SongDetails { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }
        public virtual DbSet<UserLibrary> UserLibrary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=SpotifyDemoDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LikedSongs>(entity =>
            {
                entity.HasKey(e => e.Likedsongid)
                    .HasName("PK__LikedSon__76E2B53760F5B2D1");

                entity.Property(e => e.Likedsongid).HasColumnName("likedsongid");

                entity.Property(e => e.Addeddate)
                    .HasColumnName("addeddate")
                    .HasColumnType("date");

                entity.Property(e => e.Songid).HasColumnName("songid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Userlikedsongplaycounter).HasColumnName("userlikedsongplaycounter");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.LikedSongs)
                    .HasForeignKey(d => d.Songid)
                    .HasConstraintName("FK__LikedSong__songi__412EB0B6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LikedSongs)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__LikedSong__useri__403A8C7D");
            });

            modelBuilder.Entity<PlaylistDetails>(entity =>
            {
                entity.HasKey(e => e.Playlistid)
                    .HasName("PK__Playlist__D52B2DFEC17F77B4");

                entity.Property(e => e.Playlistid).HasColumnName("playlistid");

                entity.Property(e => e.Addeddate)
                    .HasColumnName("addeddate")
                    .HasColumnType("date");

                entity.Property(e => e.Playlistname).HasColumnName("playlistname");

                entity.Property(e => e.Songid).HasColumnName("songid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Usersongplaycounter).HasColumnName("usersongplaycounter");

                entity.HasOne(d => d.Song)
                    .WithMany(p => p.PlaylistDetails)
                    .HasForeignKey(d => d.Songid)
                    .HasConstraintName("FK__PlaylistD__songi__3D5E1FD2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PlaylistDetails)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__PlaylistD__useri__3C69FB99");
            });

            modelBuilder.Entity<SongDetails>(entity =>
            {
                entity.HasKey(e => e.Songid)
                    .HasName("PK__SongDeta__0328DB050A877AEF");

                entity.Property(e => e.Songid).HasColumnName("songid");

                entity.Property(e => e.Albumname).HasColumnName("albumname");

                entity.Property(e => e.Artistname)
                    .HasColumnName("artistname")
                    .HasMaxLength(50);

                entity.Property(e => e.Genre)
                    .HasColumnName("genre")
                    .HasMaxLength(50);

                entity.Property(e => e.Lyrics).HasColumnName("lyrics");

                entity.Property(e => e.Songdescription).HasColumnName("songdescription");

                entity.Property(e => e.Songname).HasColumnName("songname");

                entity.Property(e => e.Songpath).HasColumnName("songpath");

                entity.Property(e => e.Songplaycounter).HasColumnName("songplaycounter");
            });

            modelBuilder.Entity<UserDetails>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__UserDeta__CBA1B25785174ABE");

                entity.HasIndex(e => e.Phonenumber)
                    .HasName("UQ__UserDeta__622BF0C246904902")
                    .IsUnique();

                entity.HasIndex(e => e.Useremail)
                    .HasName("UQ__UserDeta__870EAE61028592C2")
                    .IsUnique();

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Phonenumber)
                    .HasColumnName("phonenumber")
                    .HasMaxLength(10);

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(20);

                entity.Property(e => e.Useremail)
                    .HasColumnName("useremail")
                    .HasMaxLength(100);

                entity.Property(e => e.Username).HasColumnName("username");
            });

            modelBuilder.Entity<UserLibrary>(entity =>
            {
                entity.Property(e => e.Userlibraryid).HasColumnName("userlibraryid");

                entity.Property(e => e.Playlistid).HasColumnName("playlistid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Playlist)
                    .WithMany(p => p.UserLibrary)
                    .HasForeignKey(d => d.Playlistid)
                    .HasConstraintName("FK__UserLibra__playl__44FF419A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLibrary)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__UserLibra__useri__440B1D61");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
