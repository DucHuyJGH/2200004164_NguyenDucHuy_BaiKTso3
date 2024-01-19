using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DucHuyTH03.migrations;

public partial class StudentContext : DbContext
{
    public StudentContext()
    {
    }

    public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DAddress> DAddresses { get; set; }

    public virtual DbSet<DStudent> DStudents { get; set; }

    public virtual DbSet<DStudentMark> DStudentMarks { get; set; }

    public virtual DbSet<DSubject> DSubjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-BSDIR50\\DUCHUY; database=DucHuyTH03; user=Huy; password=1111; Trusted_Connection=True; TrustServerCertificate=True ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DAddress>(entity =>
        {
            entity.ToTable("D_ADDRESS");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.DistrictId).HasColumnName("district_id");
            entity.Property(e => e.DistrictName).HasColumnName("district_name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.ProvinceId).HasColumnName("province_id");
            entity.Property(e => e.ProvinceName).HasColumnName("province_name");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.WardId).HasColumnName("ward_id");
            entity.Property(e => e.WardName).HasColumnName("ward_name");
        });

        modelBuilder.Entity<DStudent>(entity =>
        {
            entity.ToTable("D_STUDENT");

            entity.HasIndex(e => e.Addressid1, "IX_D_STUDENT_addressid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.Addressid1).HasColumnName("addressid");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Cccd).HasColumnName("cccd");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.StudentCode).HasColumnName("student_code");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.Addressid1Navigation).WithMany(p => p.DStudents).HasForeignKey(d => d.Addressid1);
        });

        modelBuilder.Entity<DStudentMark>(entity =>
        {
            entity.ToTable("D_STUDENT_MARK");

            entity.HasIndex(e => e.Studentid1, "IX_D_STUDENT_MARK_studentid");

            entity.HasIndex(e => e.Subjectid1, "IX_D_STUDENT_MARK_subjectid");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Mark)
                .HasColumnType("decimal(2, 2)")
                .HasColumnName("mark");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.StudentId).HasColumnName("student_id");
            entity.Property(e => e.Studentid1).HasColumnName("studentid");
            entity.Property(e => e.SubjectId).HasColumnName("subject_id");
            entity.Property(e => e.Subjectid1).HasColumnName("subjectid");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.Studentid1Navigation).WithMany(p => p.DStudentMarks).HasForeignKey(d => d.Studentid1);

            entity.HasOne(d => d.Subjectid1Navigation).WithMany(p => p.DStudentMarks).HasForeignKey(d => d.Subjectid1);
        });

        modelBuilder.Entity<DSubject>(entity =>
        {
            entity.ToTable("D_SUBJECT");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
