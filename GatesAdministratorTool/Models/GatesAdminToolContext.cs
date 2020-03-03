using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GatesAdministratorTool.Models
{
    public partial class GatesAdminToolContext : DbContext
    {
        public GatesAdminToolContext()
        {
        }

        public GatesAdminToolContext(DbContextOptions<GatesAdminToolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApplicationDetails> ApplicationDetails { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }

      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=SSCCHN1DT0902\\SQLEXPRESS;database=GatesAdminTool;Trusted_Connection=True");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationDetails>(entity =>
            {
                entity.HasKey(e => e.ApplicationId);

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.AppSwitches)
                    .HasColumnName("app_switches")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DatabaseExpireDate)
                    .HasColumnName("database_expire_date")
                    .HasMaxLength(50);

                entity.Property(e => e.DatabaseVersion)
                    .HasColumnName("database_version")
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultLifetime)
                    .HasColumnName("default_lifetime")
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultUserLevel)
                    .HasColumnName("default_user_level")
                    .HasMaxLength(50);

                entity.Property(e => e.EmailNotification)
                    .HasColumnName("email_notification")
                    .HasMaxLength(50);

                entity.Property(e => e.EmailRecipients)
                    .HasColumnName("email_recipients")
                    .HasMaxLength(50);

                entity.Property(e => e.InstallLocation)
                    .HasColumnName("install_location")
                    .HasMaxLength(50);

                entity.Property(e => e.IsRequiredUpdate)
                    .HasColumnName("is_required_update")
                    .HasMaxLength(50);

                entity.Property(e => e.RequiredMinimumVersion)
                    .HasColumnName("required_minimum_version")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDescriptionPath)
                    .HasColumnName("update_description_path")
                    .HasMaxLength(50);

                entity.Property(e => e.VersionBuild)
                    .HasColumnName("version_build")
                    .HasMaxLength(50);

                entity.Property(e => e.VersionMajor)
                    .HasColumnName("version_major")
                    .HasMaxLength(50);

                entity.Property(e => e.VersionMinor)
                    .HasColumnName("version_minor")
                    .HasMaxLength(50);

                entity.Property(e => e.VersionRevision)
                    .HasColumnName("version_revision")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserDetails>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.CreateBy)
                    .HasColumnName("create_by")
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasColumnName("email_id")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });
        }
    }
}
