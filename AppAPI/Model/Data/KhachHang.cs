using System.ComponentModel.DataAnnotations;

namespace AppAPI.Model.Data
{
    public enum TrangThai 
    {
        None = 0, Admin = 1, Employee = 2
    }
    public class KhachHang
    {
        [Key]
        public Guid MaKhachHang {  get; set; }
        public string? TenDangNhap { get; set; }
        public string? MatKhau {  get; set; }
        public string? HoTen {  get; set; }
        public string? GioiTinh { get; set; }
        public string? DiaChi { get; set; }
        public string? Email { get; set; }
        public string? SoDienThoai { get; set; }
        
        public TrangThai TrangThai { get; set; }

        public ICollection<BinhLuan> BinhLuan { get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }
    }
}
