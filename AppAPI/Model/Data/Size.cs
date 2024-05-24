using System.ComponentModel.DataAnnotations;

namespace AppAPI.Model.Data
{
    public class Size
    {
        [Key]
        public Guid MaSize { get; set; }
        public string? Sizes { get; set; }

        public ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }

        public ICollection<Size_SanPham> size_SanPhams { get; set; }

    }
}
