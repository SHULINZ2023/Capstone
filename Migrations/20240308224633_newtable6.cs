using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myDotNetMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class newtable6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessProfiles",
                columns: table => new
                {
                    BusinessProfileid = table.Column<long>(name: "BusinessProfile_id", type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BusinessProfilename = table.Column<string>(name: "BusinessProfile_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BusinessProfilecontact = table.Column<string>(name: "BusinessProfile_contact", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BusinessProfiledesc = table.Column<string>(name: "BusinessProfile_desc", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BusinessProfilephotourl = table.Column<string>(name: "BusinessProfile_photo_url", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind1foto1uri = table.Column<string>(name: "Kind1_foto1_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind1foto2uri = table.Column<string>(name: "Kind1_foto2_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind1foto3uri = table.Column<string>(name: "Kind1_foto3_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind1foto4uri = table.Column<string>(name: "Kind1_foto4_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind1foto5uri = table.Column<string>(name: "Kind1_foto5_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind2foto1uri = table.Column<string>(name: "Kind2_foto1_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind2foto2uri = table.Column<string>(name: "Kind2_foto2_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind2foto3uri = table.Column<string>(name: "Kind2_foto3_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind2foto4uri = table.Column<string>(name: "Kind2_foto4_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind2foto5uri = table.Column<string>(name: "Kind2_foto5_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind3foto1uri = table.Column<string>(name: "Kind3_foto1_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind3foto2uri = table.Column<string>(name: "Kind3_foto2_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind3foto3uri = table.Column<string>(name: "Kind3_foto3_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind3foto4uri = table.Column<string>(name: "Kind3_foto4_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Kind3foto5uri = table.Column<string>(name: "Kind3_foto5_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BusinessProfilevideolink = table.Column<string>(name: "BusinessProfile_video_link", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    businessstartyear = table.Column<int>(name: "business_start_year", type: "int", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Createtime = table.Column<DateTime>(name: "Create_time", type: "datetime(6)", nullable: false),
                    Lastupttime = table.Column<DateTime>(name: "Last_upt_time", type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessProfiles", x => x.BusinessProfileid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessProfiles");
        }
    }
}
