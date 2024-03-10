﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace myDotNetMVCApp.Migrations
{
    [DbContext(typeof(MassageDbContext))]
    [Migration("20240308225758_updatetable5")]
    partial class updatetable5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Models.Entities.BusinessProfile", b =>
                {
                    b.Property<long>("BusinessProfile_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("BusinessProfile_address")
                        .HasColumnType("longtext");

                    b.Property<string>("BusinessProfile_contact")
                        .HasColumnType("longtext");

                    b.Property<string>("BusinessProfile_desc")
                        .HasColumnType("longtext");

                    b.Property<string>("BusinessProfile_email")
                        .HasColumnType("longtext");

                    b.Property<string>("BusinessProfile_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("BusinessProfile_photo_url")
                        .HasColumnType("longtext");

                    b.Property<string>("BusinessProfile_video_link")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("business_start_year")
                        .HasColumnType("int");

                    b.HasKey("BusinessProfile_id");

                    b.ToTable("BusinessProfiles");
                });

            modelBuilder.Entity("Models.Entities.Customer", b =>
                {
                    b.Property<long>("Customer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Customer_address")
                        .HasColumnType("longtext");

                    b.Property<string>("Customer_desc")
                        .HasColumnType("longtext");

                    b.Property<string>("Customer_email")
                        .HasColumnType("longtext");

                    b.Property<string>("Customer_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Customer_phone")
                        .HasColumnType("longtext");

                    b.Property<string>("Customer_photo_uri")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Customer_id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Models.Entities.CustomerFeedback", b =>
                {
                    b.Property<long>("CustomerFeedback_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("Customer_id")
                        .HasColumnType("bigint");

                    b.Property<double>("Feedback_Rate")
                        .HasColumnType("double");

                    b.Property<string>("Feedback_comments")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("OfferedService_id")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CustomerFeedback_id");

                    b.ToTable("CustomerFeedbacks");
                });

            modelBuilder.Entity("Models.Entities.FutureEvent", b =>
                {
                    b.Property<long>("FutureEvent_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FutureEvent_contact")
                        .HasColumnType("longtext");

                    b.Property<string>("FutureEvent_desc")
                        .HasColumnType("longtext");

                    b.Property<string>("FutureEvent_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FutureEvent_photo_url")
                        .HasColumnType("longtext");

                    b.Property<string>("FutureEvent_video_link")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ServiceCostPolicy")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("FutureEvent_id");

                    b.ToTable("FutureEvents");
                });

            modelBuilder.Entity("Models.Entities.MssgTherapy", b =>
                {
                    b.Property<long>("MssgTherapy_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Kind1_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MssgTherapy_contact")
                        .HasColumnType("longtext");

                    b.Property<string>("MssgTherapy_desc")
                        .HasColumnType("longtext");

                    b.Property<string>("MssgTherapy_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MssgTherapy_photo_url")
                        .HasColumnType("longtext");

                    b.Property<string>("MssgTherapy_video_link")
                        .HasColumnType("longtext");

                    b.Property<string>("ServiceCostPolicy")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MssgTherapy_id");

                    b.ToTable("MassageTherapies");
                });

            modelBuilder.Entity("Models.Entities.OfferedService", b =>
                {
                    b.Property<long>("OfferedService_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Kind1_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OfferedService_contact")
                        .HasColumnType("longtext");

                    b.Property<string>("OfferedService_desc")
                        .HasColumnType("longtext");

                    b.Property<string>("OfferedService_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OfferedService_photo_url")
                        .HasColumnType("longtext");

                    b.Property<string>("OfferedService_video_link")
                        .HasColumnType("longtext");

                    b.Property<string>("ServiceCostPolicy")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("OfferedService_id");

                    b.ToTable("OfferedServices");
                });

            modelBuilder.Entity("Models.Entities.PrivateChef", b =>
                {
                    b.Property<long>("PrivateChef_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Kind1_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PrivateChef_contact")
                        .HasColumnType("longtext");

                    b.Property<string>("PrivateChef_desc")
                        .HasColumnType("longtext");

                    b.Property<string>("PrivateChef_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PrivateChef_photo_url")
                        .HasColumnType("longtext");

                    b.Property<string>("PrivateChef_video_link")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PrivateChef_id");

                    b.ToTable("PrivateChefs");
                });

            modelBuilder.Entity("Models.Entities.Section", b =>
                {
                    b.Property<long>("Section_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Kind1_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind1_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind2_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto1_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto2_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto3_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto4_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Kind3_foto5_uri")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Last_upt_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Section_background_photo_uri")
                        .HasColumnType("longtext");

                    b.Property<string>("Section_desc")
                        .HasColumnType("longtext");

                    b.Property<string>("Section_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Section_video_link")
                        .HasColumnType("longtext");

                    b.Property<string>("Setion_type")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Section_id");

                    b.ToTable("Sections");
                });
#pragma warning restore 612, 618
        }
    }
}
