using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.Models
{
    public partial class DiscShopDBContext : DbContext
    {
        public DiscShopDBContext()
        {
        }

        public DiscShopDBContext(DbContextOptions<DiscShopDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerTbl> CustomerTbls { get; set; }
        public virtual DbSet<DetailsShoppingTbl> DetailsShoppingTbls { get; set; }
        public virtual DbSet<DiscTbl> DiscTbls { get; set; }
        public virtual DbSet<ShoppingTbl> ShoppingTbls { get; set; }
        public virtual DbSet<SingerTbl> SingerTbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-L37SNTD8;Database=DiscShopDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<CustomerTbl>(entity =>
            {
                entity.HasKey(e => e.IdCust);

                entity.ToTable("CustomerTBL");

                entity.Property(e => e.NameCust)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumOfVisaCust)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PassCust)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetailsShoppingTbl>(entity =>
            {
                entity.HasKey(e => e.IdDetails);

                entity.ToTable("DetailsShoppingTBL");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.HasOne(d => d.IdDiscNavigation)
                    .WithMany(p => p.DetailsShoppingTbls)
                    .HasForeignKey(d => d.IdDisc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetailsShoppingTBL_DiscTBL");

                entity.HasOne(d => d.IdShoppingNavigation)
                    .WithMany(p => p.DetailsShoppingTbls)
                    .HasForeignKey(d => d.IdShopping)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DetailsShoppingTBL_ShoppingTBL");
            });

            modelBuilder.Entity<DiscTbl>(entity =>
            {
                entity.HasKey(e => e.IdDisc);

                entity.ToTable("DiscTBL");

                entity.Property(e => e.ImgDisc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameDisc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PricePerUnit).HasColumnType("money");

                entity.HasOne(d => d.IdSingerNavigation)
                    .WithMany(p => p.DiscTbls)
                    .HasForeignKey(d => d.IdSinger)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscTBL_SingerTBL");
            });

            modelBuilder.Entity<ShoppingTbl>(entity =>
            {
                entity.HasKey(e => e.IdShopping);

                entity.ToTable("ShoppingTBL");

                entity.Property(e => e.DateShopping).HasColumnType("date");

                entity.Property(e => e.SumShoping).HasColumnType("money");

                entity.HasOne(d => d.IdCustNavigation)
                    .WithMany(p => p.ShoppingTbls)
                    .HasForeignKey(d => d.IdCust)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingTBL_CustomerTBL");
            });

            modelBuilder.Entity<SingerTbl>(entity =>
            {
                entity.HasKey(e => e.IdSinger);

                entity.ToTable("SingerTBL");

                entity.Property(e => e.NameSinger)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
