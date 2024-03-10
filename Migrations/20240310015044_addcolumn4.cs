using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myDotNetMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class addcolumn4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Section_desc",
                table: "Sections",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Section_desc",
                table: "Sections");
        }
    }
}
