using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myDotNetMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class updatetable5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kind1_foto1_uri",
                table: "BusinessProfiles");

            migrationBuilder.DropColumn(
                name: "Kind1_foto2_uri",
                table: "BusinessProfiles");

            migrationBuilder.DropColumn(
                name: "Kind1_foto3_uri",
                table: "BusinessProfiles");

            migrationBuilder.DropColumn(
                name: "Kind1_foto4_uri",
                table: "BusinessProfiles");

            migrationBuilder.DropColumn(
                name: "Kind1_foto5_uri",
                table: "BusinessProfiles");

            migrationBuilder.DropColumn(
                name: "Kind2_foto1_uri",
                table: "BusinessProfiles");

            migrationBuilder.DropColumn(
                name: "Kind2_foto2_uri",
                table: "BusinessProfiles");

            migrationBuilder.DropColumn(
                name: "Kind2_foto3_uri",
                table: "BusinessProfiles");

            migrationBuilder.DropColumn(
                name: "Kind2_foto4_uri",
                table: "BusinessProfiles");

            migrationBuilder.DropColumn(
                name: "Kind2_foto5_uri",
                table: "BusinessProfiles");

            migrationBuilder.DropColumn(
                name: "Kind3_foto1_uri",
                table: "BusinessProfiles");

            migrationBuilder.DropColumn(
                name: "Kind3_foto2_uri",
                table: "BusinessProfiles");

            migrationBuilder.DropColumn(
                name: "Kind3_foto3_uri",
                table: "BusinessProfiles");

            migrationBuilder.RenameColumn(
                name: "Kind3_foto5_uri",
                table: "BusinessProfiles",
                newName: "BusinessProfile_email");

            migrationBuilder.RenameColumn(
                name: "Kind3_foto4_uri",
                table: "BusinessProfiles",
                newName: "BusinessProfile_address");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BusinessProfile_email",
                table: "BusinessProfiles",
                newName: "Kind3_foto5_uri");

            migrationBuilder.RenameColumn(
                name: "BusinessProfile_address",
                table: "BusinessProfiles",
                newName: "Kind3_foto4_uri");

            migrationBuilder.AddColumn<string>(
                name: "Kind1_foto1_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Kind1_foto2_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Kind1_foto3_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Kind1_foto4_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Kind1_foto5_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Kind2_foto1_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Kind2_foto2_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Kind2_foto3_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Kind2_foto4_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Kind2_foto5_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Kind3_foto1_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Kind3_foto2_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Kind3_foto3_uri",
                table: "BusinessProfiles",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
