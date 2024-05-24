using System.ComponentModel.DataAnnotations;

namespace AppAPI.Model.Data
{
    public class MauSac
    {
        [Key]
        public Guid MaMau {  get; set; }
        public string? TenMau { get; set; }

        public ICollection<SanPham> SanPham { get; set;}
    }
}
