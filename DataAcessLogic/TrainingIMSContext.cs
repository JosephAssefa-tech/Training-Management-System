using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataModels.Models;

#nullable disable

namespace DataAcessLogic
{
    public partial class TrainingIMSContext : DbContext
    {
        public TrainingIMSContext()
        {
        }

        public TrainingIMSContext(DbContextOptions<TrainingIMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TableAcademicLevel> TableAcademicLevels { get; set; }
        public virtual DbSet<TableGender> TableGenders { get; set; }
        public virtual DbSet<TableNewsUpdate> TableNewsUpdates { get; set; }
        public virtual DbSet<TablePosition> TablePositions { get; set; }
        public virtual DbSet<TableRegion> TableRegions { get; set; }
        public virtual DbSet<TableStaff> TableStaffs { get; set; }
        public virtual DbSet<TableTrainee> TableTrainees { get; set; }
        public virtual DbSet<TableTraining> TableTrainings { get; set; }
        public virtual DbSet<TableTrainingStaff> TableTrainingStaffs { get; set; }
        public virtual DbSet<TableTrainingTrainee> TableTrainingTrainees { get; set; }
        public virtual DbSet<TableTrainingType> TableTrainingTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-LMG59KKQ;Database=TrainingInformationManagementSystemDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TableNewsUpdate>(entity =>
            {
                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TableNewsUpdates)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tableNewsUpdate_tableTrainee");
            });

            modelBuilder.Entity<TableStaff>(entity =>
            {
                entity.HasOne(d => d.AcademicLevel)
                    .WithMany(p => p.TableStaffs)
                    .HasForeignKey(d => d.AcademicLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tableStaff_tableAcademicLevel");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.TableStaffs)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tableStaff_tableGender");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.TableStaffs)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tableStaff_tablePosition");
            });

            modelBuilder.Entity<TableTrainee>(entity =>
            {
                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.TableTrainees)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tableTrainee_tableGender");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.TableTrainees)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tableTrainee_tableRegion");
            });

            modelBuilder.Entity<TableTraining>(entity =>
            {
                entity.HasOne(d => d.TrainingType)
                    .WithMany(p => p.TableTrainings)
                    .HasForeignKey(d => d.TrainingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tableTraining_tableTrainingType");
            });

            modelBuilder.Entity<TableTrainingStaff>(entity =>
            {
                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.TableTrainingStaffs)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tableTrainingStaff_tableStaff");

                entity.HasOne(d => d.Training)
                    .WithMany(p => p.TableTrainingStaffs)
                    .HasForeignKey(d => d.TrainingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tableTrainingStaff_tableTraining");
            });

            modelBuilder.Entity<TableTrainingTrainee>(entity =>
            {
                entity.HasOne(d => d.Trainee)
                    .WithMany(p => p.TableTrainingTrainees)
                    .HasForeignKey(d => d.TraineeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tableTrainingTrainee_tableTrainee");

                entity.HasOne(d => d.Training)
                    .WithMany(p => p.TableTrainingTrainees)
                    .HasForeignKey(d => d.TrainingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tableTrainingTrainee_tableTraining");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
