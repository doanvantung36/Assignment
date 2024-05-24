using System.ComponentModel.DataAnnotations.Schema;

namespace AppAPI.Model.Data
{
    public class HoaDonChiTiet
    {
        [ForeignKey("MaHoaDon")]
        public Guid MaHoaDon {  get; set; }
        [ForeignKey("MaSanPham")]
        public Guid MaSanPham {  get; set; }
        [ForeignKey("MaSize")]
        public Guid MaSize { get; set; }

        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public HoaDon HoaDon { get; set; }
        public SanPham SanPham { get; set; }
        public Size Size { get; set; }
    }
}
