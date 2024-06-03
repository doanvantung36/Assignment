using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppAPI.Model.Data
{
    public class HoaDon
    {
        [Key]
        public Guid MaHoaDon { get; set; }
        public DateTime NgayLapHoaDon { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        
        public Guid MaKhachHang { get; set; }
        public string? DiaChiGiaoHang { get; set; }
        public byte TrangThai {  get; set; }


        public KhachHang KhachHang { get; set; }
        public ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
