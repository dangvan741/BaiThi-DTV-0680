﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaiThi_DTV.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230629021104_Cau3")]
    partial class Cau3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("BaiThi_DTV.LopHoc", b =>
                {
                    b.Property<string>("MaSV")
                        .HasColumnType("TEXT");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSV")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaSV");

                    b.ToTable("LopHoc");
                });
#pragma warning restore 612, 618
        }
    }
}
