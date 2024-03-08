using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myDotNetMVCApp.Migrations
{
    /// <inheritdoc />
    public partial class newtable5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerFeedbacks",
                columns: table => new
                {
                    CustomerFeedbackid = table.Column<long>(name: "CustomerFeedback_id", type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Customerid = table.Column<long>(name: "Customer_id", type: "bigint", nullable: false),
                    OfferedServiceid = table.Column<long>(name: "OfferedService_id", type: "bigint", nullable: false),
                    Feedbackcomments = table.Column<string>(name: "Feedback_comments", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FeedbackRate = table.Column<double>(name: "Feedback_Rate", type: "double", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Createtime = table.Column<DateTime>(name: "Create_time", type: "datetime(6)", nullable: false),
                    Lastupttime = table.Column<DateTime>(name: "Last_upt_time", type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerFeedbacks", x => x.CustomerFeedbackid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Customerid = table.Column<long>(name: "Customer_id", type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Customername = table.Column<string>(name: "Customer_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Customeraddress = table.Column<string>(name: "Customer_address", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Customerphone = table.Column<string>(name: "Customer_phone", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Customeremail = table.Column<string>(name: "Customer_email", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Customerdesc = table.Column<string>(name: "Customer_desc", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Customerphotouri = table.Column<string>(name: "Customer_photo_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Createtime = table.Column<DateTime>(name: "Create_time", type: "datetime(6)", nullable: false),
                    Lastupttime = table.Column<DateTime>(name: "Last_upt_time", type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Customerid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Sectionid = table.Column<long>(name: "Section_id", type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Sectionname = table.Column<string>(name: "Section_name", type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sectiondesc = table.Column<string>(name: "Section_desc", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sectionbackgroundphotouri = table.Column<string>(name: "Section_background_photo_uri", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Setiontype = table.Column<string>(name: "Setion_type", type: "longtext", nullable: true)
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
                    Sectionvideolink = table.Column<string>(name: "Section_video_link", type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Createtime = table.Column<DateTime>(name: "Create_time", type: "datetime(6)", nullable: false),
                    Lastupttime = table.Column<DateTime>(name: "Last_upt_time", type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Sectionid);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerFeedbacks");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Sections");
        }
    }
}
