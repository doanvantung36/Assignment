using System.ComponentModel.DataAnnotations;

namespace AppAPI.Model.Data
{
    public class LoaiSanPham
    {
        [Key]
        public Guid MaLoaiSanPham { get; set; }
        public string? TenLoaiSanPham {  set; get; }

        public ICollection<SanPham> SanPham { get; set;}
    }
}
