using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StudentEnquiryAPI.BusinessObject; 

namespace StudentEnquiryAPI
{
    public partial class StudentEnquiryDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UAS3KBE\SQLEXPRESS01;Database=StudentEnquiryDB;User ID=abhijit;Password=Abhiraj@18;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Couse>(entity =>
            {
                entity.HasKey(e => e.Couseid)
                    .HasName("PK_Couse");

                entity.ToTable("Couse", "dbo");

                entity.Property(e => e.Couseid);

                entity.Property(e => e.CouseName)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CourseStartDate)
                    .IsRequired()
                    .HasColumnType("date");

                entity.Property(e => e.CourseEndDate)
                    .IsRequired()
                    .HasColumnType("date");

                entity.Property(e => e.CouseFees)
                    .IsRequired();

            });

            modelBuilder.Entity<Enquiry>(entity =>
            {
                entity.HasKey(e => e.EnquiryId)
                    .HasName("PK_Enquiry");

                entity.ToTable("Enquiry", "dbo");

                entity.Property(e => e.EnquiryId);

                entity.Property(e => e.CourseId)
                    .IsRequired();

                entity.Property(e => e.StudentName)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ContactNo)
                    .IsRequired();

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Enquiry1)
                    .WithMany(p => p.InverseEnquiryIdNavigation)
                    .HasForeignKey(d => d.EnquiryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Enquiry_Enquiry");

                entity.HasOne(d => d.CourseIdNavigation)
                    .WithMany(p => p.Enquiry)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Enquiry_Couse");

            });

            modelBuilder.Entity<LoginTable>(entity =>
            {
                entity.HasKey(e => e.Adminid)
                    .HasName("PK_Login Table");

                entity.ToTable("Login Table", "dbo");

                entity.Property(e => e.Adminid);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

            });

            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__RoleMast__8AFACE1A1AA1F5A6");

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
                    .HasName("PK__UserMast__1788CC4CA45361BA");

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
                    .HasName("PK__UserRole__3D978A3593F99E95");

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
                    .HasName("PK__Workflow__5704A66AF68DCBE2");

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
                    .HasName("PK__Workflow__24343357AE302D44");

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

        public virtual DbSet<Couse> Couse { get; set; }
        public virtual DbSet<Enquiry> Enquiry { get; set; }
        public virtual DbSet<LoginTable> LoginTable { get; set; }
        public virtual DbSet<RoleMaster> RoleMaster { get; set; }
        public virtual DbSet<UserMaster> UserMaster { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<WorkflowMaster> WorkflowMaster { get; set; }
        public virtual DbSet<WorkflowStepsMaster> WorkflowStepsMaster { get; set; }
    }
}
