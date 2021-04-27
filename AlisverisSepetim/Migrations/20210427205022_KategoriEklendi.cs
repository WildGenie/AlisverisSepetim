using Microsoft.EntityFrameworkCore.Migrations;

namespace AlisverisSepetim.Migrations
{
    public partial class KategoriEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Urun_KategoriId",
                table: "Urun",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Kategori_KategoriId",
                table: "Urun",
                column: "KategoriId",
                principalTable: "Kategori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urun_Kategori_KategoriId",
                table: "Urun");

            migrationBuilder.DropIndex(
                name: "IX_Urun_KategoriId",
                table: "Urun");
        }
    }
}
