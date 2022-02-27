using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PricingModule.Models.iBOS;

namespace PricingModule.DbContexts
{
    public partial class iBOSContext : DbContext
    {
        public iBOSContext()
        {
        }

        public iBOSContext(DbContextOptions<iBOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblPriceSetup> TblPriceSetup { get; set; }
        public virtual DbSet<TblTerritory> TblTerritory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=ibos.akij.net;Initial Catalog=iBOS;User ID=AkijApp;Password=appS@Connect;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblPriceSetup>(entity =>
            {
                entity.HasKey(e => e.IntPriceConditionId);

                entity.ToTable("tblPriceSetup", "somo");

                entity.Property(e => e.IntPriceConditionId)
                    .HasColumnName("intPriceConditionId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.DteEndDate)
                    .HasColumnName("dteEndDate")
                    .HasColumnType("date")
                    .HasComment("value of this field will specify the end date till when any Price Setup will be activated.");

                entity.Property(e => e.DteLastActionDateTime)
                    .HasColumnName("dteLastActionDateTime")
                    .HasColumnType("datetime")
                    .HasComment("This field is used to keep record of every action's date & time in this table.");

                entity.Property(e => e.DteServerDateTime)
                    .HasColumnName("dteServerDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("This field is used to keep record of every action's server's date & time in this table. ");

                entity.Property(e => e.DteStartDate)
                    .HasColumnName("dteStartDate")
                    .HasColumnType("date")
                    .HasComment("Value of this field will specify the start date from when any Price Setup will be activated.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the respective clients.");

                entity.Property(e => e.IntConditionReffId)
                    .HasColumnName("intConditionReffId")
                    .HasComment("Identity key field for Condition reference Type. Value of this field will specify the Reference type  of Price Conditoin such as Customer, Territory, Distribution Channel and Sales Organization.");

                entity.Property(e => e.IntConditionTypeId)
                    .HasColumnName("intConditionTypeId")
                    .HasComment("A unique key field for identifying every individual Condition Type. (FK)");

                entity.Property(e => e.IntItemId)
                    .HasColumnName("intItemId")
                    .HasComment("Identity field for Item. Value of this field will specify individual Item. ");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Price Setup is active or not.");

                entity.Property(e => e.NumPrice)
                    .HasColumnName("numPrice")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of this field will specify the amount which will be used as Setup Price amount.(per Unit Base Price).");

                entity.Property(e => e.StrConditionTypeName)
                    .IsRequired()
                    .HasColumnName("strConditionTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective Condition Type.");
            });

            modelBuilder.Entity<TblTerritory>(entity =>
            {
                entity.HasKey(e => e.IntTerritoryId);

                entity.ToTable("tblTerritory", "msto");

                entity.Property(e => e.IntTerritoryId)
                    .HasColumnName("intTerritoryId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.DteLastActionDateTime)
                    .HasColumnName("dteLastActionDateTime")
                    .HasColumnType("datetime")
                    .HasComment("This field is used to keep record of every action's date & time in this table.");

                entity.Property(e => e.DteServerDateTime)
                    .HasColumnName("dteServerDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("This field is used to keep record of every action's server's date & time in this table. ");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify the Business Unit Where the Territory belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Territoy belongs to.");

                entity.Property(e => e.IntDistirct)
                    .HasColumnName("intDistirct")
                    .HasComment("Identity field for District. Value of this field will specify the District of individual Territory.");

                entity.Property(e => e.IntDivision)
                    .HasColumnName("intDivision")
                    .HasComment("Identity field for Division. Value of this field will specify the Division of individual Territory.");

                entity.Property(e => e.IntParentTerritoryId)
                    .HasColumnName("intParentTerritoryId")
                    .HasComment("Identity field for Parent Territory. Value of this field will specify the Parent Territory.");

                entity.Property(e => e.IntPlantId)
                    .HasColumnName("intPlantId")
                    .HasComment("Identity field for Plant. Value of this field will specify the Plant Where the Territory belongs to.");

                entity.Property(e => e.IntTerritoryTypeId)
                    .HasColumnName("intTerritoryTypeId")
                    .HasComment("Identity field for Territory Type. Value of this field will specify the Territory Type.");

                entity.Property(e => e.IntThana)
                    .HasColumnName("intThana")
                    .HasComment("Identity field for Thana. Value of this field will specify the Thana of individual Territory.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Territory  is active or not.");

                entity.Property(e => e.StrAddress)
                    .IsRequired()
                    .HasColumnName("strAddress")
                    .HasMaxLength(300)
                    .HasComment("Value of this field will specify the Address of individual Territory.");

                entity.Property(e => e.StrDistirct)
                    .IsRequired()
                    .HasColumnName("strDistirct")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the District of individual Territory.");

                entity.Property(e => e.StrDivision)
                    .IsRequired()
                    .HasColumnName("strDivision")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Division of individual Territory.");

                entity.Property(e => e.StrTerritoryCode)
                    .IsRequired()
                    .HasColumnName("strTerritoryCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Territory.");

                entity.Property(e => e.StrTerritoryName)
                    .IsRequired()
                    .HasColumnName("strTerritoryName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Territory.");

                entity.Property(e => e.StrThana)
                    .IsRequired()
                    .HasColumnName("strThana")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Thana of individual Territory.");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
