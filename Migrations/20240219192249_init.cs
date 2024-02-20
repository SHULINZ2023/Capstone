using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myDotNetMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FutureEvents",
                columns: table => new
                {
                    FutureEventid = table.Column<long>(name: "FutureEvent_id", type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FutureEventname = table.Column<string>(name: "FutureEvent_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FutureEventcontact = table.Column<string>(name: "FutureEvent_contact", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FutureEventdesc = table.Column<string>(name: "FutureEvent_desc", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FutureEventphotourl = table.Column<string>(name: "FutureEvent_photo_url", type: "longtext", nullable: true)
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
                    FutureEventvideolink = table.Column<string>(name: "FutureEvent_video_link", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServiceCostPolicy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Createtime = table.Column<DateTime>(name: "Create_time", type: "datetime(6)", nullable: false),
                    Lastupttime = table.Column<DateTime>(name: "Last_upt_time", type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FutureEvents", x => x.FutureEventid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MassageTherapies",
                columns: table => new
                {
                    MssgTherapyid = table.Column<long>(name: "MssgTherapy_id", type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MssgTherapyname = table.Column<string>(name: "MssgTherapy_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MssgTherapycontact = table.Column<string>(name: "MssgTherapy_contact", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MssgTherapydesc = table.Column<string>(name: "MssgTherapy_desc", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MssgTherapyphotourl = table.Column<string>(name: "MssgTherapy_photo_url", type: "longtext", nullable: true)
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
                    MssgTherapyvideolink = table.Column<string>(name: "MssgTherapy_video_link", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServiceCostPolicy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Createtime = table.Column<DateTime>(name: "Create_time", type: "datetime(6)", nullable: false),
                    Lastupttime = table.Column<DateTime>(name: "Last_upt_time", type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MassageTherapies", x => x.MssgTherapyid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OfferedServices",
                columns: table => new
                {
                    OfferedServiceid = table.Column<long>(name: "OfferedService_id", type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OfferedServicename = table.Column<string>(name: "OfferedService_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OfferedServicecontact = table.Column<string>(name: "OfferedService_contact", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OfferedServicedesc = table.Column<string>(name: "OfferedService_desc", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OfferedServicephotourl = table.Column<string>(name: "OfferedService_photo_url", type: "longtext", nullable: true)
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
                    OfferedServicevideolink = table.Column<string>(name: "OfferedService_video_link", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ServiceCostPolicy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Createtime = table.Column<DateTime>(name: "Create_time", type: "datetime(6)", nullable: false),
                    Lastupttime = table.Column<DateTime>(name: "Last_upt_time", type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferedServices", x => x.OfferedServiceid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PrivateChefs",
                columns: table => new
                {
                    PrivateChefid = table.Column<long>(name: "PrivateChef_id", type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PrivateChefname = table.Column<string>(name: "PrivateChef_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrivateChefcontact = table.Column<string>(name: "PrivateChef_contact", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrivateChefdesc = table.Column<string>(name: "PrivateChef_desc", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrivateChefphotourl = table.Column<string>(name: "PrivateChef_photo_url", type: "longtext", nullable: true)
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
                    PrivateChefvideolink = table.Column<string>(name: "PrivateChef_video_link", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Createtime = table.Column<DateTime>(name: "Create_time", type: "datetime(6)", nullable: false),
                    Lastupttime = table.Column<DateTime>(name: "Last_upt_time", type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivateChefs", x => x.PrivateChefid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FutureEvents");

            migrationBuilder.DropTable(
                name: "MassageTherapies");

            migrationBuilder.DropTable(
                name: "OfferedServices");

            migrationBuilder.DropTable(
                name: "PrivateChefs");
        }
    }
}
