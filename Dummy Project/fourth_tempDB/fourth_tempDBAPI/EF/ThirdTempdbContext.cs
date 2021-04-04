using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using fourth_tempDBAPI.BusinessObject; 

namespace fourth_tempDBAPI
{
    public partial class ThirdTempdbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-UAS3KBE\SQLEXPRESS01;Database=third_tempDB;User ID=abhijit;Password=Abhiraj@18;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__RoleMast__8AFACE1A8931D15B");

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
                    .HasName("PK__UserMast__1788CC4CF588D89E");

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
                    .HasName("PK__UserRole__3D978A35E08586AF");

                entity.ToTable("UserRoles", "dbo");

                entity.Property(e => e.UserRoleId);

                entity.Property(e => e.UserId);

                entity.Property(e => e.RoleId);

                entity.Property(e => e.Status);

                entity.HasOne(d => d.UserMaster)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserRoles__UserI__403A8C7D");

                entity.HasOne(d => d.RoleMaster)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__UserRoles__RoleI__412EB0B6");

            });

            modelBuilder.Entity<WorkflowMaster>(entity =>
            {
                entity.HasKey(e => e.WorkflowId)
                    .HasName("PK__Workflow__5704A66AA8597125");

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
                    .HasName("PK__Workflow__24343357F0E04D1E");

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
                    .HasConstraintName("FK__WorkflowS__WorKf__398D8EEE");

            });

        }

        public virtual DbSet<RoleMaster> RoleMaster { get; set; }
        public virtual DbSet<UserMaster> UserMaster { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<WorkflowMaster> WorkflowMaster { get; set; }
        public virtual DbSet<WorkflowStepsMaster> WorkflowStepsMaster { get; set; }
    }
}
