using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myDotNetMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class updatetable13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Section_Long_HTML",
                table: "Sections");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Section_Long_HTML",
                table: "Sections",
                type: "longtext",
                maxLength: 30000,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
