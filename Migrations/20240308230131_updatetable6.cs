using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myDotNetMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class updatetable6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BusinessProfile_contact",
                table: "BusinessProfiles",
                newName: "BusinessProfile_phone");

            migrationBuilder.AddColumn<string>(
                name: "BusinessProfile_owner",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusinessProfile_owner",
                table: "BusinessProfiles");

            migrationBuilder.RenameColumn(
                name: "BusinessProfile_phone",
                table: "BusinessProfiles",
                newName: "BusinessProfile_contact");
        }
    }
}
