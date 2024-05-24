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
        [ForeignKey("MaKhachHang")]
        public string? MaKhachHang { get; set; }


        public KhachHang KhachHang { get; set; }
    }
}
