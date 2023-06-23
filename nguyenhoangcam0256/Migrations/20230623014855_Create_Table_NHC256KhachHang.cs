using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nguyenhoangcam0256.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_NHC256KhachHang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NHC256KhachHang",
                columns: table => new
                {
                    NHC256KhachHangID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NHC256NameKhachHang = table.Column<string>(type: "TEXT", nullable: false),
                    NHC256Address = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHC256KhachHang", x => x.NHC256KhachHangID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NHC256KhachHang");
        }
    }
}
