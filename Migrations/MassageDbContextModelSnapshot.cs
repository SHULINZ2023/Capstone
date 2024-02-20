﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace myDotNetMVCApp.Migrations
{
    [DbContext(typeof(MassageDbContext))]
    partial class MassageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

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
#pragma warning restore 612, 618
        }
    }
}
