using System;
using Identity.Models.DB_Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Identity.DbContexts
{
    public partial class DB_SecurityContext : DbContext
    {
        public DB_SecurityContext()
        {
        }

        public DB_SecurityContext(DbContextOptions<DB_SecurityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblUserToken> TblUserToken { get; set; }
        public virtual DbSet<TblUserTokenDetalis> TblUserTokenDetalis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=10.217.10.16;Initial Catalog=DB_Security;User ID=rNwUs@Ag;Password=a2sLs@Ag;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblUserToken>(entity =>
            {
                entity.HasKey(e => e.IntId)
                    .HasName("PK_tblUserToken_1");

                entity.ToTable("tblUserToken");

                entity.Property(e => e.IntId).HasColumnName("intId");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DteLastActionTime)
                    .HasColumnName("dteLastActionTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.StrDomain)
                    .HasColumnName("strDomain")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrEmail)
                    .HasColumnName("strEmail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrPassword)
                    .HasColumnName("strPassword")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrRefreshToken)
                    .HasColumnName("strRefreshToken")
                    .IsUnicode(false);

                entity.Property(e => e.StrToken)
                    .HasColumnName("strToken")
                    .IsUnicode(false);

                entity.Property(e => e.StrUid)
                    .HasColumnName("strUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.YsnEnable).HasColumnName("ysnEnable");

                entity.Property(e => e.YsnUsed).HasColumnName("ysnUsed");
            });

            modelBuilder.Entity<TblUserTokenDetalis>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tblUserTokenDetalis");

                entity.Property(e => e.IntId).HasColumnName("intId");

                entity.Property(e => e.DteAction)
                    .HasColumnName("dteAction")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IntRefTokenId).HasColumnName("intRefTokenId");

                entity.Property(e => e.StrRefreshToken)
                    .HasColumnName("strRefreshToken")
                    .IsUnicode(false);

                entity.Property(e => e.StrStatus)
                    .HasColumnName("strStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrToken)
                    .HasColumnName("strToken")
                    .IsUnicode(false);

                entity.Property(e => e.StrUid)
                    .HasColumnName("strUID")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
