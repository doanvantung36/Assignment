using Microsoft.EntityFrameworkCore;

namespace AppAPI.Model.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-7HORMRAF\\SQLEXPRESS01;Initial Catalog=AppDbContext;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True");
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        
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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HoaDonChiTiet>()
                .HasKey(h => new { h.MaHoaDon, h.MaSanPham, h.MaSize });

            modelBuilder.Entity<HoaDonChiTiet>()
                .HasOne(h => h.HoaDon)
                .WithMany(hd => hd.HoaDonChiTiets)
                .HasForeignKey(h => h.MaHoaDon);

            modelBuilder.Entity<HoaDonChiTiet>()
                .HasOne(h => h.SanPham)
                .WithMany(sp => sp.HoaDonChiTiets)
                .HasForeignKey(h => h.MaSanPham);

            modelBuilder.Entity<HoaDonChiTiet>()
                .HasOne(h => h.Size)
                .WithMany(s => s.HoaDonChiTiets)
                .HasForeignKey(h => h.MaSize);

            modelBuilder.Entity<Size_SanPham>()
           .HasKey(sp => new { sp.MaSize, sp.MaSanPham });

            modelBuilder.Entity<Size_SanPham>()
                .HasOne(sp => sp.Size)
                .WithMany(s => s.size_SanPhams)
                .HasForeignKey(sp => sp.MaSize);

            modelBuilder.Entity<Size_SanPham>()
                .HasOne(sp => sp.SanPham)
                .WithMany(p => p.size_SanPhams)
                .HasForeignKey(sp => sp.MaSanPham);

            modelBuilder.Entity<BinhLuan>()
               .HasOne(sp => sp.KhachHang)
               .WithMany(p => p.BinhLuan)
               .HasForeignKey(sp => sp.MaKhachHang);

            modelBuilder.Entity<BinhLuan>()
              .HasOne(sp => sp.SanPham)
              .WithMany(p => p.binhLuans)
              .HasForeignKey(sp => sp.MaSanPham);

            modelBuilder.Entity<HoaDon>()
               .HasOne(sp => sp.KhachHang)
               .WithMany(p => p.HoaDon)
               .HasForeignKey(sp => sp.MaKhachHang);

            modelBuilder.Entity<SanPham>()
              .HasOne(sp => sp.LoaiSanPham)
              .WithMany(p => p.SanPham)
              .HasForeignKey(sp => sp.MaLoaiSanPham);

            modelBuilder.Entity<SanPham>()
             .HasOne(sp => sp.MauSac)
             .WithMany(p => p.SanPham)
             .HasForeignKey(sp => sp.MaMau);
        }
    }
}
