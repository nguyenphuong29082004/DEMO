using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QLBanhangWebAPI.ModelFromDB
{
    public partial class CSDLBanHang : DbContext
    {
        public CSDLBanHang()
        {
        }

        public CSDLBanHang(DbContextOptions<CSDLBanHang> options)
            : base(options)
        {
        }

        public virtual DbSet<TblHanghoa> TblHanghoas { get; set; } = null!;

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Data Source= LAPTOP-AR0R8VU7\\ANHPHUONG;Initial Catalog= CSDL_BANHANG;Persist Security Info=True; User ID=sa; Password=29082004;Encrypt=false");
        //            }
        //        }

        //        protected override void OnModelCreating(ModelBuilder modelBuilder)
        //        {
        //            modelBuilder.Entity<TblHanghoa>(entity =>
        //            {
        //                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

        //                entity.Property(e => e.Ngaytao).HasDefaultValueSql("(getdate())");
        //            });

        //            OnModelCreatingPartial(modelBuilder);
        //        }

        //        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
