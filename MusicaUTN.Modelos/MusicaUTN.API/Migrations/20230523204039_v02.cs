using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicaUTN.API.Migrations
{
    /// <inheritdoc />
    public partial class v02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pistas_Autores_AutoresId",
                table: "Pistas");

            migrationBuilder.AlterColumn<int>(
                name: "AutoresId",
                table: "Pistas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Pistas_Autores_AutoresId",
                table: "Pistas",
                column: "AutoresId",
                principalTable: "Autores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pistas_Autores_AutoresId",
                table: "Pistas");

            migrationBuilder.AlterColumn<int>(
                name: "AutoresId",
                table: "Pistas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pistas_Autores_AutoresId",
                table: "Pistas",
                column: "AutoresId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
