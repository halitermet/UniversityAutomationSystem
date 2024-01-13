using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class m5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ogrenci_diplomalar_DiplomaId",
                table: "ogrenci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ogrenci",
                table: "ogrenci");

            migrationBuilder.RenameTable(
                name: "ogrenci",
                newName: "ogrenciler");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "diplomalar",
                newName: "Tarih");

            migrationBuilder.RenameColumn(
                name: "Soyadı",
                table: "ogrenciler",
                newName: "Soyadi");

            migrationBuilder.RenameColumn(
                name: "Adı",
                table: "ogrenciler",
                newName: "Adi");

            migrationBuilder.RenameIndex(
                name: "IX_ogrenci_DiplomaId",
                table: "ogrenciler",
                newName: "IX_ogrenciler_DiplomaId");

            migrationBuilder.AddColumn<int>(
                name: "DanismanId",
                table: "ogrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ogrenciler",
                table: "ogrenciler",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "danısmanlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danısmanlar", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ogrenciler_DanismanId",
                table: "ogrenciler",
                column: "DanismanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ogrenciler_danısmanlar_DanismanId",
                table: "ogrenciler",
                column: "DanismanId",
                principalTable: "danısmanlar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ogrenciler_diplomalar_DiplomaId",
                table: "ogrenciler",
                column: "DiplomaId",
                principalTable: "diplomalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ogrenciler_danısmanlar_DanismanId",
                table: "ogrenciler");

            migrationBuilder.DropForeignKey(
                name: "FK_ogrenciler_diplomalar_DiplomaId",
                table: "ogrenciler");

            migrationBuilder.DropTable(
                name: "danısmanlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ogrenciler",
                table: "ogrenciler");

            migrationBuilder.DropIndex(
                name: "IX_ogrenciler_DanismanId",
                table: "ogrenciler");

            migrationBuilder.DropColumn(
                name: "DanismanId",
                table: "ogrenciler");

            migrationBuilder.RenameTable(
                name: "ogrenciler",
                newName: "ogrenci");

            migrationBuilder.RenameColumn(
                name: "Tarih",
                table: "diplomalar",
                newName: "DateTime");

            migrationBuilder.RenameColumn(
                name: "Soyadi",
                table: "ogrenci",
                newName: "Soyadı");

            migrationBuilder.RenameColumn(
                name: "Adi",
                table: "ogrenci",
                newName: "Adı");

            migrationBuilder.RenameIndex(
                name: "IX_ogrenciler_DiplomaId",
                table: "ogrenci",
                newName: "IX_ogrenci_DiplomaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ogrenci",
                table: "ogrenci",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ogrenci_diplomalar_DiplomaId",
                table: "ogrenci",
                column: "DiplomaId",
                principalTable: "diplomalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
