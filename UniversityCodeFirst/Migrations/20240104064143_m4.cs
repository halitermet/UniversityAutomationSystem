using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenci_diplomalar_DiplomaId",
                table: "Ogrenci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogrenci",
                table: "Ogrenci");

            migrationBuilder.RenameTable(
                name: "Ogrenci",
                newName: "ogrenci");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenci_DiplomaId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ogrenci_diplomalar_DiplomaId",
                table: "ogrenci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ogrenci",
                table: "ogrenci");

            migrationBuilder.RenameTable(
                name: "ogrenci",
                newName: "Ogrenci");

            migrationBuilder.RenameIndex(
                name: "IX_ogrenci_DiplomaId",
                table: "Ogrenci",
                newName: "IX_Ogrenci_DiplomaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogrenci",
                table: "Ogrenci",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenci_diplomalar_DiplomaId",
                table: "Ogrenci",
                column: "DiplomaId",
                principalTable: "diplomalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
