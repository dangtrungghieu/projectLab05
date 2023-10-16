using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLThuVien.Models
{
    public partial class QLThuVienDBContext : DbContext
    {
        public QLThuVienDBContext()
            : base("name=QLThuVienDBContext")
        {
        }

        public virtual DbSet<BINHLUAN> BINHLUAN { get; set; }
        public virtual DbSet<CHINHANH> CHINHANH { get; set; }
        public virtual DbSet<CHUYENNGANH> CHUYENNGANH { get; set; }
        public virtual DbSet<DAUSACH> DAUSACH { get; set; }
        public virtual DbSet<DOCGIA> DOCGIA { get; set; }
        public virtual DbSet<LOAIDOCGIA> LOAIDOCGIA { get; set; }
        public virtual DbSet<LOAINHANVIEN> LOAINHANVIEN { get; set; }
        public virtual DbSet<MUONSACH> MUONSACH { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<SACH> SACH { get; set; }
        public virtual DbSet<YEUCAU> YEUCAU { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BINHLUAN>()
                .Property(e => e.MaDG)
                .IsFixedLength();

            modelBuilder.Entity<CHINHANH>()
                .HasMany(e => e.SACH)
                .WithRequired(e => e.CHINHANH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAUSACH>()
                .HasMany(e => e.BINHLUAN)
                .WithRequired(e => e.DAUSACH)
                .HasForeignKey(e => e.MaSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAUSACH>()
                .HasMany(e => e.SACH)
                .WithRequired(e => e.DAUSACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOCGIA>()
                .Property(e => e.MaDG)
                .IsFixedLength();

            modelBuilder.Entity<DOCGIA>()
                .HasMany(e => e.BINHLUAN)
                .WithRequired(e => e.DOCGIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOCGIA>()
                .HasMany(e => e.MUONSACH)
                .WithRequired(e => e.DOCGIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MUONSACH>()
                .Property(e => e.MaDG)
                .IsFixedLength();

            modelBuilder.Entity<MUONSACH>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<SACH>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.MUONSACH)
                .WithRequired(e => e.SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YEUCAU>()
                .Property(e => e.MaDG)
                .IsFixedLength();
        }
    }
}
