﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace nguyenhoangcam0256.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("nguyenhoangcam0256.Models.NHC256KhachHang", b =>
                {
                    b.Property<int>("NHC256KhachHangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("NHC256Address")
                        .HasColumnType("REAL");

                    b.Property<string>("NHC256NameKhachHang")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("NHC256KhachHangID");

                    b.ToTable("NHC256KhachHang");
                });
#pragma warning restore 612, 618
        }
    }
}
