using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace AppAPI.Model.Data
{
    public class BinhLuan
    {
        [Key]
        public Guid MaBinhLuan { get; set; }
        public string? TieuDe {  get; set; }
        public string? NoiDung { get; set; }
        public DateTime? NgayBinhLuan { get; set; }

        public Guid MaKhachHang { get; set; }
        public Guid MaSanPham { get; set; }
        public SanPham SanPham { get; set; }
        public KhachHang KhachHang { get; set; }
    }
}
