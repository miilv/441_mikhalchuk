﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpfApp;

#nullable disable

namespace WpfApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("WpfApp.Bytedata", b =>
                {
                    b.Property<int>("ImageId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("byte_image")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("ImageId");

                    b.ToTable("Bytedatas");
                });

            modelBuilder.Entity("WpfApp.Hashkey", b =>
                {
                    b.Property<int>("ImageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("hashkey")
                        .HasColumnType("INTEGER");

                    b.HasKey("ImageId");

                    b.ToTable("Hashkeys");
                });

            modelBuilder.Entity("WpfApp.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Embedding")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Position")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("WpfApp.Bytedata", b =>
                {
                    b.HasOne("WpfApp.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("WpfApp.Hashkey", b =>
                {
                    b.HasOne("WpfApp.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });
#pragma warning restore 612, 618
        }
    }
}
