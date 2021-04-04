using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CourseEnquiry1API.BusinessObject; 

namespace CourseEnquiry1API
{
    public partial class CourseEnquiryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UAS3KBE\SQLEXPRESS01;Database=CourseEnquiry;User ID=abhijit;Password=Abhiraj@18;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CourseId)
                    .HasName("PK_Course");

                entity.ToTable("Course", "dbo");

                entity.Property(e => e.CourseId);

                entity.Property(e => e.CourseName)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("date");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("date");

                entity.Property(e => e.Fees)
                    .IsRequired()
                    .HasColumnType("money");

            });

            modelBuilder.Entity<CourseEnrollment>(entity =>
            {
                entity.HasKey(e => e.EnrollmentId)
                    .HasName("PK_CourseEnrollment");

                entity.ToTable("CourseEnrollment", "dbo");

                entity.Property(e => e.EnrollmentId);

                entity.Property(e => e.CourseName)
                    .IsRequired();

                entity.Property(e => e.StudentName)
                    .IsRequired();

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.CourseNameNavigation)
                    .WithMany(p => p.CourseEnrollment)
                    .HasForeignKey(d => d.CourseName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CourseEnrollment_Course");

                entity.HasOne(d => d.StudentNameNavigation)
                    .WithMany(p => p.CourseEnrollment)
                    .HasForeignKey(d => d.StudentName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CourseEnrollment_Student");

            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudenId)
                    .HasName("PK_Student");

                entity.ToTable("Student", "dbo");

                entity.Property(e => e.StudenId);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ContactNumber)
                    .IsRequired();

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

            });

            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__RoleMast__8AFACE1A8790D14E");

                entity.ToTable("RoleMaster", "dbo");

                entity.Property(e => e.RoleId);

                entity.Property(e => e.RoleDescription)
                    .HasMaxLength(25);

                entity.Property(e => e.CreatedOn)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsRequired();

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50);

            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserMast__1788CC4C189EF70F");

                entity.ToTable("UserMaster", "dbo");

                entity.Property(e => e.UserId);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsRequired();

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50);

            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId)
                    .HasName("PK__UserRole__3D978A358BE48F47");

                entity.ToTable("UserRoles", "dbo");

                entity.Property(e => e.UserRoleId);

                entity.Property(e => e.UserId);

                entity.Property(e => e.RoleId);

                entity.Property(e => e.Status);

                entity.HasOne(d => d.UserMaster)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserRoles__UserI__47DBAE45");

                entity.HasOne(d => d.RoleMaster)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__UserRoles__RoleI__48CFD27E");

            });

            modelBuilder.Entity<WorkflowMaster>(entity =>
            {
                entity.HasKey(e => e.WorkflowId)
                    .HasName("PK__Workflow__5704A66AC515CC42");

                entity.ToTable("WorkflowMaster", "dbo");

                entity.Property(e => e.WorkflowId);

                entity.Property(e => e.WorkflowName)
                    .HasMaxLength(50)
                    .IsRequired();

                entity.Property(e => e.LevelOfApprovals);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CreatedOn)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(50);

                entity.Property(e => e.Updatedon)
                    .IsRequired()
                    .HasColumnType("datetime");

            });

            modelBuilder.Entity<WorkflowStepsMaster>(entity =>
            {
                entity.HasKey(e => e.StepId)
                    .HasName("PK__Workflow__24343357DBD24FE4");

                entity.ToTable("WorkflowStepsMaster", "dbo");

                entity.Property(e => e.StepId);

                entity.Property(e => e.WorKflowId);

                entity.Property(e => e.ApprovalLevel)
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasMaxLength(50);

                entity.Property(e => e.AutoApprove)
                    .HasMaxLength(50);

                entity.Property(e => e.WaitTime);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedOn)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.HasOne(d => d.WorKflowIdNavigation)
                    .WithMany(p => p.WorkflowStepsMaster)
                    .HasForeignKey(d => d.WorKflowId)
                    .HasConstraintName("FK__WorkflowS__WorKf__412EB0B6");

            });

        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseEnrollment> CourseEnrollment { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<RoleMaster> RoleMaster { get; set; }
        public virtual DbSet<UserMaster> UserMaster { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<WorkflowMaster> WorkflowMaster { get; set; }
        public virtual DbSet<WorkflowStepsMaster> WorkflowStepsMaster { get; set; }
    }
}
