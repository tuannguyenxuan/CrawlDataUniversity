// <auto-generated />
using System;
using CrawlDataUniversity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrawlDataUniversity.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211223081041_edit")]
    partial class edit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Display")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<int>("Side")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.Benchmark", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Blocks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CurrenPoint")
                        .HasColumnType("float");

                    b.Property<double>("PrePoint")
                        .HasColumnType("float");

                    b.Property<int>("UniversityMajorId")
                        .HasColumnType("int");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UniversityMajorId");

                    b.ToTable("Benchmarks");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.Field", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.Major", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MajorGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MajorGroupId");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.MajorGroup", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.ToTable("MajorGroups");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.Province", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name_with_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.University", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.UniversityMajor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("UniversityMajors");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.Benchmark", b =>
                {
                    b.HasOne("CrawlDataUniversity.Data.Entities.UniversityMajor", "UniversityMajor")
                        .WithMany("Benchmarks")
                        .HasForeignKey("UniversityMajorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UniversityMajor");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.Major", b =>
                {
                    b.HasOne("CrawlDataUniversity.Data.Entities.MajorGroup", "MajorGroup")
                        .WithMany("Major")
                        .HasForeignKey("MajorGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MajorGroup");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.MajorGroup", b =>
                {
                    b.HasOne("CrawlDataUniversity.Data.Entities.Field", "Field")
                        .WithMany("MajorGroups")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Field");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.University", b =>
                {
                    b.HasOne("CrawlDataUniversity.Data.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("CrawlDataUniversity.Data.Entities.Province", "Province")
                        .WithMany("Universities")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.UniversityMajor", b =>
                {
                    b.HasOne("CrawlDataUniversity.Data.Entities.University", "University")
                        .WithMany("UniversityMajors")
                        .HasForeignKey("UniversityId");

                    b.Navigation("University");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.Field", b =>
                {
                    b.Navigation("MajorGroups");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.MajorGroup", b =>
                {
                    b.Navigation("Major");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.Province", b =>
                {
                    b.Navigation("Universities");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.University", b =>
                {
                    b.Navigation("UniversityMajors");
                });

            modelBuilder.Entity("CrawlDataUniversity.Data.Entities.UniversityMajor", b =>
                {
                    b.Navigation("Benchmarks");
                });
#pragma warning restore 612, 618
        }
    }
}
