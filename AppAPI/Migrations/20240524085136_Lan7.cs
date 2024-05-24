using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppAPI.Migrations
{
    /// <inheritdoc />
    public partial class Lan7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    MaLoaiSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLoaiSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.MaLoaiSanPham);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    MaMau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMau = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.MaMau);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    MaSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sizes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.MaSize);
                });

            migrationBuilder.CreateTable(
                name: "BinhLuan",
                columns: table => new
                {
                    MaBinhLuan = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TieuDe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBinhLuan = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getutcdate()"),
                    MaKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhachHangMaKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinhLuan", x => x.MaBinhLuan);
                    table.ForeignKey(
                        name: "FK_BinhLuan_KhachHang_KhachHangMaKhachHang",
                        column: x => x.KhachHangMaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayLapHoaDon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayGiaoHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChiGiaoHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<byte>(type: "tinyint", nullable: false),
                    KhachHangMaKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_KhachHangMaKhachHang",
                        column: x => x.KhachHangMaKhachHang,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang");
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaMua = table.Column<int>(type: "int", nullable: false),
                    MaLoaiSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChuDe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThongTin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayNhapHang = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HinhHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaMau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiSanPhamMaLoaiSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MauSacMaMau = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_LoaiSanPhamMaLoaiSanPham",
                        column: x => x.LoaiSanPhamMaLoaiSanPham,
                        principalTable: "LoaiSanPham",
                        principalColumn: "MaLoaiSanPham");
                    table.ForeignKey(
                        name: "FK_SanPham_MauSac_MauSacMaMau",
                        column: x => x.MauSacMaMau,
                        principalTable: "MauSac",
                        principalColumn: "MaMau");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    MaHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoaiSanPhamMaLoaiSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MauSacMaMau = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => new { x.MaHoaDon, x.MaSanPham, x.MaSize });
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_LoaiSanPham_LoaiSanPhamMaLoaiSanPham",
                        column: x => x.LoaiSanPhamMaLoaiSanPham,
                        principalTable: "LoaiSanPham",
                        principalColumn: "MaLoaiSanPham");
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_MauSac_MauSacMaMau",
                        column: x => x.MauSacMaMau,
                        principalTable: "MauSac",
                        principalColumn: "MaMau");
                    table.ForeignKey(
                        name: "FK_HoaDon_HoaDonChiTiet",
                        column: x => x.MaHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_HoaDonChiTiet",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Size_HoaDonChiTiet",
                        column: x => x.MaSize,
                        principalTable: "Size",
                        principalColumn: "MaSize",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Size_SanPham",
                columns: table => new
                {
                    MaSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSanPham = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size_SanPham", x => new { x.MaSanPham, x.MaSize });
                    table.ForeignKey(
                        name: "FK_SanPham_Size_SanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Size_Size_SanPham",
                        column: x => x.MaSize,
                        principalTable: "Size",
                        principalColumn: "MaSize",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BinhLuan_KhachHangMaKhachHang",
                table: "BinhLuan",
                column: "KhachHangMaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangMaKhachHang",
                table: "HoaDon",
                column: "KhachHangMaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_LoaiSanPhamMaLoaiSanPham",
                table: "HoaDonChiTiet",
                column: "LoaiSanPhamMaLoaiSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaSanPham",
                table: "HoaDonChiTiet",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MaSize",
                table: "HoaDonChiTiet",
                column: "MaSize");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_MauSacMaMau",
                table: "HoaDonChiTiet",
                column: "MauSacMaMau");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_LoaiSanPhamMaLoaiSanPham",
                table: "SanPham",
                column: "LoaiSanPhamMaLoaiSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MauSacMaMau",
                table: "SanPham",
                column: "MauSacMaMau");

            migrationBuilder.CreateIndex(
                name: "IX_Size_SanPham_MaSize",
                table: "Size_SanPham",
                column: "MaSize");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BinhLuan");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "Size_SanPham");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropTable(
                name: "MauSac");
        }
    }
}
