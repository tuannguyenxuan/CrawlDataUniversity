using CrawlDataUniversity.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlDataUniversity.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            modelBuilder.Entity<Field>().ToTable("Fields");
            modelBuilder.Entity<Field>().HasKey(x => x.Id);
            modelBuilder.Entity<Field>().Property(x => x.Id).ValueGeneratedNever();

            modelBuilder.Entity<MajorGroup>().ToTable("MajorGroups");
            modelBuilder.Entity<MajorGroup>().HasKey(x => x.Id);
            modelBuilder.Entity<MajorGroup>().HasOne(x => x.Field).WithMany(x => x.MajorGroups).HasForeignKey(x => x.FieldId);
            modelBuilder.Entity<MajorGroup>().Property(x => x.Id).ValueGeneratedNever();

            modelBuilder.Entity<Major>().ToTable("Majors");
            modelBuilder.Entity<Major>().HasKey(x => x.Id);
            modelBuilder.Entity<Major>().HasOne(x => x.MajorGroup).WithMany(x => x.Major).HasForeignKey(x => x.MajorGroupId);
            modelBuilder.Entity<Major>().Property(x => x.Id).ValueGeneratedNever();

            modelBuilder.Entity<University>().ToTable("Universities");
            modelBuilder.Entity<University>().HasKey(x => x.Id);
            modelBuilder.Entity<University>().Property(x => x.Id).ValueGeneratedNever();

            modelBuilder.Entity<UniversityMajor>().ToTable("UniversityMajors");
            modelBuilder.Entity<UniversityMajor>().HasKey(x => x.Id);
            modelBuilder.Entity<UniversityMajor>().HasOne(x => x.University).WithMany(x => x.UniversityMajors).HasForeignKey(x => x.UniversityId);
            modelBuilder.Entity<UniversityMajor>().Property(x => x.Id).ValueGeneratedNever();

            modelBuilder.Entity<Benchmark>().ToTable("Benchmarks");
            modelBuilder.Entity<Benchmark>().HasKey(x => x.Id);
            modelBuilder.Entity<Benchmark>().HasOne(x => x.UniversityMajor).WithMany(x => x.Benchmarks).HasForeignKey(x => x.UniversityMajorId);
            modelBuilder.Entity<Benchmark>().Property(x => x.Id).ValueGeneratedNever();

            modelBuilder.Entity<Province>().ToTable("Provinces");
            modelBuilder.Entity<Province>().HasKey(x => x.Id);
            modelBuilder.Entity<Province>().Property(x => x.Id).ValueGeneratedNever();

            modelBuilder.Entity<Address>().ToTable("Addresses");
            modelBuilder.Entity<Address>().HasKey(x => x.Id);
            modelBuilder.Entity<Address>().Property(x => x.Id).ValueGeneratedNever();
            modelBuilder.Entity<Address>().HasOne(x => x.University).WithMany(x => x.Addresses).HasForeignKey(x => x.UniversityId);
            modelBuilder.Entity<Address>().HasOne(x => x.Province).WithMany(x => x.Addresses).HasForeignKey(x => x.ProvinceId);

        }
        public DbSet<University> Universities { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<MajorGroup> MajorGroups { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<UniversityMajor> UniversityMajors { get; set; }
        public DbSet<Benchmark> Benchmarks { get; set; }
        public DbSet<Province> Provinces { get; set; }

        public DbSet<Address> Addresses { get; set; }

    }
    public class DBContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        private const string ConnectString = "Server=.;Database=UniDB;Trusted_Connection=True;";
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlServer(ConnectString);
            return new ApplicationDbContext(builder.Options);
        }

    }
}
