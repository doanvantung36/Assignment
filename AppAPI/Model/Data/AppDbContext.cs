using Microsoft.EntityFrameworkCore;

namespace AppAPI.Model.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        #region DBSet
        public DbSet<BinhLuan> BinhLuan { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<MauSac> MauSac { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<Size> Size { get; set; }
        public DbSet<Size_SanPham> Size_SanPham { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BinhLuan>(e =>
            {
                e.ToTable("BinhLuan");
                e.Property(bl => bl.NgayBinhLuan)
                .HasDefaultValueSql("getutcdate()");
            });


            modelBuilder.Entity<HoaDonChiTiet>(e =>
            {
                e.ToTable("HoaDonChiTiet");
                e.HasKey(e => new { e.MaHoaDon, e.MaSanPham, e.MaSize });
                e.HasOne(e => e.HoaDon)
                 .WithMany(e => e.HoaDonChiTiets)
                 .HasForeignKey(e => e.MaHoaDon)
                 .HasConstraintName("FK_HoaDon_HoaDonChiTiet");
                e.HasOne(e => e.SanPham)
                 .WithMany(e => e.HoaDonChiTiets)
                 .HasForeignKey(e => e.MaSanPham)
                 .HasConstraintName("FK_SanPham_HoaDonChiTiet");
                e.HasOne(e => e.Size)
                 .WithMany(e => e.HoaDonChiTiets)
                 .HasForeignKey(e => e.MaSize)
                 .HasConstraintName("FK_Size_HoaDonChiTiet");
            });

            modelBuilder.Entity<Size_SanPham>(ss =>
            {
                ss.ToTable("Size_SanPham");
                ss.HasKey(ss => new {ss.MaSanPham, ss.MaSize});
                ss.HasOne(ss => ss.SanPham)
                .WithMany(ss => ss.size_SanPhams)
                .HasForeignKey(ss => ss.MaSanPham)
                .HasConstraintName("FK_SanPham_Size_SanPham");
                ss.HasOne(ss => ss.Size)
                .WithMany(ss => ss.size_SanPhams)
                .HasForeignKey(ss => ss.MaSize)
                .HasConstraintName("FK_Size_Size_SanPham");
            });
        }
    }
}
