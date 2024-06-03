using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppAPI.Model.Data
{
    public class HoaDonChiTiet
    {
        public Guid MaHoaDon {  get; set; }
        
        public Guid MaSanPham {  get; set; }
        
        public Guid MaSize { get; set; }

        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public HoaDon HoaDon { get; set; }
        public SanPham SanPham { get; set; }
        public Size Size { get; set; }
    }
}
