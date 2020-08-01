using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NinjaApp1.Data
{
    public partial class AllotmentdbContext : DbContext
    {
        public AllotmentdbContext()
        {
        }

        public AllotmentdbContext(DbContextOptions<AllotmentdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllotedList> AllotedList { get; set; }
        public virtual DbSet<CollegeCodes> CollegeCodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=KEERTHIKA; Initial Catalog = Allotmentdb ;trusted_connection= true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllotedList>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AggrMark).HasColumnName("AGGR MARK");

                entity.Property(e => e.AllottedCategory)
                    .HasColumnName("ALLOTTED CATEGORY")
                    .HasMaxLength(255);

                entity.Property(e => e.AppNo).HasColumnName("APP NO");

                entity.Property(e => e.BranchCode)
                    .HasColumnName("BRANCH CODE")
                    .HasMaxLength(255);

                entity.Property(e => e.ChoiceNo).HasColumnName("CHOICE NO");

                entity.Property(e => e.CollegeCode).HasColumnName("COLLEGE CODE");

                entity.Property(e => e.Community)
                    .HasColumnName("COMMUNITY")
                    .HasMaxLength(255);

                entity.Property(e => e.Rank).HasColumnName("RANK");
            });

            modelBuilder.Entity<CollegeCodes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("College_Codes");

                entity.Property(e => e.Distirct).HasMaxLength(255);

                entity.Property(e => e.NameOfTheCollege)
                    .HasColumnName("Name of the college")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
