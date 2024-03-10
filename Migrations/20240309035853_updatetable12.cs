using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myDotNetMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class updatetable12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Section_html",
                table: "Sections",
                newName: "Section_Long_HTML");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Section_Long_HTML",
                table: "Sections",
                newName: "Section_html");
        }
    }
}
