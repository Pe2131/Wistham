using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class WisthamApiContext : DbContext
    {
        public WisthamApiContext()
        {
        }

        public WisthamApiContext(DbContextOptions<WisthamApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Camera> Camera { get; set; }
        public virtual DbSet<CameraInfo> CameraInfo { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=WisthamApi;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Camera>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CameraName).HasMaxLength(500);
            });

            modelBuilder.Entity<CameraInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ImageDataArray).HasMaxLength(500);

                entity.Property(e => e.ImageDatatype).HasMaxLength(50);

                entity.Property(e => e.ImageDateTime).HasColumnType("datetime");

                entity.Property(e => e.ImageName).HasMaxLength(500);

                entity.Property(e => e.ImageUnicId)
                    .HasColumnName("imageUnicId")
                    .HasMaxLength(500);

                entity.Property(e => e.ImageUrl).HasMaxLength(500);

                entity.Property(e => e.MetaData).HasMaxLength(500);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(500);
            });
        }
    }
}
