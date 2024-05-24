using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace AppAPI.Model.Data
{
    public class SanPham
    {
        [Key]
        public Guid MaSanPham {  get; set; }
        public string? TenSanPham {  set; get; }
        public int GiaMua { get; set; }
        [ForeignKey("MaLoaiSanPham")]
        public string? MaLoaiSanPham { get; set;}
        public string? ChuDe {  get; set; }
        public string? ThongTin {  get; set; }
        public string? GioiTinh { get; set; }
        public DateTime? NgayNhapHang { get; set;}
        public string? HinhHanh { get; set; }
        [ForeignKey("MaMau")]
        public string? MaMau {  get; set; }

        public LoaiSanPham? LoaiSanPham { get; set; }
        public MauSac? MauSac { get; set; }

        public ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }

        public ICollection<Size_SanPham> size_SanPhams { get; set; }
    }
}
