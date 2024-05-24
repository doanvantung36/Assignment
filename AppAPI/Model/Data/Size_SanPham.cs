using System.ComponentModel.DataAnnotations.Schema;

namespace AppAPI.Model.Data
{
    public class Size_SanPham
    {
        [ForeignKey("MaSize")]
        public Guid MaSize { get; set; }
        [ForeignKey("MaSanPham")]
        public Guid MaSanPham { get; set; }


        public Size Size { get; set; }
        public SanPham SanPham { get; set; }

    }
}
