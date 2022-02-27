using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ControlPanel.Models.iBOS;

namespace ControlPanel.DbContexts
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

        public virtual DbSet<TblAccountCategory> TblAccountCategory { get; set; }
        public virtual DbSet<TblAccountClass> TblAccountClass { get; set; }
        public virtual DbSet<TblAccountGroup> TblAccountGroup { get; set; }
        public virtual DbSet<TblAccountPayableRow> TblAccountPayableRow { get; set; }
        public virtual DbSet<TblAccountReceivablePayableHeader> TblAccountReceivablePayableHeader { get; set; }
        public virtual DbSet<TblAccountReceivableRow> TblAccountReceivableRow { get; set; }
        public virtual DbSet<TblAccountingJournal> TblAccountingJournal { get; set; }
        public virtual DbSet<TblAccountingJournalCodeGenerator> TblAccountingJournalCodeGenerator { get; set; }
        public virtual DbSet<TblAccountingJournalType> TblAccountingJournalType { get; set; }
        public virtual DbSet<TblAccountingJournalTypeBusinessUnit> TblAccountingJournalTypeBusinessUnit { get; set; }
        public virtual DbSet<TblAccountingPostingType> TblAccountingPostingType { get; set; }
        public virtual DbSet<TblAdjustmentJournalHeader> TblAdjustmentJournalHeader { get; set; }
        public virtual DbSet<TblAdjustmentJournalRow> TblAdjustmentJournalRow { get; set; }
        public virtual DbSet<TblAlternativeAndStandardReconGeneralLedger> TblAlternativeAndStandardReconGeneralLedger { get; set; }
        public virtual DbSet<TblBalanceCheckType> TblBalanceCheckType { get; set; }
        public virtual DbSet<TblBank> TblBank { get; set; }
        public virtual DbSet<TblBankAccount> TblBankAccount { get; set; }
        public virtual DbSet<TblBankBranch> TblBankBranch { get; set; }
        public virtual DbSet<TblBankBranchBusinessUnit> TblBankBranchBusinessUnit { get; set; }
        public virtual DbSet<TblBankInstrumentType> TblBankInstrumentType { get; set; }
        public virtual DbSet<TblBankJournalHeader> TblBankJournalHeader { get; set; }
        public virtual DbSet<TblBankJournalRow> TblBankJournalRow { get; set; }
        public virtual DbSet<TblBusinessArea> TblBusinessArea { get; set; }
        public virtual DbSet<TblBusinessPartner> TblBusinessPartner { get; set; }
        public virtual DbSet<TblBusinessPartnerDistributionChannel> TblBusinessPartnerDistributionChannel { get; set; }
        public virtual DbSet<TblBusinessPartnerGeneralLedger> TblBusinessPartnerGeneralLedger { get; set; }
        public virtual DbSet<TblBusinessPartnerLedger> TblBusinessPartnerLedger { get; set; }
        public virtual DbSet<TblBusinessPartnerPurchase> TblBusinessPartnerPurchase { get; set; }
        public virtual DbSet<TblBusinessPartnerSales> TblBusinessPartnerSales { get; set; }
        public virtual DbSet<TblBusinessPartnerShipPoint> TblBusinessPartnerShipPoint { get; set; }
        public virtual DbSet<TblBusinessPartnerTerritory> TblBusinessPartnerTerritory { get; set; }
        public virtual DbSet<TblBusinessPartnerZone> TblBusinessPartnerZone { get; set; }
        public virtual DbSet<TblBusinessUnit> TblBusinessUnit { get; set; }
        public virtual DbSet<TblBusinessUnitCurrency> TblBusinessUnitCurrency { get; set; }
        public virtual DbSet<TblBusinessUnitCurrencyConversion> TblBusinessUnitCurrencyConversion { get; set; }
        public virtual DbSet<TblBusinessUnitSalesOrganizationIncoterms> TblBusinessUnitSalesOrganizationIncoterms { get; set; }
        public virtual DbSet<TblBusniessUnitGeneralLedger> TblBusniessUnitGeneralLedger { get; set; }
        public virtual DbSet<TblCashJournalHeader> TblCashJournalHeader { get; set; }
        public virtual DbSet<TblCashJournalRow> TblCashJournalRow { get; set; }
        public virtual DbSet<TblClient> TblClient { get; set; }
        public virtual DbSet<TblCountry> TblCountry { get; set; }
        public virtual DbSet<TblCurrency> TblCurrency { get; set; }
        public virtual DbSet<TblDeliveryRoute> TblDeliveryRoute { get; set; }
        public virtual DbSet<TblDeliveryType> TblDeliveryType { get; set; }
        public virtual DbSet<TblDepreciationType> TblDepreciationType { get; set; }
        public virtual DbSet<TblDistributionChannel> TblDistributionChannel { get; set; }
        public virtual DbSet<TblDistrict> TblDistrict { get; set; }
        public virtual DbSet<TblDivision> TblDivision { get; set; }
        public virtual DbSet<TblGeneralLedger> TblGeneralLedger { get; set; }
        public virtual DbSet<TblIncoTerms> TblIncoTerms { get; set; }
        public virtual DbSet<TblItem> TblItem { get; set; }
        public virtual DbSet<TblItemAttribute> TblItemAttribute { get; set; }
        public virtual DbSet<TblItemAttributeConfig> TblItemAttributeConfig { get; set; }
        public virtual DbSet<TblItemCategory> TblItemCategory { get; set; }
        public virtual DbSet<TblItemMaster> TblItemMaster { get; set; }
        public virtual DbSet<TblItemPlantWarehouse> TblItemPlantWarehouse { get; set; }
        public virtual DbSet<TblItemPurchase> TblItemPurchase { get; set; }
        public virtual DbSet<TblItemSales> TblItemSales { get; set; }
        public virtual DbSet<TblItemSubCategory> TblItemSubCategory { get; set; }
        public virtual DbSet<TblItemType> TblItemType { get; set; }
        public virtual DbSet<TblItemUomconversion> TblItemUomconversion { get; set; }
        public virtual DbSet<TblLogTerritorySalesForceChange> TblLogTerritorySalesForceChange { get; set; }
        public virtual DbSet<TblOrderReferanceType> TblOrderReferanceType { get; set; }
        public virtual DbSet<TblOutlet> TblOutlet { get; set; }
        public virtual DbSet<TblOutletTerritory> TblOutletTerritory { get; set; }
        public virtual DbSet<TblPaymentTerms> TblPaymentTerms { get; set; }
        public virtual DbSet<TblPlant> TblPlant { get; set; }
        public virtual DbSet<TblPlantWarehouse> TblPlantWarehouse { get; set; }
        public virtual DbSet<TblPriceConditionTypeOrganization> TblPriceConditionTypeOrganization { get; set; }
        public virtual DbSet<TblPriceSetup> TblPriceSetup { get; set; }
        public virtual DbSet<TblProductDivision> TblProductDivision { get; set; }
        public virtual DbSet<TblPurchaseOrganization> TblPurchaseOrganization { get; set; }
        public virtual DbSet<TblRoundingType> TblRoundingType { get; set; }
        public virtual DbSet<TblRoute> TblRoute { get; set; }
        public virtual DbSet<TblRouteTransportzone> TblRouteTransportzone { get; set; }
        public virtual DbSet<TblSalesArea> TblSalesArea { get; set; }
        public virtual DbSet<TblSalesForceTerritory> TblSalesForceTerritory { get; set; }
        public virtual DbSet<TblSalesOffice> TblSalesOffice { get; set; }
        public virtual DbSet<TblSalesOrderGroup> TblSalesOrderGroup { get; set; }
        public virtual DbSet<TblSalesOrderHeader> TblSalesOrderHeader { get; set; }
        public virtual DbSet<TblSalesOrderRow> TblSalesOrderRow { get; set; }
        public virtual DbSet<TblSalesOrderType> TblSalesOrderType { get; set; }
        public virtual DbSet<TblSalesOrganization> TblSalesOrganization { get; set; }
        public virtual DbSet<TblShipPoint> TblShipPoint { get; set; }
        public virtual DbSet<TblShipPointWarehouse> TblShipPointWarehouse { get; set; }
        public virtual DbSet<TblShippingType> TblShippingType { get; set; }
        public virtual DbSet<TblSoldToPartnerShipToPartner> TblSoldToPartnerShipToPartner { get; set; }
        public virtual DbSet<TblTerritory> TblTerritory { get; set; }
        public virtual DbSet<TblTerritoryType> TblTerritoryType { get; set; }
        public virtual DbSet<TblThana> TblThana { get; set; }
        public virtual DbSet<TblTradeOfferConditionTypeItem> TblTradeOfferConditionTypeItem { get; set; }
        public virtual DbSet<TblTradeOfferItemGroupHeader> TblTradeOfferItemGroupHeader { get; set; }
        public virtual DbSet<TblTradeOfferItemGroupRow> TblTradeOfferItemGroupRow { get; set; }
        public virtual DbSet<TblTradeOfferSetupHeader> TblTradeOfferSetupHeader { get; set; }
        public virtual DbSet<TblTradeOfferSetupRow> TblTradeOfferSetupRow { get; set; }
        public virtual DbSet<TblTransportMode> TblTransportMode { get; set; }
        public virtual DbSet<TblTransportZone> TblTransportZone { get; set; }
        public virtual DbSet<TblUnitOfMeasurement> TblUnitOfMeasurement { get; set; }
        public virtual DbSet<TblUser> TblUser { get; set; }
        public virtual DbSet<TblVehicle> TblVehicle { get; set; }
        public virtual DbSet<TblWarehouse> TblWarehouse { get; set; }

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
            modelBuilder.Entity<TblAccountCategory>(entity =>
            {
                entity.HasKey(e => e.IntAccountCategoryId);

                entity.ToTable("tblAccountCategory", "msto");

                entity.Property(e => e.IntAccountCategoryId)
                    .HasColumnName("intAccountCategoryId")
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

                entity.Property(e => e.IntAccountClassId)
                    .HasColumnName("intAccountClassId")
                    .HasComment("Identity field for Account Class. Value of this field will specify the Account Class where the Acoount Category belongs to.");

                entity.Property(e => e.IntAccountGroupId)
                    .HasColumnName("intAccountGroupId")
                    .HasComment("Identity field for Account Group. Value of this field will specify the Account Group where the Acoount Category belongs to.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whom the Account belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether the Account Category is active or not.");

                entity.Property(e => e.StrAccountCategoryCode)
                    .IsRequired()
                    .HasColumnName("strAccountCategoryCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Account Category.");

                entity.Property(e => e.StrAccountCategoryName)
                    .IsRequired()
                    .HasColumnName("strAccountCategoryName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will identify the name of individual Accounts Category.");
            });

            modelBuilder.Entity<TblAccountClass>(entity =>
            {
                entity.HasKey(e => e.IntAccountClassId);

                entity.ToTable("tblAccountClass", "msto");

                entity.Property(e => e.IntAccountClassId)
                    .HasColumnName("intAccountClassId")
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

                entity.Property(e => e.IntAccountGroupId)
                    .HasColumnName("intAccountGroupId")
                    .HasComment("Identity field for Account Group. Value of this field will specify the Account Group where the Account Class belongs to.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for every individual Client .Value of this filed will specify the clients whom this Account Class belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Account Class is active or not.");

                entity.Property(e => e.StrAccountClassCode)
                    .IsRequired()
                    .HasColumnName("strAccountClassCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Account Group.");

                entity.Property(e => e.StrAccountClassName)
                    .IsRequired()
                    .HasColumnName("strAccountClassName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will identify the name of individual Accounts Group.");
            });

            modelBuilder.Entity<TblAccountGroup>(entity =>
            {
                entity.HasKey(e => e.IntAccountGroupId);

                entity.ToTable("tblAccountGroup", "msto");

                entity.Property(e => e.IntAccountGroupId)
                    .HasColumnName("intAccountGroupId")
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

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for every individual Client .Value of this filed will specify the clients whom this Account Group belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Account Group is active or not.");

                entity.Property(e => e.StrAccountGroupCode)
                    .IsRequired()
                    .HasColumnName("strAccountGroupCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Account Group.");

                entity.Property(e => e.StrAccountGroupName)
                    .IsRequired()
                    .HasColumnName("strAccountGroupName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will identify the name of individual Accounts Group.");
            });

            modelBuilder.Entity<TblAccountPayableRow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblAccountPayableRow", "fino");

                entity.Property(e => e.IntAccountReceivablePayableId).HasColumnName("intAccountReceivablePayableId");

                entity.Property(e => e.IntDeliveryId).HasColumnName("intDeliveryId");

                entity.Property(e => e.IntDeliveryRowId).HasColumnName("intDeliveryRowId");

                entity.Property(e => e.IntItemId).HasColumnName("intItemId");

                entity.Property(e => e.IntRowId)
                    .HasColumnName("intRowId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IntSalesOrderId).HasColumnName("intSalesOrderId");

                entity.Property(e => e.IntUom).HasColumnName("intUOM");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsFreeItem).HasColumnName("isFreeItem");

                entity.Property(e => e.NumDeliveryValue)
                    .HasColumnName("numDeliveryValue")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumItemPrice)
                    .HasColumnName("numItemPrice")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumNetValue)
                    .HasColumnName("numNetValue")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumQuantity)
                    .HasColumnName("numQuantity")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumTotalDiscountValue)
                    .HasColumnName("numTotalDiscountValue")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumTotalShipingValue)
                    .HasColumnName("numTotalShipingValue")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumTotalTax)
                    .HasColumnName("numTotalTax")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.StrDeliveryCode)
                    .IsRequired()
                    .HasColumnName("strDeliveryCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StrInvoiceCode)
                    .IsRequired()
                    .HasColumnName("strInvoiceCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StrItemCode)
                    .IsRequired()
                    .HasColumnName("strItemCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StrItemName)
                    .IsRequired()
                    .HasColumnName("strItemName")
                    .HasMaxLength(100);

                entity.Property(e => e.StrItemSalesCode)
                    .IsRequired()
                    .HasColumnName("strItemSalesCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StrItemSalesName)
                    .IsRequired()
                    .HasColumnName("strItemSalesName")
                    .HasMaxLength(300);

                entity.Property(e => e.StrSalesOrderCode)
                    .IsRequired()
                    .HasColumnName("strSalesOrderCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StrUom)
                    .IsRequired()
                    .HasColumnName("strUOM")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblAccountReceivablePayableHeader>(entity =>
            {
                entity.HasKey(e => e.IntAccountReceivablePayableId)
                    .HasName("PK_tblAccountReceivablePayable");

                entity.ToTable("tblAccountReceivablePayableHeader", "fino");

                entity.Property(e => e.IntAccountReceivablePayableId)
                    .HasColumnName("intAccountReceivablePayableId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.DteClearingDate)
                    .HasColumnName("dteClearingDate")
                    .HasColumnType("date")
                    .HasComment("Value of this field will  specify the  Transaction Clearing date.");

                entity.Property(e => e.DteDueDate)
                    .HasColumnName("dteDueDate")
                    .HasColumnType("date")
                    .HasComment("Value of this field will specify the remaining days of transaction.");

                entity.Property(e => e.DteLastActionDateTime)
                    .HasColumnName("dteLastActionDateTime")
                    .HasColumnType("datetime")
                    .HasComment("This field is used to keep record of every action's date & time in this table.");

                entity.Property(e => e.DteServerDateTime)
                    .HasColumnName("dteServerDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("This field is used to keep record of every action's server's date & time in this table. ");

                entity.Property(e => e.DteTransactionDate)
                    .HasColumnName("dteTransactionDate")
                    .HasColumnType("date")
                    .HasComment("Value of this field will  specify the  Transaction's  date.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntAdjustmentJournalId)
                    .HasColumnName("intAdjustmentJournalId")
                    .HasComment("An auto incremental identity field for Adjustment Journal. Value of this field will specify the respective Adjustement Journal.");

                entity.Property(e => e.IntBusinessAreaId)
                    .HasColumnName("intBusinessAreaId")
                    .HasComment("Identity field for Business Area. Value of this field will specify the respective  Business Area.");

                entity.Property(e => e.IntBusinessPartnerId)
                    .HasColumnName("intBusinessPartnerId")
                    .HasComment("Identity field for Business Partner. Value of this field will specify the respective Business Partner. ");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify respective Business Unit where the Account belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whome the Account belongs to.");

                entity.Property(e => e.IntPayTerm)
                    .HasColumnName("intPayTerm")
                    .HasComment("An auto incremental identity field for payTerm.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether the respective Account Receivable-Payable is active or not.");

                entity.Property(e => e.IsCleared)
                    .HasColumnName("isCleared")
                    .HasComment("Value of this field will specify wheather the transaction is clear or not.");

                entity.Property(e => e.IsReceivable)
                    .HasColumnName("isReceivable")
                    .HasComment("Value of this field will specify wheather the transaction amount is receivable or not. If Not it will be payable.");

                entity.Property(e => e.NumAmount)
                    .HasColumnName("numAmount")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("value of this field will specify the transection amount.");

                entity.Property(e => e.StrAdjustmentJournalCode)
                    .IsRequired()
                    .HasColumnName("strAdjustmentJournalCode")
                    .HasMaxLength(50)
                    .HasComment("Identity field for Adjustement Journal.Value of this field will specify the respective Adjustement Journal.");

                entity.Property(e => e.StrInvoiceCode)
                    .IsRequired()
                    .HasColumnName("strInvoiceCode")
                    .HasMaxLength(50)
                    .HasComment("A unique key field for individual Invoice.Value of this field will specify the respective Invoice Code.");

                entity.Property(e => e.StrNarration)
                    .IsRequired()
                    .HasColumnName("strNarration")
                    .HasMaxLength(500)
                    .HasComment("Value of this field will specify the transaction note.");
            });

            modelBuilder.Entity<TblAccountReceivableRow>(entity =>
            {
                entity.HasKey(e => e.IntRowId)
                    .HasName("PK_tblAccountReceivablePayableRow");

                entity.ToTable("tblAccountReceivableRow", "fino");

                entity.Property(e => e.IntRowId).HasColumnName("intRowId");

                entity.Property(e => e.IntAccountReceivablePayableId).HasColumnName("intAccountReceivablePayableId");

                entity.Property(e => e.IntDeliveryId).HasColumnName("intDeliveryId");

                entity.Property(e => e.IntDeliveryRowId).HasColumnName("intDeliveryRowId");

                entity.Property(e => e.IntItemId).HasColumnName("intItemId");

                entity.Property(e => e.IntSalesOrderId).HasColumnName("intSalesOrderId");

                entity.Property(e => e.IntUom).HasColumnName("intUOM");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsFreeItem).HasColumnName("isFreeItem");

                entity.Property(e => e.NumDeliveryValue)
                    .HasColumnName("numDeliveryValue")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumItemPrice)
                    .HasColumnName("numItemPrice")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumNetValue)
                    .HasColumnName("numNetValue")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumQuantity)
                    .HasColumnName("numQuantity")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumTotalDiscountValue)
                    .HasColumnName("numTotalDiscountValue")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumTotalShipingValue)
                    .HasColumnName("numTotalShipingValue")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumTotalTax)
                    .HasColumnName("numTotalTax")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.StrDeliveryCode)
                    .IsRequired()
                    .HasColumnName("strDeliveryCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StrInvoiceCode)
                    .IsRequired()
                    .HasColumnName("strInvoiceCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StrItemCode)
                    .IsRequired()
                    .HasColumnName("strItemCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StrItemName)
                    .IsRequired()
                    .HasColumnName("strItemName")
                    .HasMaxLength(100);

                entity.Property(e => e.StrItemSalesCode)
                    .IsRequired()
                    .HasColumnName("strItemSalesCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StrItemSalesName)
                    .IsRequired()
                    .HasColumnName("strItemSalesName")
                    .HasMaxLength(300);

                entity.Property(e => e.StrSalesOrderCode)
                    .IsRequired()
                    .HasColumnName("strSalesOrderCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StrUom)
                    .IsRequired()
                    .HasColumnName("strUOM")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblAccountingJournal>(entity =>
            {
                entity.HasKey(e => e.IntTrasactionId);

                entity.ToTable("tblAccountingJournal", "fino");

                entity.Property(e => e.IntTrasactionId)
                    .HasColumnName("intTrasactionId")
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

                entity.Property(e => e.DteTransactionDate)
                    .HasColumnName("dteTransactionDate")
                    .HasColumnType("date")
                    .HasComment("Value of this field will  specify the Journal's Transaction date.");

                entity.Property(e => e.IntAccountingJournalId)
                    .HasColumnName("intAccountingJournalId")
                    .HasComment("An Auto incremental identity field.");

                entity.Property(e => e.IntAccountingJournalTypeId)
                    .HasColumnName("intAccountingJournalTypeId")
                    .HasComment("Indentity value field for respective Accounting Journal Type.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntBusinessAreaId)
                    .HasColumnName("intBusinessAreaId")
                    .HasComment("An auto incremental Identity field.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the Accounting Journal belomgs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whome the Accounting Journal  belongs to.");

                entity.Property(e => e.IntGeneralLedgerId)
                    .HasColumnName("intGeneralLedgerId")
                    .HasComment("Identity field for General Ledger. Value of this field will specify the individual General Ledger of respective Account Journal.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Accounting Journal  is active or not.");

                entity.Property(e => e.NumAmount)
                    .HasColumnName("numAmount")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("value of this field will specify the transection amount.");

                entity.Property(e => e.StrAccountingJournalCode)
                    .IsRequired()
                    .HasColumnName("strAccountingJournalCode")
                    .HasMaxLength(50)
                    .HasComment("A unique field for identifying every individual Accounting Journal.");

                entity.Property(e => e.StrGeneralLedgerCode)
                    .IsRequired()
                    .HasColumnName("strGeneralLedgerCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual General Ledger.");

                entity.Property(e => e.StrGeneralLedgerName)
                    .IsRequired()
                    .HasColumnName("strGeneralLedgerName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective General Ledger.");

                entity.Property(e => e.StrNarration)
                    .IsRequired()
                    .HasColumnName("strNarration")
                    .HasMaxLength(500)
                    .HasComment("Value of this field will definr the Accounting Journal's Transaction Narration.");
            });

            modelBuilder.Entity<TblAccountingJournalCodeGenerator>(entity =>
            {
                entity.HasKey(e => e.IntAccountCodeGenerateId);

                entity.ToTable("tblAccountingJournalCodeGenerator", "fino");

                entity.Property(e => e.IntAccountCodeGenerateId).HasColumnName("intAccountCodeGenerateId");

                entity.Property(e => e.IntAccountingJournalTypeId)
                    .HasColumnName("intAccountingJournalTypeId")
                    .HasComment("An auto incremental indentity value field for respective Accounting Journal Type.");

                entity.Property(e => e.IntBusinessUintId)
                    .HasColumnName("intBusinessUintId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify the respective Busines Unit where the Accounting Journal Belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Accounting Journal belongs to.");

                entity.Property(e => e.IntCount).HasColumnName("intCount");

                entity.Property(e => e.IntMonth).HasColumnName("intMonth");

                entity.Property(e => e.IntYear).HasColumnName("intYear");

                entity.Property(e => e.StrAccountingJournalTypeName)
                    .IsRequired()
                    .HasColumnName("strAccountingJournalTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will identify the name of every  individual Accounting Journal Type.");
            });

            modelBuilder.Entity<TblAccountingJournalType>(entity =>
            {
                entity.HasKey(e => e.IntAccountingJournalTypeId);

                entity.ToTable("tblAccountingJournalType", "msto");

                entity.Property(e => e.IntAccountingJournalTypeId)
                    .HasColumnName("intAccountingJournalTypeId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.StrAccountingJournalTypeName)
                    .IsRequired()
                    .HasColumnName("strAccountingJournalTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will identify the name of every  individual Accounts Journal Type.");
            });

            modelBuilder.Entity<TblAccountingJournalTypeBusinessUnit>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblAccountingJournalTypeBusinessUnit", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

                entity.Property(e => e.DteLastActionDateTime)
                    .HasColumnName("dteLastActionDateTime")
                    .HasColumnType("datetime")
                    .HasComment("This field is used to keep record of every action's date & time in this table.");

                entity.Property(e => e.DteServerDateTime)
                    .HasColumnName("dteServerDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("This field is used to keep record of every action's server's date & time in this table. ");

                entity.Property(e => e.IntAccountingJournalTypeId)
                    .HasColumnName("intAccountingJournalTypeId")
                    .HasComment("Indentity value field for respective Accounting Journal Type.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the Accounting Journal Type belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whome the Accounting Journal Type belongs to.");

                entity.Property(e => e.IntMonthlyNumberLength)
                    .HasColumnName("intMonthlyNumberLength")
                    .HasDefaultValueSql("((5))")
                    .HasComment("Value of this field will specify the lenght of Month that should be used in the Account Journal Type's code convention.");

                entity.Property(e => e.IntYearlyNumberLength)
                    .HasColumnName("intYearlyNumberLength")
                    .HasDefaultValueSql("((7))")
                    .HasComment("Value of this field will specify the lenght of Yearthat should be used in the Account Journal Type's code convention.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item Attribute is active or not.");

                entity.Property(e => e.IsMonth)
                    .HasColumnName("isMonth")
                    .HasComment("Value of this field specifys whether the strPrefix convention of Account Journal Type contains year value or not.");

                entity.Property(e => e.IsMonthlyNumberChange)
                    .HasColumnName("isMonthlyNumberChange")
                    .HasComment("Value of this field will specify whether the Accoount Journal Type's code convention value changes/refreshes with monthly basis or not.");

                entity.Property(e => e.IsYear)
                    .HasColumnName("isYear")
                    .HasComment("Value of this field specifys whether the strPrefix convention of Account Journal Type contains month value or not.");

                entity.Property(e => e.StrPrefix)
                    .IsRequired()
                    .HasColumnName("strPrefix")
                    .HasMaxLength(5)
                    .HasComment("Value of this field will specify the Prefix structure for every individual Account Journal Type of Business Unit. User's can define this convention.");
            });

            modelBuilder.Entity<TblAccountingPostingType>(entity =>
            {
                entity.HasKey(e => e.IntAccountingPostingTypeId);

                entity.ToTable("tblAccountingPostingType", "msto");

                entity.Property(e => e.IntAccountingPostingTypeId)
                    .HasColumnName("intAccountingPostingTypeId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.StrAccountPostingTypeName)
                    .IsRequired()
                    .HasColumnName("strAccountPostingTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will identify the name of individual Account Posting Type.");
            });

            modelBuilder.Entity<TblAdjustmentJournalHeader>(entity =>
            {
                entity.HasKey(e => e.IntAdjustmentJournalId);

                entity.ToTable("tblAdjustmentJournalHeader", "fino");

                entity.Property(e => e.IntAdjustmentJournalId)
                    .HasColumnName("intAdjustmentJournalId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.DteJournalDate)
                    .HasColumnName("dteJournalDate")
                    .HasColumnType("date")
                    .HasComment("Value of this field will specify the respective Journal's Date.");

                entity.Property(e => e.DteLastActionDateTime)
                    .HasColumnName("dteLastActionDateTime")
                    .HasColumnType("datetime")
                    .HasComment("This field is used to keep record of every action's date & time in this table.");

                entity.Property(e => e.DteServerDateTime)
                    .HasColumnName("dteServerDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("This field is used to keep record of every action's server's date & time in this table. ");

                entity.Property(e => e.IntAccountingJournalTypeId)
                    .HasColumnName("intAccountingJournalTypeId")
                    .HasComment("Indentity value field for respective Accounting Journal Type.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntBusinessAreaId)
                    .HasColumnName("intBusinessAreaId")
                    .HasComment("Identity field for Business Area. Value of this field will specify the  Business Area Where the Adjustement Journal belongs to.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the Adjustement Journal belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whome the Adjustement Journal belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Adjustment Journal  is active or not.");

                entity.Property(e => e.IsDirectPosting)
                    .HasColumnName("isDirectPosting")
                    .HasComment("Value of this field will specify whether user can post directly from UI or not. This field's value will be false by default.");

                entity.Property(e => e.IsPosted)
                    .HasColumnName("isPosted")
                    .HasComment("Value of this field wil specifywhether  the rescpetive transaction is completed or not.This field's value will be False by default.");

                entity.Property(e => e.NumCreditAmount)
                    .HasColumnName("numCreditAmount")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of this field will specify the respective Adjustemnet Journal's  credit amount.");

                entity.Property(e => e.NumDebitAmount)
                    .HasColumnName("numDebitAmount")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of this field will specify the respective Adjustemnet Journal's  debit amount.");

                entity.Property(e => e.StrAdjustmentJournalCode)
                    .IsRequired()
                    .HasColumnName("strAdjustmentJournalCode")
                    .HasMaxLength(50)
                    .HasComment("Identity field for Adjustement Journal.Value of this field will specify the respective Adjustement Journal.");

                entity.Property(e => e.StrNarration)
                    .IsRequired()
                    .HasColumnName("strNarration")
                    .HasMaxLength(500)
                    .HasComment("Value of this field will specify the Adjustment Journal's transaction note.");
            });

            modelBuilder.Entity<TblAdjustmentJournalRow>(entity =>
            {
                entity.HasKey(e => e.IntRowId);

                entity.ToTable("tblAdjustmentJournalRow", "fino");

                entity.Property(e => e.IntRowId)
                    .HasColumnName("intRowId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.IntAdjustmentJournalId)
                    .HasColumnName("intAdjustmentJournalId")
                    .HasComment("An auto incremental identity field for Adjustment Journal. Value of this field will specify the respective Adjustement Journal.");

                entity.Property(e => e.IntGeneralLedgerId)
                    .HasColumnName("intGeneralLedgerId")
                    .HasComment("Identity field for General Ledger. Value of this field will specify the respective General Ledger of any individual Adjustement Journal.");

                entity.Property(e => e.NumAmount)
                    .HasColumnName("numAmount")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of this field will specify the respective transection amount.");

                entity.Property(e => e.StrAdjustmentJournalCode)
                    .IsRequired()
                    .HasColumnName("strAdjustmentJournalCode")
                    .HasMaxLength(50)
                    .HasComment("Identity field for Adjustement Journal.Value of this field will specify the respective Adjustement Journal.");

                entity.Property(e => e.StrGeneralLedgerName)
                    .IsRequired()
                    .HasColumnName("strGeneralLedgerName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective General Ledger.");

                entity.Property(e => e.StrNarration)
                    .IsRequired()
                    .HasColumnName("strNarration")
                    .HasMaxLength(500)
                    .HasComment("Value of this field will define the Accounting Journal Row's Narration.");
            });

            modelBuilder.Entity<TblAlternativeAndStandardReconGeneralLedger>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblAlternativeAndStandardReconGeneralLedger", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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

                entity.Property(e => e.IntAlternateGeneralLedgerId)
                    .HasColumnName("intAlternateGeneralLedgerId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the Ledger belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whome the Ledger belongs to.");

                entity.Property(e => e.IntGeneralLedgerId)
                    .HasColumnName("intGeneralLedgerId")
                    .HasComment("Identity field for General Ledger. Value of this field will specify the respective General Ledger of individual Alternative and Standard Recon General Ledger.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Business Partner is active or not.");
            });

            modelBuilder.Entity<TblBalanceCheckType>(entity =>
            {
                entity.HasKey(e => e.IntBalanceCheckTypeId);

                entity.ToTable("tblBalanceCheckType", "somo");

                entity.Property(e => e.IntBalanceCheckTypeId).HasColumnName("intBalanceCheckTypeId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.StrBalanceCheckName)
                    .IsRequired()
                    .HasColumnName("strBalanceCheckName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblBank>(entity =>
            {
                entity.HasKey(e => e.IntBankId);

                entity.ToTable("tblBank", "msto");

                entity.Property(e => e.IntBankId)
                    .HasColumnName("intBankID")
                    .HasComment("An auto incremential identity field for Bank.");

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

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Bank is active or not.");

                entity.Property(e => e.StrBankCode)
                    .IsRequired()
                    .HasColumnName("strBankCode")
                    .HasMaxLength(50)
                    .HasComment("A unique key field for every individual bank. Value of this field will specify the respective Bank.");

                entity.Property(e => e.StrBankName)
                    .IsRequired()
                    .HasColumnName("strBankName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the individual Bank Name.");
            });

            modelBuilder.Entity<TblBankAccount>(entity =>
            {
                entity.HasKey(e => e.IntBankAccountId);

                entity.ToTable("tblBankAccount", "msto");

                entity.Property(e => e.IntBankAccountId)
                    .HasColumnName("intBankAccountId")
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

                entity.Property(e => e.IntBankBranchId)
                    .HasColumnName("intBankBranchId")
                    .HasComment("Identity key field for every individual Branch of a respective Bank. Value of this field will specify the respective Branch of any Bank.");

                entity.Property(e => e.IntBankId)
                    .HasColumnName("intBankId")
                    .HasComment("Identity field for Bank. Value of this field will specify the respective Bank.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the Bank Account belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whom the Bank Account belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Bank Account is active or not.");

                entity.Property(e => e.StrBankAccountName)
                    .IsRequired()
                    .HasColumnName("strBankAccountName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective bank name.");

                entity.Property(e => e.StrBankAccountNo)
                    .IsRequired()
                    .HasColumnName("strBankAccountNo")
                    .HasMaxLength(100)
                    .HasComment("Identity key field for every individual bank account no. Value of this  field will specify the respective bank account number.");

                entity.Property(e => e.StrBankBranchName)
                    .IsRequired()
                    .HasColumnName("strBankBranchName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the individual Branch name of respective Bank.");

                entity.Property(e => e.StrBankName)
                    .IsRequired()
                    .HasColumnName("strBankName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective Bank.");
            });

            modelBuilder.Entity<TblBankBranch>(entity =>
            {
                entity.HasKey(e => e.IntBankBranchId);

                entity.ToTable("tblBankBranch", "msto");

                entity.Property(e => e.IntBankBranchId)
                    .HasColumnName("intBankBranchId")
                    .HasComment("An auto incremental identity field. Value of this field will specify the respective Branch of any Bank.");

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

                entity.Property(e => e.IntBankId)
                    .HasColumnName("intBankId")
                    .HasComment("Identity field for Bank. Value of this field will specify the respective Bank.");

                entity.Property(e => e.IntCountryId)
                    .HasColumnName("intCountryId")
                    .HasComment("A unique key field for every individual country. Value of this field will specify the respective country.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Branch is active or not.");

                entity.Property(e => e.StrBankBranchAddress)
                    .IsRequired()
                    .HasColumnName("strBankBranchAddress")
                    .HasMaxLength(300)
                    .HasComment("Value of this field will specify the respective Branch's address.");

                entity.Property(e => e.StrBankBranchCode)
                    .IsRequired()
                    .HasColumnName("strBankBranchCode")
                    .HasMaxLength(50)
                    .HasComment("A unique key field for every individual Bank's respective Branch. Value of this field will specify the respective Branch of any Bank.");

                entity.Property(e => e.StrBankBranchName)
                    .IsRequired()
                    .HasColumnName("strBankBranchName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the individual Branch name of respective Bank.");
            });

            modelBuilder.Entity<TblBankBranchBusinessUnit>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblBankBranchBusinessUnit", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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

                entity.Property(e => e.IntBankBranchId)
                    .HasColumnName("intBankBranchId")
                    .HasComment("Identity key field for every individual Branch of a respective Bank. Value of this field will specify the respective Branch of any Bank.");

                entity.Property(e => e.IntBankId)
                    .HasColumnName("intBankId")
                    .HasComment("Identity field for Bank. Value of this field will specify the respective Bank.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit.");

                entity.Property(e => e.IntClientid)
                    .HasColumnName("intClientid")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whom the Account belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Branch of Business Unit  is active or not.");

                entity.Property(e => e.StrBankBranchName)
                    .IsRequired()
                    .HasColumnName("strBankBranchName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the individual Branch name of any respective Bank.");

                entity.Property(e => e.StrBankName)
                    .IsRequired()
                    .HasColumnName("strBankName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective Bank Name");

                entity.Property(e => e.StrBusinessName)
                    .IsRequired()
                    .HasColumnName("strBusinessName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective Busisness Unit.");
            });

            modelBuilder.Entity<TblBankInstrumentType>(entity =>
            {
                entity.HasKey(e => e.IntInstrumentId);

                entity.ToTable("tblBankInstrumentType", "msto");

                entity.Property(e => e.IntInstrumentId)
                    .HasColumnName("intInstrumentID")
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

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Bank Intrument Type is active or not.");

                entity.Property(e => e.StrInstrumentName)
                    .IsRequired()
                    .HasColumnName("strInstrumentName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective Instrument Name like Check, Card, Cash etc.");
            });

            modelBuilder.Entity<TblBankJournalHeader>(entity =>
            {
                entity.HasKey(e => e.IntBankJournalId);

                entity.ToTable("tblBankJournalHeader", "fino");

                entity.Property(e => e.IntBankJournalId)
                    .HasColumnName("intBankJournalId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.DteInstrumentDate)
                    .HasColumnName("dteInstrumentDate")
                    .HasColumnType("date")
                    .HasComment("Value of this field will specify the Transaction Date.");

                entity.Property(e => e.DteLastActionDateTime)
                    .HasColumnName("dteLastActionDateTime")
                    .HasColumnType("datetime")
                    .HasComment("This field is used to keep record of every action's date & time in this table.");

                entity.Property(e => e.DteServerDateTime)
                    .HasColumnName("dteServerDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("This field is used to keep record of every action's server's date & time in this table. ");

                entity.Property(e => e.DteVoucherDate)
                    .HasColumnName("dteVoucherDate")
                    .HasColumnType("date")
                    .HasComment("Value of this field will specify the respective Voucher's Date.");

                entity.Property(e => e.IntAccountingJournalTypeId)
                    .HasColumnName("intAccountingJournalTypeId")
                    .HasComment("Indentity value field for respective Accounting Journal Type.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntBankAccountId)
                    .HasColumnName("intBankAccountId")
                    .HasComment("Identity field for individual Bank Account.");

                entity.Property(e => e.IntBankBranchId)
                    .HasColumnName("intBankBranchId")
                    .HasComment("An auto incremental identity field for individual Branch of respective Bank.");

                entity.Property(e => e.IntBankId)
                    .HasColumnName("intBankId")
                    .HasComment("An auto incremential identity field for Bank.");

                entity.Property(e => e.IntBusinessAreaId)
                    .HasColumnName("intBusinessAreaId")
                    .HasComment("Identity field for Business Area. Value of this field will specify the  Business Area Where the Bank Journal Header belongs to. ");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the Bank Journal Header belongs to. ");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whome the Bank Account belongs to.");

                entity.Property(e => e.IntGeneralLedgerId)
                    .HasColumnName("intGeneralLedgerId")
                    .HasComment("Identity field for General Ledger. Value of this field will specify the respective General Ledger for individual Bank Journal Header.");

                entity.Property(e => e.IntInstrumentTypeId)
                    .HasColumnName("intInstrumentTypeId")
                    .HasComment("An auto incremental identity field for individual Intrument Type.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Bank Journal header is active or not.");

                entity.Property(e => e.IsDirectPosting)
                    .HasColumnName("isDirectPosting")
                    .HasComment("Value of this field will specify whether user can post directly from UI or not. This field's value will be false by default.");

                entity.Property(e => e.IsPosted)
                    .HasColumnName("isPosted")
                    .HasComment("Value of this field wil specify whether the rescpetive transaction is completed or not.This field's value will be False by default.");

                entity.Property(e => e.NumAmount)
                    .HasColumnName("numAmount")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of this field will specify the respective transection amount.");

                entity.Property(e => e.StrBankAccountNumber)
                    .IsRequired()
                    .HasColumnName("strBankAccountNumber")
                    .HasMaxLength(100)
                    .HasComment("A unique key field for every individual Bank Account Number.");

                entity.Property(e => e.StrBankBranchName)
                    .IsRequired()
                    .HasColumnName("strBankBranchName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the individual Branch name of respective Bank.");

                entity.Property(e => e.StrBankJournalCode)
                    .IsRequired()
                    .HasColumnName("strBankJournalCode")
                    .HasMaxLength(50)
                    .HasComment("A unique key field for Bank Journal. Value of this field will specify the respective Bank Journal.");

                entity.Property(e => e.StrBankName)
                    .IsRequired()
                    .HasColumnName("strBankName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the individual Bank Name.");

                entity.Property(e => e.StrBusinessPartnerName)
                    .IsRequired()
                    .HasColumnName("strBusinessPartnerName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the name of individual business partner whom the bank journal belongs to.");

                entity.Property(e => e.StrInstrumentName)
                    .IsRequired()
                    .HasColumnName("strInstrumentName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective Instrument Name.");

                entity.Property(e => e.StrInstrumentNumber)
                    .IsRequired()
                    .HasColumnName("strInstrumentNumber")
                    .HasMaxLength(50)
                    .HasComment("Value of this field wil specify the respective Instrument Number.It can be autoo generated or manual input field.");

                entity.Property(e => e.StrNarration)
                    .IsRequired()
                    .HasColumnName("strNarration")
                    .HasMaxLength(500)
                    .HasComment("Value of this field will define the Bank Journal Header Narration.");
            });

            modelBuilder.Entity<TblBankJournalRow>(entity =>
            {
                entity.HasKey(e => e.IntRowId);

                entity.ToTable("tblBankJournalRow", "fino");

                entity.Property(e => e.IntRowId)
                    .HasColumnName("intRowId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.IntBankJournalId)
                    .HasColumnName("intBankJournalId")
                    .HasComment("Iidentity field for Bank Journal. Value of  this field will specify the respective Bank Journal.");

                entity.Property(e => e.IntGeneralLedgerId)
                    .HasColumnName("intGeneralLedgerId")
                    .HasComment("Identity field for General Ledger. Value of this field will specify the respective General Ledger for individual Bank Journal Row.");

                entity.Property(e => e.NumAmount)
                    .HasColumnName("numAmount")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("value of this field will specify the transection amount.");

                entity.Property(e => e.StrBankJournalCode)
                    .IsRequired()
                    .HasColumnName("strBankJournalCode")
                    .HasMaxLength(50)
                    .HasComment("A unique key field for Bank Journal. Value of this field will specify the respective Bank Journal.");

                entity.Property(e => e.StrGeneralLedgerCode)
                    .IsRequired()
                    .HasColumnName("strGeneralLedgerCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for every individual General Ledger.");

                entity.Property(e => e.StrGeneralLedgerName)
                    .IsRequired()
                    .HasColumnName("strGeneralLedgerName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective General Ledger.");
            });

            modelBuilder.Entity<TblBusinessArea>(entity =>
            {
                entity.HasKey(e => e.IntBusinessAreaId);

                entity.ToTable("tblBusinessArea", "msto");

                entity.Property(e => e.IntBusinessAreaId)
                    .HasColumnName("intBusinessAreaId")
                    .HasComment("An auto incremental Identity field.");

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
                    .HasComment("Value of this field will specify the Business Unit Where the Business Area belongs. ");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Value of this field will identify the Registered Clients whom the business area belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Business Area is active or not.");

                entity.Property(e => e.StrBusinessAreaCode)
                    .IsRequired()
                    .HasColumnName("strBusinessAreaCode")
                    .HasMaxLength(50)
                    .HasComment("A unique key field for individual Business Area.");

                entity.Property(e => e.StrBusinessAreaName)
                    .IsRequired()
                    .HasColumnName("strBusinessAreaName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will identify the name of individual Business Area.");
            });

            modelBuilder.Entity<TblBusinessPartner>(entity =>
            {
                entity.HasKey(e => e.IntBusinessPartnerId);

                entity.ToTable("tblBusinessPartner", "msto");

                entity.Property(e => e.IntBusinessPartnerId)
                    .HasColumnName("intBusinessPartnerId")
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
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Business Partner is active or not.");

                entity.Property(e => e.StrBusinessPartnerAddress)
                    .IsRequired()
                    .HasColumnName("strBusinessPartnerAddress")
                    .HasMaxLength(300)
                    .HasComment("Value of this field will specify the address of individual business partner");

                entity.Property(e => e.StrBusinessPartnerCode)
                    .IsRequired()
                    .HasColumnName("strBusinessPartnerCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Business Partner.");

                entity.Property(e => e.StrBusinessPartnerName)
                    .IsRequired()
                    .HasColumnName("strBusinessPartnerName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the name of individual business partner");

                entity.Property(e => e.StrContactNumber)
                    .IsRequired()
                    .HasColumnName("strContactNumber")
                    .HasMaxLength(20)
                    .HasComment("Value of this field will specify the contact number of individual business partner");

                entity.Property(e => e.StrEmail)
                    .IsRequired()
                    .HasColumnName("strEmail")
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'Undefined')")
                    .HasComment("Value of this field will specify the email address of individual business partner");
            });

            modelBuilder.Entity<TblBusinessPartnerDistributionChannel>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblBusinessPartnerDistributionChannel", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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

                entity.Property(e => e.IntBusinessPartnerId)
                    .HasColumnName("intBusinessPartnerId")
                    .HasComment("Identity field for Business Partner. Value of this field will specify the individual Business Partner. ");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify the Business Unit where the Distribution Channel belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Distribution channel belongs to.");

                entity.Property(e => e.IntDistributionChannelId)
                    .HasColumnName("intDistributionChannelId")
                    .HasComment("Identity field for Distribution Channel. Value of this field will specify the individual Distribution Channel.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Business Partner Distribution Channel  is active or not.");
            });

            modelBuilder.Entity<TblBusinessPartnerGeneralLedger>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblBusinessPartnerGeneralLedger", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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

                entity.Property(e => e.IntBusinessPartnerId)
                    .HasColumnName("intBusinessPartnerId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the Business Partner General Ledger belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whom the Business Partner General Ledger belongs to.");

                entity.Property(e => e.IntGeneralLedgerId)
                    .HasColumnName("intGeneralLedgerId")
                    .HasComment("Identity field for General Ledger. Value of this field will specify the individual General Ledger of respective Business Partner.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Business Partner General Ledger is active or not.");
            });

            modelBuilder.Entity<TblBusinessPartnerLedger>(entity =>
            {
                entity.HasKey(e => e.IntTransactionId);

                entity.ToTable("tblBusinessPartnerLedger", "fino");

                entity.Property(e => e.IntTransactionId)
                    .HasColumnName("intTransactionId")
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

                entity.Property(e => e.DteTransactionDate)
                    .HasColumnName("dteTransactionDate")
                    .HasColumnType("date")
                    .HasComment("Value of this field will  specify the Ledger's Transaction date.");

                entity.Property(e => e.IntAccountingJournalId)
                    .HasColumnName("intAccountingJournalId")
                    .HasComment("Idetity field for Accounting Journal. Value of this field will specify the respective Accouting Journal where the Business Partner Ledger belongs to.");

                entity.Property(e => e.IntAccountingJournalTypeId)
                    .HasColumnName("intAccountingJournalTypeId")
                    .HasComment("Indentity value field for respective Accounting Journal Type.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntBusinessAreaId)
                    .HasColumnName("intBusinessAreaId")
                    .HasComment("Identity field for Business Area. Value of this field will specify the  Business Area Where the Business Partner Ledger belongs to.");

                entity.Property(e => e.IntBusinessPartnerId)
                    .HasColumnName("intBusinessPartnerId")
                    .HasComment("Identity field for Business Partner. Value of this field will specify the individual Business Partner. ");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the Business Partner Ledger Belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whom the Partner Ledger belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Business Partner Ledger is active or not.");

                entity.Property(e => e.NumAmount)
                    .HasColumnName("numAmount")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("value of this field will specify the Patner Ledger account.");

                entity.Property(e => e.NumRunningAmount)
                    .HasColumnName("numRunningAmount")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("value of this field will specify the Partne Ledger's running amount.");

                entity.Property(e => e.StrAccountingJournalTypeName)
                    .IsRequired()
                    .HasColumnName("strAccountingJournalTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will identify the name of respective Accounts Journal Type.");

                entity.Property(e => e.StrNarration)
                    .IsRequired()
                    .HasColumnName("strNarration")
                    .HasMaxLength(500)
                    .HasComment("Value of this field will define the Partner Ledger's transaction Narration.");
            });

            modelBuilder.Entity<TblBusinessPartnerPurchase>(entity =>
            {
                entity.HasKey(e => e.IntConfigId)
                    .HasName("PK_tblBusinessPartnerWarehousePurchase");

                entity.ToTable("tblBusinessPartnerPurchase", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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

                entity.Property(e => e.IntBusinessAreaId).HasColumnName("intBusinessAreaId");

                entity.Property(e => e.IntBusinessPartnerId)
                    .HasColumnName("intBusinessPartnerId")
                    .HasComment("Identity field for Business Partner. Value of this field will specify the individual Business Partner. ");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit. ");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the warehouse belongs to.");

                entity.Property(e => e.IntPurchaseOrganizationId)
                    .HasColumnName("intPurchaseOrganizationId")
                    .HasComment("Identity field for Purchase Organization. Value of this field will specify individual Purchase Organization where the purchase warehouse belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Business Partner Warehouse Purshase is active or not.");

                entity.Property(e => e.NumCreditLimit)
                    .HasColumnName("numCreditLimit")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumLedgerBalance)
                    .HasColumnName("numLedgerBalance")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumUnbilledAmount)
                    .HasColumnName("numUnbilledAmount")
                    .HasColumnType("numeric(18, 6)");
            });

            modelBuilder.Entity<TblBusinessPartnerSales>(entity =>
            {
                entity.HasKey(e => e.IntConfigId)
                    .HasName("PK_tblBusinessPartnerWarehouseSales");

                entity.ToTable("tblBusinessPartnerSales", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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

                entity.Property(e => e.IntBalanceCheckTypeId)
                    .HasColumnName("intBalanceCheckTypeId")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IntBusinessAreaId).HasColumnName("intBusinessAreaId");

                entity.Property(e => e.IntBusinessPartnerId)
                    .HasColumnName("intBusinessPartnerId")
                    .HasComment("Identity field for Business Partner. Value of this field will specify the individual Business Partner. ");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit. ");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the warehouse belongs to.");

                entity.Property(e => e.IntSalesOrganizationId)
                    .HasColumnName("intSalesOrganizationId")
                    .HasComment("Identity field for Sales Organizarion. Value of this field will specify the Sales Organizarion. ");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Business Partner Warehouse Sales is active or not.");

                entity.Property(e => e.NumCreditLimit)
                    .HasColumnName("numCreditLimit")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumLedgerBalance)
                    .HasColumnName("numLedgerBalance")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumUnbilledAmount)
                    .HasColumnName("numUnbilledAmount")
                    .HasColumnType("numeric(18, 6)");
            });

            modelBuilder.Entity<TblBusinessPartnerShipPoint>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblBusinessPartnerShipPoint", "somo");

                entity.Property(e => e.IntConfigId).HasColumnName("intConfigId");

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

                entity.Property(e => e.IntBusinessPartnerId).HasColumnName("intBusinessPartnerId");

                entity.Property(e => e.IntBusinessUnitId).HasColumnName("intBusinessUnitId");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IntShipPointId).HasColumnName("intShipPointId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Warehouse is active or not.");

                entity.Property(e => e.NumDistanceKm)
                    .HasColumnName("numDistanceKM")
                    .HasColumnType("numeric(18, 6)");
            });

            modelBuilder.Entity<TblBusinessPartnerTerritory>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblBusinessPartnerTerritory", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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

                entity.Property(e => e.IntBusinessPartnerId)
                    .HasColumnName("intBusinessPartnerId")
                    .HasComment("Identity field for Business Partner. Value of this field will specify the individual Business Partner whom the Territory belongs to.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify the respective Business Unit.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Territory belongs to.");

                entity.Property(e => e.IntTerritoryId)
                    .HasColumnName("intTerritoryId")
                    .HasComment("Identity field for Territory. Value of this field will specify the individual Territory. ");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Business Partner is active or not.");
            });

            modelBuilder.Entity<TblBusinessPartnerZone>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblBusinessPartnerZone", "somo");

                entity.Property(e => e.IntConfigId).HasColumnName("intConfigId");

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

                entity.Property(e => e.IntBusinessPartnerId).HasColumnName("intBusinessPartnerId");

                entity.Property(e => e.IntBusinessUnitId).HasColumnName("intBusinessUnitId");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IntTransportZoneId).HasColumnName("intTransportZoneId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Currency Conversion is active or not.");
            });

            modelBuilder.Entity<TblBusinessUnit>(entity =>
            {
                entity.HasKey(e => e.IntBusinessUnitId);

                entity.ToTable("tblBusinessUnit", "msto");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
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

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Indentity field for every individual Client. Value of this filed will specify the clients whom this Business Unit belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Business Unit is active or not.");

                entity.Property(e => e.StrBusinessUnitAddress)
                    .IsRequired()
                    .HasColumnName("strBusinessUnitAddress")
                    .HasMaxLength(300)
                    .HasComment("Value of this field will store the address of individual business unit of where it is situated.");

                entity.Property(e => e.StrBusinessUnitCode)
                    .IsRequired()
                    .HasColumnName("strBusinessUnitCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Business Unit.");

                entity.Property(e => e.StrBusinessUnitName)
                    .IsRequired()
                    .HasColumnName("strBusinessUnitName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will define the name of individual business units.");
            });

            modelBuilder.Entity<TblBusinessUnitCurrency>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblBusinessUnitCurrency", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the Business Unit Currency belongs to.");

                entity.Property(e => e.IntCurrencyId)
                    .HasColumnName("intCurrencyId")
                    .HasComment("Identity field for Individual lCurrency. Value of this field will specify the respective Currency.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Business Unit Currency is active or not.");

                entity.Property(e => e.IsBaseCurrency)
                    .HasColumnName("isBaseCurrency")
                    .HasComment("Value of this field will specify whether the Currency is base or not.");
            });

            modelBuilder.Entity<TblBusinessUnitCurrencyConversion>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblBusinessUnitCurrencyConversion", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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

                entity.Property(e => e.IntAlternateCurrencyId)
                    .HasColumnName("intAlternateCurrencyId")
                    .HasComment("A unique key field for Base Currency. Value of this field will specify the respective Alternate Currency.");

                entity.Property(e => e.IntBaseCurrencyId)
                    .HasColumnName("intBaseCurrencyId")
                    .HasComment("A unique key field for Base Currency. Value of this field will specify the respective Base Currency.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the conversion rate belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Currency Conversion is active or not.");

                entity.Property(e => e.NumConversionRate)
                    .HasColumnName("numConversionRate")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of the field will be used to convert the individual Conversion Rate to get the required Converted Currency");
            });

            modelBuilder.Entity<TblBusinessUnitSalesOrganizationIncoterms>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblBusinessUnitSalesOrganizationIncoterms", "somo");

                entity.Property(e => e.IntConfigId).HasColumnName("intConfigId");

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

                entity.Property(e => e.IntBusinessUintId).HasColumnName("intBusinessUintId");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IntIncotermsId).HasColumnName("intIncotermsId");

                entity.Property(e => e.IntSalesOrganizationId).HasColumnName("intSalesOrganizationId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.StrBusinessUnitName)
                    .IsRequired()
                    .HasColumnName("strBusinessUnitName")
                    .HasMaxLength(100);

                entity.Property(e => e.StrIncotermsName)
                    .IsRequired()
                    .HasColumnName("strIncotermsName")
                    .HasMaxLength(100);

                entity.Property(e => e.StrSalesOrganizationName)
                    .IsRequired()
                    .HasColumnName("strSalesOrganizationName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblBusniessUnitGeneralLedger>(entity =>
            {
                entity.HasKey(e => e.IntAutoId);

                entity.ToTable("tblBusniessUnitGeneralLedger", "cnfo");

                entity.Property(e => e.IntAutoId)
                    .HasColumnName("intAutoId")
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
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the General Ledger belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whome the General Ledger belongs to.");

                entity.Property(e => e.IntGeneralLedgerId)
                    .HasColumnName("intGeneralLedgerId")
                    .HasComment("Identity field for General Ledger. Value of this field will specify the respective General Ledger of individual Business Unit.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Businss Unit General Ledger is active or not.");

                entity.Property(e => e.NumCurrentBalance)
                    .HasColumnName("numCurrentBalance")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of this field will specify the value of the general ledger's current balance amount.");
            });

            modelBuilder.Entity<TblCashJournalHeader>(entity =>
            {
                entity.HasKey(e => e.IntCashJournalId);

                entity.ToTable("tblCashJournalHeader", "fino");

                entity.Property(e => e.IntCashJournalId)
                    .HasColumnName("intCashJournalId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.DteJournalDate)
                    .HasColumnName("dteJournalDate")
                    .HasColumnType("date")
                    .HasComment("Value of this field will specify the respective Journal's Date.");

                entity.Property(e => e.DteLastActionDateTime)
                    .HasColumnName("dteLastActionDateTime")
                    .HasColumnType("datetime")
                    .HasComment("This field is used to keep record of every action's date & time in this table.");

                entity.Property(e => e.DteServerDateTime)
                    .HasColumnName("dteServerDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("This field is used to keep record of every action's server's date & time in this table. ");

                entity.Property(e => e.IntAccountingJournalTypeId)
                    .HasColumnName("intAccountingJournalTypeId")
                    .HasComment("Indentity value field for respective Accounting Journal Type.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntBusinessAreaId)
                    .HasColumnName("intBusinessAreaId")
                    .HasComment("An auto incremental Identity field.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the Cash Journal Header ");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whome the Cash Journal Header belongs to.");

                entity.Property(e => e.IntGeneralLedgerId)
                    .HasColumnName("intGeneralLedgerId")
                    .HasComment("Identity field for General Ledger. Value of this field will specify the respective General Ledger for respective Cash Journal Header.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether the repective Cash Journal Header is active or not.");

                entity.Property(e => e.IsDirectPosting)
                    .HasColumnName("isDirectPosting")
                    .HasComment("Value of this field will specify whether user can post directly from UI or not. This field's value will be false by default.");

                entity.Property(e => e.IsPosted)
                    .HasColumnName("isPosted")
                    .HasComment("Value of this field wil specifywhether  the rescpetive transaction is completed or not.This field's value will be False by default.");

                entity.Property(e => e.NumAmount)
                    .HasColumnName("numAmount")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("value of this field will specify the transection account.");

                entity.Property(e => e.StrBusinessPartnerName)
                    .IsRequired()
                    .HasColumnName("strBusinessPartnerName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the name of individual business partner");

                entity.Property(e => e.StrCashJournalCode)
                    .IsRequired()
                    .HasColumnName("strCashJournalCode")
                    .HasMaxLength(50)
                    .HasComment("A unique key field for identifing every individual cash journal heading.");

                entity.Property(e => e.StrNarration)
                    .IsRequired()
                    .HasColumnName("strNarration")
                    .HasMaxLength(500)
                    .HasComment("Value of this field will define the Accounting Journal Header Narration.");
            });

            modelBuilder.Entity<TblCashJournalRow>(entity =>
            {
                entity.HasKey(e => e.IntRowId);

                entity.ToTable("tblCashJournalRow", "fino");

                entity.Property(e => e.IntRowId)
                    .HasColumnName("intRowId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.IntCashJournalId)
                    .HasColumnName("intCashJournalId")
                    .HasComment("Identity field  for Cash Journal. Value of this field will specify the respective Cash Journal where the Cash Journal Row belongs to.");

                entity.Property(e => e.IntGeneralLedgerId)
                    .HasColumnName("intGeneralLedgerId")
                    .HasComment("Identity field for General Ledger. Value of this field will specify the individual General Ledger of respective Cash Journal Header.");

                entity.Property(e => e.NumAmount)
                    .HasColumnName("numAmount")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("value of this field will specify the transection account.");

                entity.Property(e => e.StrCashJournalCode)
                    .IsRequired()
                    .HasColumnName("strCashJournalCode")
                    .HasMaxLength(50)
                    .HasComment("A unique key field for identifing the respective  cash journal.");

                entity.Property(e => e.StrGeneralLedgerCode)
                    .IsRequired()
                    .HasColumnName("strGeneralLedgerCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying the respective General Ledger.");

                entity.Property(e => e.StrGeneralLedgerName)
                    .IsRequired()
                    .HasColumnName("strGeneralLedgerName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective General Ledger.");

                entity.Property(e => e.StrNarration)
                    .IsRequired()
                    .HasColumnName("strNarration")
                    .HasMaxLength(500)
                    .HasComment("Value of this field will define the Cash Journal Row's Narration.");
            });

            modelBuilder.Entity<TblClient>(entity =>
            {
                entity.HasKey(e => e.IntClientId)
                    .HasName("PK_tblClient_1");

                entity.ToTable("tblClient", "msto");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
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

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Client is active or not.");

                entity.Property(e => e.StrClientAddress)
                    .IsRequired()
                    .HasColumnName("strClientAddress")
                    .HasMaxLength(300)
                    .HasComment("Value of this field will specify the address of individual clients.");

                entity.Property(e => e.StrClientCode)
                    .IsRequired()
                    .HasColumnName("strClientCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Client. ");

                entity.Property(e => e.StrClientName)
                    .IsRequired()
                    .HasColumnName("strClientName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the name of individual Client.");
            });

            modelBuilder.Entity<TblCountry>(entity =>
            {
                entity.HasKey(e => e.IntCountryId);

                entity.ToTable("tblCountry", "msto");

                entity.Property(e => e.IntCountryId)
                    .HasColumnName("intCountryId")
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

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Country belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Country is active or not.");

                entity.Property(e => e.StrCountryCode)
                    .IsRequired()
                    .HasColumnName("strCountryCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Country. ");

                entity.Property(e => e.StrCountryName)
                    .IsRequired()
                    .HasColumnName("strCountryName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the name of individual Country.");
            });

            modelBuilder.Entity<TblCurrency>(entity =>
            {
                entity.HasKey(e => e.IntCurrencyId);

                entity.ToTable("tblCurrency", "msto");

                entity.Property(e => e.IntCurrencyId)
                    .HasColumnName("intCurrencyId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this currency is active or not.");

                entity.Property(e => e.StrCurrencyCode)
                    .IsRequired()
                    .HasColumnName("strCurrencyCode")
                    .HasMaxLength(50)
                    .HasComment("A unique key field for every individual currency.");

                entity.Property(e => e.StrCurrencyName)
                    .IsRequired()
                    .HasColumnName("strCurrencyName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective Currency Name.");
            });

            modelBuilder.Entity<TblDeliveryRoute>(entity =>
            {
                entity.HasKey(e => e.IntDeliveryRouteId);

                entity.ToTable("tblDeliveryRoute", "somo");

                entity.Property(e => e.IntDeliveryRouteId).HasColumnName("intDeliveryRouteId");

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

                entity.Property(e => e.IntBusinessUnitId).HasColumnName("intBusinessUnitId");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Client is active or not.");

                entity.Property(e => e.StrDeliverRouteName)
                    .IsRequired()
                    .HasColumnName("strDeliverRouteName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblDeliveryType>(entity =>
            {
                entity.HasKey(e => e.IntDeliveryTypeId);

                entity.ToTable("tblDeliveryType", "somo");

                entity.Property(e => e.IntDeliveryTypeId)
                    .HasColumnName("intDeliveryTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StrDeliveryTypeName)
                    .IsRequired()
                    .HasColumnName("strDeliveryTypeName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblDepreciationType>(entity =>
            {
                entity.HasKey(e => e.IntDepreciationId);

                entity.ToTable("tblDepreciationType", "msto");

                entity.Property(e => e.IntDepreciationId)
                    .HasColumnName("intDepreciationId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.StrDepreciationName)
                    .IsRequired()
                    .HasColumnName("strDepreciationName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective Depriciation Name");
            });

            modelBuilder.Entity<TblDistributionChannel>(entity =>
            {
                entity.HasKey(e => e.IntDistributionChannelId);

                entity.ToTable("tblDistributionChannel", "msto");

                entity.Property(e => e.IntDistributionChannelId)
                    .HasColumnName("intDistributionChannelId")
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

                entity.Property(e => e.IntBusinessAreaId)
                    .HasColumnName("intBusinessAreaId")
                    .HasComment("Identity field for Business Area. Value of this field will specify the  Business Area Where the Distribution Channel belongs to.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify the  Business Unit  Where the Distribution Channel belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whom the Distribution Channel  belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Distribution Channel  is active or not.");

                entity.Property(e => e.StrDistributionChannelCode)
                    .IsRequired()
                    .HasColumnName("strDistributionChannelCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Distribution Channnel.");

                entity.Property(e => e.StrDistributionChannelName)
                    .IsRequired()
                    .HasColumnName("strDistributionChannelName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the name of individual Distribution Channel ");
            });

            modelBuilder.Entity<TblDistrict>(entity =>
            {
                entity.HasKey(e => e.IntDistrictId);

                entity.ToTable("tblDistrict", "msto");

                entity.Property(e => e.IntDistrictId)
                    .HasColumnName("intDistrictId")
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

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients.");

                entity.Property(e => e.IntCountryId)
                    .HasColumnName("intCountryId")
                    .HasComment("A unique key field for every individual country. Value of this field will specify the respective country where the District belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this District is active or not.");

                entity.Property(e => e.StrDistrictCode)
                    .IsRequired()
                    .HasColumnName("strDistrictCode")
                    .HasMaxLength(50)
                    .HasComment("An unique key field for District. Value of this field will specify the respective District.");

                entity.Property(e => e.StrDistrictName)
                    .IsRequired()
                    .HasColumnName("strDistrictName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify every individual District's name.");
            });

            modelBuilder.Entity<TblDivision>(entity =>
            {
                entity.HasKey(e => e.IntDivisionId);

                entity.ToTable("tblDivision", "msto");

                entity.Property(e => e.IntDivisionId).HasColumnName("intDivisionID");

                entity.Property(e => e.IntCountryId).HasColumnName("intCountryId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.StrCountryName)
                    .IsRequired()
                    .HasColumnName("strCountryName")
                    .HasMaxLength(100);

                entity.Property(e => e.StrDivition)
                    .IsRequired()
                    .HasColumnName("strDivition")
                    .HasMaxLength(100);

                entity.Property(e => e.StrDivitionBanglaName)
                    .IsRequired()
                    .HasColumnName("strDivitionBanglaName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblGeneralLedger>(entity =>
            {
                entity.HasKey(e => e.IntGeneralLedgerId);

                entity.ToTable("tblGeneralLedger", "msto");

                entity.Property(e => e.IntGeneralLedgerId)
                    .HasColumnName("intGeneralLedgerId")
                    .HasComment("An Auto incremental identity field for General Ledger.");

                entity.Property(e => e.DteLastActionDateTime)
                    .HasColumnName("dteLastActionDateTime")
                    .HasColumnType("datetime")
                    .HasComment("This field is used to keep record of every action's date & time in this table.");

                entity.Property(e => e.DteServerDateTime)
                    .HasColumnName("dteServerDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("This field is used to keep record of every action's server's date & time in this table. ");

                entity.Property(e => e.IntAccountCategoryId)
                    .HasColumnName("intAccountCategoryId")
                    .HasComment("Identiy field for Account Category. value of this field wil specify the Account Category where the  General Ledger belongs to.");

                entity.Property(e => e.IntAccountClassId)
                    .HasColumnName("intAccountClassId")
                    .HasComment("Identity field for Account Class. Value of this field will specify the Account Class where the  General Ledger belongs to.");

                entity.Property(e => e.IntAccountGroupId)
                    .HasColumnName("intAccountGroupId")
                    .HasComment("Identity field for Account Group. Value of this field will specify the Account Group where the General Ledger belongs to.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whome the Account/General Ledger belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item Attribute is active or not.");

                entity.Property(e => e.StrGeneralLedgerCode)
                    .IsRequired()
                    .HasColumnName("strGeneralLedgerCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual General Ledger.");

                entity.Property(e => e.StrGeneralLedgerName)
                    .IsRequired()
                    .HasColumnName("strGeneralLedgerName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective General Ledger.");
            });

            modelBuilder.Entity<TblIncoTerms>(entity =>
            {
                entity.HasKey(e => e.IntIncotermsId)
                    .HasName("PK_tblIncoterms");

                entity.ToTable("tblIncoTerms", "somo");

                entity.Property(e => e.IntIncotermsId).HasColumnName("intIncotermsId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StrIncotermsCode)
                    .IsRequired()
                    .HasColumnName("strIncotermsCode")
                    .HasMaxLength(100);

                entity.Property(e => e.StrIncotermsName)
                    .IsRequired()
                    .HasColumnName("strIncotermsName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblItem>(entity =>
            {
                entity.HasKey(e => e.IntItemId);

                entity.ToTable("tblItem", "msto");

                entity.Property(e => e.IntItemId)
                    .HasColumnName("intItemId")
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
                    .HasComment("Identity field for Business Unit. Value of this field will specify the Business Unit Where the Item belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Item is belongs to.");

                entity.Property(e => e.IntItemCategoryId)
                    .HasColumnName("intItemCategoryId")
                    .HasComment("Identity field for Item Category. Value of this field will specify the category of every individual Item.");

                entity.Property(e => e.IntItemMasterId)
                    .HasColumnName("intItemMasterId")
                    .HasComment("Identity field for Item Master.Value of this field will specify the Item Master of every individual Item.");

                entity.Property(e => e.IntItemSubCategoryId)
                    .HasColumnName("intItemSubCategoryId")
                    .HasComment("Identity field for Item Sub-Category. Value of this field will specify the Sub-category of every individual Item.");

                entity.Property(e => e.IntItemTypeId)
                    .HasColumnName("intItemTypeId")
                    .HasComment("Identity field for Item Type. Value of this field will specify the types of every individual Item.");

                entity.Property(e => e.IntUomid)
                    .HasColumnName("intUOMId")
                    .HasComment("Identity field for Unit of Measurement. ");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item  is active or not.");

                entity.Property(e => e.NumGrossWeightKg)
                    .HasColumnName("numGrossWeightKg")
                    .HasColumnType("numeric(18, 6)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Gross Weight Field in KG.");

                entity.Property(e => e.NumNetWeightKg)
                    .HasColumnName("numNetWeightKg")
                    .HasColumnType("numeric(18, 6)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Net Weight Field in KG.");

                entity.Property(e => e.StrItemCategoryName)
                    .IsRequired()
                    .HasColumnName("strItemCategoryName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Item Category.");

                entity.Property(e => e.StrItemCode)
                    .IsRequired()
                    .HasColumnName("strItemCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Item.");

                entity.Property(e => e.StrItemName)
                    .IsRequired()
                    .HasColumnName("strItemName")
                    .HasMaxLength(200)
                    .HasComment("Value of this field will specify the name of individual Item.");

                entity.Property(e => e.StrItemSubCategoryName)
                    .IsRequired()
                    .HasColumnName("strItemSubCategoryName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Item Sub-Category.");

                entity.Property(e => e.StrItemTypeName)
                    .IsRequired()
                    .HasColumnName("strItemTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Type of individual Item.");

                entity.Property(e => e.StrUomname)
                    .IsRequired()
                    .HasColumnName("strUOMName")
                    .HasMaxLength(50)
                    .HasComment("Title of Unit of Measurement.");
            });

            modelBuilder.Entity<TblItemAttribute>(entity =>
            {
                entity.HasKey(e => e.IntItemAttributeId);

                entity.ToTable("tblItemAttribute", "msto");

                entity.Property(e => e.IntItemAttributeId)
                    .HasColumnName("intItemAttributeId")
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
                    .HasComment("Identity field for Business Unit. Value of this field will specify the Business Unit Where the Item Attribute belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Item Attribute belongs to.");

                entity.Property(e => e.IntItemAttributeUom)
                    .HasColumnName("intItemAttributeUOM")
                    .HasComment("Identity field for Item Attribute UOM. Value of this field will specify the unit of measurement of every individual Item attribute.");

                entity.Property(e => e.IntItemCategoryId)
                    .HasColumnName("intItemCategoryId")
                    .HasComment("Identity field for Item Category. Value of this field will specify the category of every individual Item.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item Attribute  is active or not.");

                entity.Property(e => e.StrItemAttributeName)
                    .IsRequired()
                    .HasColumnName("strItemAttributeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Item Attribute.");
            });

            modelBuilder.Entity<TblItemAttributeConfig>(entity =>
            {
                entity.HasKey(e => e.IntConfigId)
                    .HasName("PK_tblItemAttribute");

                entity.ToTable("tblItemAttributeConfig", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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

                entity.Property(e => e.IntAttributeId)
                    .HasColumnName("intAttributeId")
                    .HasComment("Identity field for Item Attribute. Value of this field will specify respective Item Attribute. ");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the Item Attrinute Configuration belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients.");

                entity.Property(e => e.IntItemMasterId)
                    .HasColumnName("intItemMasterId")
                    .HasComment("Identity field for Item. Value of this field will specify individual Item for which the respective Atrribute configuration belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item Attribute is active or not.");

                entity.Property(e => e.StrAttributeName)
                    .IsRequired()
                    .HasColumnName("strAttributeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Item Attribute's name.");

                entity.Property(e => e.StrAttributeUom)
                    .IsRequired()
                    .HasColumnName("strAttributeUOM")
                    .HasMaxLength(50)
                    .HasComment("Value of this field will specify the Unit of Measurement of individual Item Attribute.");
            });

            modelBuilder.Entity<TblItemCategory>(entity =>
            {
                entity.HasKey(e => e.IntItemCategoryId);

                entity.ToTable("tblItemCategory", "msto");

                entity.Property(e => e.IntItemCategoryId)
                    .HasColumnName("intItemCategoryId")
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
                    .HasComment("Value of this field will specify the Business Unit Where the Item Category belongs to. ");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients Item Category belongs to.");

                entity.Property(e => e.IntItemTypeId)
                    .HasColumnName("intItemTypeId")
                    .HasComment("Identity field for Item Type. Value of this field will specify the types of every individual Item.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item Category is active or not.");

                entity.Property(e => e.StrItemCategoryCode)
                    .IsRequired()
                    .HasColumnName("strItemCategoryCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Item Category.");

                entity.Property(e => e.StrItemCategoryName)
                    .IsRequired()
                    .HasColumnName("strItemCategoryName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Item Category.");
            });

            modelBuilder.Entity<TblItemMaster>(entity =>
            {
                entity.HasKey(e => e.IntItemMasterId);

                entity.ToTable("tblItemMaster", "msto");

                entity.Property(e => e.IntItemMasterId)
                    .HasColumnName("intItemMasterId")
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

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Item Master belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item Master is active or not.");

                entity.Property(e => e.StrItemMasterName)
                    .IsRequired()
                    .HasColumnName("strItemMasterName")
                    .HasMaxLength(200)
                    .HasComment("Value of this field will specify the Name of individual Item Master.");
            });

            modelBuilder.Entity<TblItemPlantWarehouse>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblItemPlantWarehouse", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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
                    .HasComment("Identity field for Business Unit. Value of this field will specify respective Business Unit. ");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Item Plant Warehouse belongs to.");

                entity.Property(e => e.IntItemId)
                    .HasColumnName("intItemId")
                    .HasComment("Identity field for Item. Value of this field will specify respective Item. ");

                entity.Property(e => e.IntPlantId)
                    .HasColumnName("intPlantId")
                    .HasComment("Identity field for Plant. Value of this field will specify the individual Plant.");

                entity.Property(e => e.IntWarehouseId)
                    .HasColumnName("intWarehouseId")
                    .HasComment("Identity field for Warehouse. Value of this field will specify the respective Warehouse.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item Plant Warehouse iis active or not.");
            });

            modelBuilder.Entity<TblItemPurchase>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblItemPurchase", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit.This unit will be used as the cost center of respective item to be purchased.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Item Purchase belongs to.");

                entity.Property(e => e.IntItemId)
                    .HasColumnName("intItemId")
                    .HasComment("Identity field for Item. Value of this field will specify individual Item. ");

                entity.Property(e => e.IntPlantId)
                    .HasColumnName("intPlantId")
                    .HasComment("Identity field for Plant. Value of this field will specify the respective Plant for individual Item Purchase.");

                entity.Property(e => e.IntPurchaseOrganizationId)
                    .HasColumnName("intPurchaseOrganizationId")
                    .HasComment("Identity field for Purchase Organization. Value of this field will specify the respective Purchase Organization.  ");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item Purchase is active or not.");

                entity.Property(e => e.NumLotSize)
                    .HasColumnName("numLotSize")
                    .HasColumnType("numeric(18, 6)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Value of this field will specify the total quantity of a product which is offered to purchase.");

                entity.Property(e => e.NumMaxLeadDays)
                    .HasColumnName("numMaxLeadDays")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Value of this field will specify the maximum number of required days to place an order for individual item. ");

                entity.Property(e => e.NumMinLeadDays)
                    .HasColumnName("numMinLeadDays")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Value of this field will specify the minimum number of required days to place an order for individual item. ");

                entity.Property(e => e.NumMinOrderQuantity)
                    .HasColumnName("numMinOrderQuantity")
                    .HasColumnType("numeric(18, 6)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Value of this field will specify the number of minimum order for individual item. ");

                entity.Property(e => e.StrHscode)
                    .IsRequired()
                    .HasColumnName("strHSCode")
                    .HasMaxLength(20)
                    .HasComment("Value of this field will specify the Harmonized Commodity Description and Coding System (HS code)");

                entity.Property(e => e.StrPurchaseDescription)
                    .IsRequired()
                    .HasColumnName("strPurchaseDescription")
                    .HasMaxLength(1000)
                    .HasComment("Value of this field will specify the description of item purchase. ");
            });

            modelBuilder.Entity<TblItemSales>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblItemSales", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit. This unit will be used as the cost center of respective item to be sold.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Item Sales belongs to.");

                entity.Property(e => e.IntItemId)
                    .HasColumnName("intItemId")
                    .HasComment("Identity field for Item. Value of this field will specify individual Item. ");

                entity.Property(e => e.IntProductDivisionId)
                    .HasColumnName("intProductDivisionId")
                    .HasComment("Identity field for Product Division. Value of this field will specify the individual Product Division.");

                entity.Property(e => e.IntProfitCenterId)
                    .HasColumnName("intProfitCenterId")
                    .HasComment("A unique key field for identifing every individual Profit Center. value of this field will specify the respective Profit Center where the Item Sales belongs to.");

                entity.Property(e => e.IntSalesOrganizationId)
                    .HasColumnName("intSalesOrganizationId")
                    .HasComment("Identity field for Sales Organizarion. Value of this field will specify the individual Sales Organizarion. ");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item Sales  is active or not.");

                entity.Property(e => e.NumLotSize)
                    .HasColumnName("numLotSize")
                    .HasColumnType("numeric(18, 6)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Value of this field will specify the total quantity of a product which is offered to sell.");

                entity.Property(e => e.NumMinOrderQuantity)
                    .HasColumnName("numMinOrderQuantity")
                    .HasColumnType("numeric(18, 6)")
                    .HasDefaultValueSql("((1))")
                    .HasComment("Value of this field will specify the number of minimum order for individual item. ");

                entity.Property(e => e.StrSalesDescription)
                    .IsRequired()
                    .HasColumnName("strSalesDescription")
                    .HasMaxLength(1000)
                    .HasComment("Value of this field will specify the description of item sales. ");
            });

            modelBuilder.Entity<TblItemSubCategory>(entity =>
            {
                entity.HasKey(e => e.IntItemSubCategoryId);

                entity.ToTable("tblItemSubCategory", "msto");

                entity.Property(e => e.IntItemSubCategoryId)
                    .HasColumnName("intItemSubCategoryId")
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
                    .HasComment("Value of this field will specify the Business Unit Where the Item Sub-Category belongs to. ");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Item Sub Category belongs to.");

                entity.Property(e => e.IntItemCategoryId)
                    .HasColumnName("intItemCategoryId")
                    .HasComment("Identity field for Item Category. Value of this field will specify the categories of every individual Item.");

                entity.Property(e => e.IntItemTypeId)
                    .HasColumnName("intItemTypeId")
                    .HasComment("Identity field for Item Type. Value of this field will specify the types of every individual Item.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item Sub Category is active or not.");

                entity.Property(e => e.StrItemSubCategoryCode)
                    .IsRequired()
                    .HasColumnName("strItemSubCategoryCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Item Sub-Category.");

                entity.Property(e => e.StrItemSubCategoryName)
                    .IsRequired()
                    .HasColumnName("strItemSubCategoryName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Item Sub-Category.");
            });

            modelBuilder.Entity<TblItemType>(entity =>
            {
                entity.HasKey(e => e.IntItemTypeId);

                entity.ToTable("tblItemType", "msto");

                entity.Property(e => e.IntItemTypeId)
                    .HasColumnName("intItemTypeId")
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
                    .HasComment("Value of this field will specify the Business Unit Where the Item Type belongs to. ");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Item type belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item Type  is active or not.");

                entity.Property(e => e.StrItemTypeName)
                    .IsRequired()
                    .HasColumnName("strItemTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Item Type.");
            });

            modelBuilder.Entity<TblItemUomconversion>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblItemUOMConversion", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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

                entity.Property(e => e.IntBaseUom)
                    .HasColumnName("intBaseUOM")
                    .HasComment("Identity field for Base UOM. Value of this field will specify base Unit of Measurement. ");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit. ");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients.");

                entity.Property(e => e.IntConvertedUom)
                    .HasColumnName("intConvertedUOM")
                    .HasComment("Identity field for Converted UOM. Value of this field will specify converted Unit of Measurement. ");

                entity.Property(e => e.IntItemId)
                    .HasColumnName("intItemId")
                    .HasComment("Identity field for Item. Value of this field will specify individual Item. ");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item UoM Conversion  is active or not.");

                entity.Property(e => e.NumConversionRate)
                    .HasColumnName("numConversionRate")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of the field will be used to convert the individual base UoM to get the required  UoM. ");
            });

            modelBuilder.Entity<TblLogTerritorySalesForceChange>(entity =>
            {
                entity.HasKey(e => e.IntLogId)
                    .HasName("PK_tblLogTerritorySalesFoceChange");

                entity.ToTable("tblLogTerritorySalesForceChange", "somo");

                entity.Property(e => e.IntLogId)
                    .HasColumnName("intLogId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.DteFromDate)
                    .HasColumnName("dteFromDate")
                    .HasColumnType("date")
                    .HasComment("value of this field will specify the Date from when the Sales force had any change to be longed.");

                entity.Property(e => e.DteLastActionDateTime)
                    .HasColumnName("dteLastActionDateTime")
                    .HasColumnType("datetime")
                    .HasComment("This field is used to keep record of every action's date & time in this table.");

                entity.Property(e => e.DteServerDateTime)
                    .HasColumnName("dteServerDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("This field is used to keep record of every action's server's date & time in this table. ");

                entity.Property(e => e.DteToDate)
                    .HasColumnName("dteToDate")
                    .HasColumnType("date")
                    .HasComment("value of this field will specify the Date till when the Sales force didnt had any other change.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the Territory Sales force belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whom the Territoy Sales force belongs to.");

                entity.Property(e => e.IntEmployeeId)
                    .HasColumnName("intEmployeeId")
                    .HasComment("Identity field for the respective employee.");

                entity.Property(e => e.IntTerritoryId)
                    .HasColumnName("intTerritoryId")
                    .HasComment("Identity field for Territory. Value of this field will specify the repective Territory. ");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether Changed position of the Sales force  is active or not.");
            });

            modelBuilder.Entity<TblOrderReferanceType>(entity =>
            {
                entity.HasKey(e => e.IntOrderReferanceTypeId);

                entity.ToTable("tblOrderReferanceType", "somo");

                entity.Property(e => e.IntOrderReferanceTypeId).HasColumnName("intOrderReferanceTypeId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.StrOrderReferanceTypeName)
                    .IsRequired()
                    .HasColumnName("strOrderReferanceTypeName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblOutlet>(entity =>
            {
                entity.HasKey(e => e.IntOutletId);

                entity.ToTable("tblOutlet", "msto");

                entity.Property(e => e.IntOutletId)
                    .HasColumnName("intOutletId")
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

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Outlet belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Outlet is active or not.");

                entity.Property(e => e.StrOutletCode)
                    .IsRequired()
                    .HasColumnName("strOutletCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Outlet.");

                entity.Property(e => e.StrOutletName)
                    .IsRequired()
                    .HasColumnName("strOutletName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Outlet.");
            });

            modelBuilder.Entity<TblOutletTerritory>(entity =>
            {
                entity.HasKey(e => e.IntConfigId)
                    .HasName("PK_tblTerritoryOutlet");

                entity.ToTable("tblOutletTerritory", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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
                    .HasComment("Identity field for Business Unit. Value of this field will specify the Business Unit Where the Outlet-Territory belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Outlet Territory belongs to.");

                entity.Property(e => e.IntOutletId)
                    .HasColumnName("intOutletId")
                    .HasComment("Identity field for Outlet. Value of this field will specify the respective outlet.");

                entity.Property(e => e.IntTerritoryId)
                    .HasColumnName("intTerritoryId")
                    .HasComment("Identity field for Territory. Value of this field will specify the Territory Where the Outlet-Territory belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Outlet Territory is active or not.");
            });

            modelBuilder.Entity<TblPaymentTerms>(entity =>
            {
                entity.HasKey(e => e.IntPaymentTerms);

                entity.ToTable("tblPaymentTerms", "somo");

                entity.Property(e => e.IntPaymentTerms).HasColumnName("intPaymentTerms");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StrPaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("strPaymentTermsCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StrPaymentTermsName)
                    .IsRequired()
                    .HasColumnName("strPaymentTermsName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblPlant>(entity =>
            {
                entity.HasKey(e => e.IntPlantId);

                entity.ToTable("tblPlant", "msto");

                entity.Property(e => e.IntPlantId)
                    .HasColumnName("intPlantId")
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
                    .HasComment("Identity field for Business Unit. Value of this field will specify the Business Unit Where the Plant belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whom the Plant belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Plant is active or not.");

                entity.Property(e => e.StrPlantAddress)
                    .IsRequired()
                    .HasColumnName("strPlantAddress")
                    .HasMaxLength(300)
                    .HasComment("Value of this field will specify the Address of individual Plant.");

                entity.Property(e => e.StrPlantCode)
                    .IsRequired()
                    .HasColumnName("strPlantCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Plant.");

                entity.Property(e => e.StrPlantName)
                    .IsRequired()
                    .HasColumnName("strPlantName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Plant.");
            });

            modelBuilder.Entity<TblPlantWarehouse>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblPlantWarehouse", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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
                    .HasComment("Identity field for Business Unit. Value of this field will specify the Business Unit Where the Plant-Warehouse belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the plant warehouse belongs to.");

                entity.Property(e => e.IntPlantId)
                    .HasColumnName("intPlantId")
                    .HasComment("Identity field for Plant. Value of this field will specify the Plant Where the Plant-Warehouse belongs to.");

                entity.Property(e => e.IntWarehouseId)
                    .HasColumnName("intWarehouseId")
                    .HasComment("Identity field for Warehouse. Value of this field will specify the  respective Warehouse. ");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Plant Warehouse is active or not.");

                entity.Property(e => e.StrPlantName)
                    .IsRequired()
                    .HasColumnName("strPlantName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Plant.");

                entity.Property(e => e.StrWarehouseName)
                    .IsRequired()
                    .HasColumnName("strWarehouseName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Warehouse.");
            });

            modelBuilder.Entity<TblPriceConditionTypeOrganization>(entity =>
            {
                entity.HasKey(e => e.IntPriceConditionTypeId)
                    .HasName("PK_tblPriceCodition");

                entity.ToTable("tblPriceConditionTypeOrganization", "somo");

                entity.Property(e => e.IntPriceConditionTypeId)
                    .HasColumnName("intPriceConditionTypeId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.IntAccessSequence)
                    .HasColumnName("intAccessSequence")
                    .HasComment("An auto incremental identity field for Access Sequence.Any single trade offer may vary to client, Territory, Distribution Channel, sales organization, Natinaliy or seasion. This field value will specify the offered sequesnce of  every individual TradeOfferConditonTypeItem.");

                entity.Property(e => e.StrPriceConditionTypeCode)
                    .IsRequired()
                    .HasColumnName("strPriceConditionTypeCode")
                    .HasMaxLength(50)
                    .HasComment("A unique key field for every individual Price Condition Type. Value of this field will specify the respective Price Condition Type.");

                entity.Property(e => e.StrPriceConditionTypeName)
                    .IsRequired()
                    .HasColumnName("strPriceConditionTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective Price Condition Type Name.");
            });

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

            modelBuilder.Entity<TblProductDivision>(entity =>
            {
                entity.HasKey(e => e.IntProductDivisionId);

                entity.ToTable("tblProductDivision", "msto");

                entity.Property(e => e.IntProductDivisionId)
                    .HasColumnName("intProductDivisionId")
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

                entity.Property(e => e.IntBusinessAreaId)
                    .HasColumnName("intBusinessAreaId")
                    .HasComment("Identity field for Business Area. Value of this field will specify the  Business Area Where the Product Division belongs to.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify the Business Unit Where the Product Division belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the product belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Product Division  is active or not.");

                entity.Property(e => e.StrProductDivisionCode)
                    .IsRequired()
                    .HasColumnName("strProductDivisionCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Product Division.");

                entity.Property(e => e.StrProductDivisionName)
                    .IsRequired()
                    .HasColumnName("strProductDivisionName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Product Division.");
            });

            modelBuilder.Entity<TblPurchaseOrganization>(entity =>
            {
                entity.HasKey(e => e.IntPurchaseOrganizationid);

                entity.ToTable("tblPurchaseOrganization", "msto");

                entity.Property(e => e.IntPurchaseOrganizationid)
                    .HasColumnName("intPurchaseOrganizationid")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whom the Purchase Organization belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Purchase Organization  is active or not.");

                entity.Property(e => e.StrPurchaseOrganization)
                    .IsRequired()
                    .HasColumnName("strPurchaseOrganization")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective Purchase Organization.");
            });

            modelBuilder.Entity<TblRoundingType>(entity =>
            {
                entity.HasKey(e => e.IntRoundingTypeId);

                entity.ToTable("tblRoundingType", "msto");

                entity.Property(e => e.IntRoundingTypeId)
                    .HasColumnName("intRoundingTypeId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.StrRoundingTypeName)
                    .IsRequired()
                    .HasColumnName("strRoundingTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify every individual Rounding Type Name.");
            });

            modelBuilder.Entity<TblRoute>(entity =>
            {
                entity.HasKey(e => e.IntRouteId);

                entity.ToTable("tblRoute", "somo");

                entity.Property(e => e.IntRouteId).HasColumnName("intRouteId");

                entity.Property(e => e.DteLastActionDateTime)
                    .HasColumnName("dteLastActionDateTime")
                    .HasColumnType("datetime")
                    .HasComment("This field is used to keep record of every action's date & time in this table.");

                entity.Property(e => e.DteServerDateTime)
                    .HasColumnName("dteServerDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("This field is used to keep record of every action's server's date & time in this table. ");

                entity.Property(e => e.IntActionBy).HasColumnName("intActionBy");

                entity.Property(e => e.IntBusinessUnitId).HasColumnName("intBusinessUnitId");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether the respective Account Receivable-Payable is active or not.");

                entity.Property(e => e.StrRouteAddress)
                    .IsRequired()
                    .HasColumnName("strRouteAddress")
                    .HasMaxLength(300);

                entity.Property(e => e.StrRouteName)
                    .IsRequired()
                    .HasColumnName("strRouteName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblRouteTransportzone>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblRouteTransportzone", "somo");

                entity.Property(e => e.IntConfigId).HasColumnName("intConfigId");

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

                entity.Property(e => e.IntBusinessUnitId).HasColumnName("intBusinessUnitId");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IntRouteId).HasColumnName("intRouteId");

                entity.Property(e => e.IntTransportZoneId).HasColumnName("intTransportZoneId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Currency Conversion is active or not.");
            });

            modelBuilder.Entity<TblSalesArea>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblSalesArea", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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
                    .HasComment("Identity field for Business Unit. Value of this field will specify the  Business Unit Where the Sales Area belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the sales area belongs to.");

                entity.Property(e => e.IntDistributionChannelId)
                    .HasColumnName("intDistributionChannelId")
                    .HasComment("Identity field for Distribution Channel. Value of this field will specify the Distribution Channel where the Sales Area belongs to. ");

                entity.Property(e => e.IntProductDivisionId)
                    .HasColumnName("intProductDivisionId")
                    .HasComment("Identity field for Product Division. Value of this field will specify the Product Division of the respective Sales Area.");

                entity.Property(e => e.IntSalesOrganizationId)
                    .HasColumnName("intSalesOrganizationId")
                    .HasComment("Identity field for Sales Organizarion. Value of this field will specify the Sales Organizarion the respective Sales Area.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Sales Area is active or not.");
            });

            modelBuilder.Entity<TblSalesForceTerritory>(entity =>
            {
                entity.HasKey(e => e.IntConfigId)
                    .HasName("PK_tblTerritorySalesFoce");

                entity.ToTable("tblSalesForceTerritory", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit where the sales force belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the slaes force belongs to.");

                entity.Property(e => e.IntEmployeeId)
                    .HasColumnName("intEmployeeId")
                    .HasComment("Identity field for the respective employee.");

                entity.Property(e => e.IntTerritoryId)
                    .HasColumnName("intTerritoryId")
                    .HasComment("Identity field for Territory. Value of this field will specify the individual Territory where the sales froce belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Sales Force Territory  is active or not.");

                entity.Property(e => e.YsnManager)
                    .HasColumnName("ysnManager")
                    .HasComment("Value of this field will specify wheather the sales force is a manager or not.");
            });

            modelBuilder.Entity<TblSalesOffice>(entity =>
            {
                entity.HasKey(e => e.IntSalesOfficeId);

                entity.ToTable("tblSalesOffice", "somo");

                entity.Property(e => e.IntSalesOfficeId).HasColumnName("intSalesOfficeId");

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

                entity.Property(e => e.IntBusinessUnitId).HasColumnName("intBusinessUnitId");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Account Group is active or not.");

                entity.Property(e => e.StrSalesOfficeName)
                    .IsRequired()
                    .HasColumnName("strSalesOfficeName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblSalesOrderGroup>(entity =>
            {
                entity.HasKey(e => e.IntSalesOrderGroupId);

                entity.ToTable("tblSalesOrderGroup", "somo");

                entity.Property(e => e.IntSalesOrderGroupId).HasColumnName("intSalesOrderGroupId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StrSalesOrderGroupName)
                    .IsRequired()
                    .HasColumnName("strSalesOrderGroupName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblSalesOrderHeader>(entity =>
            {
                entity.HasKey(e => e.IntSalesOrderId)
                    .HasName("PK_tblSalesOrder");

                entity.ToTable("tblSalesOrderHeader", "somo");

                entity.Property(e => e.IntSalesOrderId).HasColumnName("intSalesOrderId");

                entity.Property(e => e.DteApprovedDateTime)
                    .HasColumnName("dteApprovedDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DteDueShippingDate)
                    .HasColumnName("dteDueShippingDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteLastActionDateTime)
                    .HasColumnName("dteLastActionDateTime")
                    .HasColumnType("datetime")
                    .HasComment("This field is used to keep record of every action's date & time in this table.");

                entity.Property(e => e.DtePartnerReffDate)
                    .HasColumnName("dtePartnerReffDate")
                    .HasColumnType("date");

                entity.Property(e => e.DtePricingDate)
                    .HasColumnName("dtePricingDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteSalesOrderDate)
                    .HasColumnName("dteSalesOrderDate")
                    .HasColumnType("date");

                entity.Property(e => e.DteServerDateTime)
                    .HasColumnName("dteServerDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("This field is used to keep record of every action's server's date & time in this table. ");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntApprovedBy).HasColumnName("intApprovedBy");

                entity.Property(e => e.IntBillToPartnerId).HasColumnName("intBillToPartnerId");

                entity.Property(e => e.IntBusinessUnitId).HasColumnName("intBusinessUnitId");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IntDistributionChannelId).HasColumnName("intDistributionChannelId");

                entity.Property(e => e.IntIncotermId).HasColumnName("intIncotermId");

                entity.Property(e => e.IntPaymentInstrumentId).HasColumnName("intPaymentInstrumentId");

                entity.Property(e => e.IntPaymentTermId).HasColumnName("intPaymentTermId");

                entity.Property(e => e.IntSalesOfficeId).HasColumnName("intSalesOfficeId");

                entity.Property(e => e.IntSalesOrderTypeId).HasColumnName("intSalesOrderTypeId");

                entity.Property(e => e.IntSalesOrganizationId).HasColumnName("intSalesOrganizationId");

                entity.Property(e => e.IntSoldToPartnerId).HasColumnName("intSoldToPartnerId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Warehouse is active or not.");

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.IsCompleted).HasColumnName("isCompleted");

                entity.Property(e => e.IsPartialShipment).HasColumnName("isPartialShipment");

                entity.Property(e => e.IsTransshipment).HasColumnName("isTransshipment");

                entity.Property(e => e.NumHeaderDiscountValue)
                    .HasColumnName("numHeaderDiscountValue")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NumNetOrderValue)
                    .HasColumnName("numNetOrderValue")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NumRowDiscountValue)
                    .HasColumnName("numRowDiscountValue")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.NumTotalOrderValue)
                    .HasColumnName("numTotalOrderValue")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StrPartnerReffNo)
                    .HasColumnName("strPartnerReffNo")
                    .HasMaxLength(100);

                entity.Property(e => e.StrPaymentInstrumentNo)
                    .IsRequired()
                    .HasColumnName("strPaymentInstrumentNo")
                    .HasMaxLength(100);

                entity.Property(e => e.StrSalesOrderCode)
                    .IsRequired()
                    .HasColumnName("strSalesOrderCode")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblSalesOrderRow>(entity =>
            {
                entity.HasKey(e => e.IntRowId);

                entity.ToTable("tblSalesOrderRow", "somo");

                entity.Property(e => e.IntRowId).HasColumnName("intRowId");

                entity.Property(e => e.IntItemId).HasColumnName("intItemId");

                entity.Property(e => e.IntPriceConditionId).HasColumnName("intPriceConditionId");

                entity.Property(e => e.IntSalesOrderId).HasColumnName("intSalesOrderId");

                entity.Property(e => e.IntShipToPartnerId).HasColumnName("intShipToPartnerId");

                entity.Property(e => e.IntTradeOfferConditionId).HasColumnName("intTradeOfferConditionId");

                entity.Property(e => e.IsFreeItem).HasColumnName("isFreeItem");

                entity.Property(e => e.NumDeliveredQuantity)
                    .HasColumnName("numDeliveredQuantity")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumDiscountValue)
                    .HasColumnName("numDiscountValue")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumItemPrice)
                    .HasColumnName("numItemPrice")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumNetValue)
                    .HasColumnName("numNetValue")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumOrderQuantity)
                    .HasColumnName("numOrderQuantity")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumOrderValue)
                    .HasColumnName("numOrderValue")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.NumRequestQuantity)
                    .HasColumnName("numRequestQuantity")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.StrShipToPartnerAddress)
                    .IsRequired()
                    .HasColumnName("strShipToPartnerAddress")
                    .HasMaxLength(300);

                entity.Property(e => e.StrShipToPartnerName)
                    .IsRequired()
                    .HasColumnName("strShipToPartnerName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblSalesOrderType>(entity =>
            {
                entity.HasKey(e => e.IntSalesOrderTypeId);

                entity.ToTable("tblSalesOrderType", "somo");

                entity.Property(e => e.IntSalesOrderTypeId).HasColumnName("intSalesOrderTypeId");

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

                entity.Property(e => e.IntBusinessUnitid).HasColumnName("intBusinessUnitid");

                entity.Property(e => e.IntSalesOrderGroupId).HasColumnName("intSalesOrderGroupId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Business Partner is active or not.");
            });

            modelBuilder.Entity<TblSalesOrganization>(entity =>
            {
                entity.HasKey(e => e.IntSalesOrganizationId);

                entity.ToTable("tblSalesOrganization", "msto");

                entity.Property(e => e.IntSalesOrganizationId)
                    .HasColumnName("intSalesOrganizationId")
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

                entity.Property(e => e.IntBusinessAreaId)
                    .HasColumnName("intBusinessAreaId")
                    .HasComment("Identity field for Business Area. Value of this field will specify the  Business Area Where the Sales Organization belongs to.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify the  Business Unit Where the Sales Organization belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Sales Organization belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Sales Organization is active or not.");

                entity.Property(e => e.StrSalesOrganizationCode)
                    .IsRequired()
                    .HasColumnName("strSalesOrganizationCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Sales Organization.");

                entity.Property(e => e.StrSalesOrganizationName)
                    .IsRequired()
                    .HasColumnName("strSalesOrganizationName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Sales Organization.");
            });

            modelBuilder.Entity<TblShipPoint>(entity =>
            {
                entity.HasKey(e => e.IntShipPointId);

                entity.ToTable("tblShipPoint", "msto");

                entity.Property(e => e.IntShipPointId).HasColumnName("intShipPointId");

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

                entity.Property(e => e.IntBusinessUnitId).HasColumnName("intBusinessUnitId");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Item  is active or not.");

                entity.Property(e => e.StrAddress)
                    .IsRequired()
                    .HasColumnName("strAddress")
                    .HasMaxLength(300);

                entity.Property(e => e.StrShipPointName)
                    .IsRequired()
                    .HasColumnName("strShipPointName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblShipPointWarehouse>(entity =>
            {
                entity.HasKey(e => e.IntConfigId);

                entity.ToTable("tblShipPointWarehouse", "scmo");

                entity.Property(e => e.IntConfigId).HasColumnName("intConfigId");

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

                entity.Property(e => e.IntBusinessUnitId).HasColumnName("intBusinessUnitId");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IntShipPointId).HasColumnName("intShipPointId");

                entity.Property(e => e.IntWarehouseId).HasColumnName("intWarehouseId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Warehouse is active or not.");
            });

            modelBuilder.Entity<TblShippingType>(entity =>
            {
                entity.HasKey(e => e.IntShippingTypeId);

                entity.ToTable("tblShippingType", "somo");

                entity.Property(e => e.IntShippingTypeId).HasColumnName("intShippingTypeId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.StrShippingTypeName)
                    .IsRequired()
                    .HasColumnName("strShippingTypeName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblSoldToPartnerShipToPartner>(entity =>
            {
                entity.HasKey(e => e.IntConfigId)
                    .HasName("PK_tblBusinessPartnerPartnerShipToPartner");

                entity.ToTable("tblSoldToPartnerShipToPartner", "cnfo");

                entity.Property(e => e.IntConfigId)
                    .HasColumnName("intConfigId")
                    .HasComment("An auto incremental Identity field.");

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
                    .HasComment("Identity field for Business Unit.Value of this field will specify the Business Unit Where the Partner belongs to.");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IntShipToPartnerId)
                    .HasColumnName("intShipToPartnerId")
                    .HasComment("Identity field for partner to whom the product is shipped.");

                entity.Property(e => e.IntSoldToPartnerId)
                    .HasColumnName("intSoldToPartnerId")
                    .HasComment("Identity field for partner to whom the product is sold.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this data  is active or not.");

                entity.Property(e => e.StrShipToPartnerName)
                    .IsRequired()
                    .HasColumnName("strShipToPartnerName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the name of individual partner to whom the product is shipped.");

                entity.Property(e => e.StrSoldToPartnerName)
                    .IsRequired()
                    .HasColumnName("strSoldToPartnerName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the name of individual partner to whom the product is sold.");
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

                entity.Property(e => e.IntCountryId).HasColumnName("intCountryId");

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

                entity.Property(e => e.StrCountryName)
                    .HasColumnName("strCountryName")
                    .HasMaxLength(100);

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

            modelBuilder.Entity<TblTerritoryType>(entity =>
            {
                entity.HasKey(e => e.IntTerritoryTypeId);

                entity.ToTable("tblTerritoryType", "msto");

                entity.Property(e => e.IntTerritoryTypeId)
                    .HasColumnName("intTerritoryTypeId")
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
                    .HasComment("Identity field for Business Unit. Value of this field will specify the Business Unit Where the Territory Type belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients whom the Territory Type belongs to.");

                entity.Property(e => e.IntlevelPosition)
                    .HasColumnName("intlevelPosition")
                    .HasComment("Identity field for position of Territory level. Value of this field will specify the hierarchy of territory type. ");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Territory Type  is active or not.");

                entity.Property(e => e.StrTerritoryTypeName)
                    .IsRequired()
                    .HasColumnName("strTerritoryTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Territory Type.");
            });

            modelBuilder.Entity<TblThana>(entity =>
            {
                entity.HasKey(e => e.IntThanaId);

                entity.ToTable("tblThana", "msto");

                entity.Property(e => e.IntThanaId).HasColumnName("intThanaId");

                entity.Property(e => e.IntDistrictId).HasColumnName("intDistrictID");

                entity.Property(e => e.IntGeocode).HasColumnName("intGEOCode");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StrThanaBanglaName)
                    .IsRequired()
                    .HasColumnName("strThanaBanglaName")
                    .HasMaxLength(100);

                entity.Property(e => e.StrThanaName)
                    .IsRequired()
                    .HasColumnName("strThanaName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTradeOfferConditionTypeItem>(entity =>
            {
                entity.HasKey(e => e.TradeOfferConditionTypeId);

                entity.ToTable("tblTradeOfferConditionTypeItem", "somo");

                entity.Property(e => e.TradeOfferConditionTypeId).HasComment("An auto incremental identity field. ");

                entity.Property(e => e.IntAccessSequence)
                    .HasColumnName("intAccessSequence")
                    .HasComment(@"An auto incremental identity field for Access Sequence.Any single trade offer may vary to client, Area, Channel, Natinaliy or seasion. This field value will specify the offered sequesnce of  every individual TradeOfferConditonTypeItem.
");

                entity.Property(e => e.StrTradeOfferConditionTypeName)
                    .IsRequired()
                    .HasColumnName("strTradeOfferConditionTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective TradeOfferConditionTypeName.");
            });

            modelBuilder.Entity<TblTradeOfferItemGroupHeader>(entity =>
            {
                entity.HasKey(e => e.IntTradeOfferItemGroupId);

                entity.ToTable("TblTradeOfferItemGroupHeader", "somo");

                entity.Property(e => e.IntTradeOfferItemGroupId).HasColumnName("intTradeOfferItemGroupId");

                entity.Property(e => e.DteLastActionDateTime)
                    .HasColumnName("dteLastActionDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DteServerDateTime)
                    .HasColumnName("dteServerDateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IntActionBy).HasColumnName("intActionBy");

                entity.Property(e => e.IntBusinessUnitId).HasColumnName("intBusinessUnitId");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StrTradeOfferItemGroupName)
                    .IsRequired()
                    .HasColumnName("strTradeOfferItemGroupName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblTradeOfferItemGroupRow>(entity =>
            {
                entity.HasKey(e => e.IntRowId);

                entity.ToTable("tblTradeOfferItemGroupRow", "somo");

                entity.Property(e => e.IntRowId)
                    .HasColumnName("intRowId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit.");

                entity.Property(e => e.IntItemId)
                    .HasColumnName("intItemId")
                    .HasComment("Identity field for Item. Value of this field will specify individual Item to which the Trade offer Group belongs.");

                entity.Property(e => e.IntTradeOfferItemGroupId)
                    .HasColumnName("intTradeOfferItemGroupId")
                    .HasComment("A unique key field for identifying every individual Trade Offer Item Group.");
            });

            modelBuilder.Entity<TblTradeOfferSetupHeader>(entity =>
            {
                entity.HasKey(e => e.IntTradeOfferConditionId)
                    .HasName("PK_tblTradeOfferSetup");

                entity.ToTable("tblTradeOfferSetupHeader", "somo");

                entity.Property(e => e.IntTradeOfferConditionId)
                    .HasColumnName("intTradeOfferConditionId")
                    .HasComment("An auto incremental identity field.");

                entity.Property(e => e.DteEndDate)
                    .HasColumnName("dteEndDate")
                    .HasColumnType("date")
                    .HasComment("value of this field will specify the end date till when the Trade Offer Conditon will be activated.");

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
                    .HasComment("Value of this field will specify the start date from when theTrade Offer Conditon will be activated.");

                entity.Property(e => e.IntActionBy)
                    .HasColumnName("intActionBy")
                    .HasComment("This field is used for keeping record of its users who will take any action (insert/Update) into this table.");

                entity.Property(e => e.IntBusinessUnitId)
                    .HasColumnName("intBusinessUnitId")
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients to whom the Trade Offer Condition belongs to.");

                entity.Property(e => e.IntPriceConditionReffId)
                    .HasColumnName("intPriceConditionReffId")
                    .HasComment("Identity key field for individual Condition Refeence ID whom the condition is applied. Value of this field will specify the respective Reference Id such as CustomerID, TerritoryID, Distribution ChannelID or Sales OrganizationID.");

                entity.Property(e => e.IntPriceConditionTypeId)
                    .HasColumnName("intPriceConditionTypeId")
                    .HasComment("A unique key field for identifying every individual Price Condition Type Name for the respective Trade Offer Condition.");

                entity.Property(e => e.IntRoundingTypeId)
                    .HasColumnName("intRoundingTypeId")
                    .HasComment("Value of this field will specify the resective Rounding Type (Rounding Up, Given value, Rounding Down) for every individual Trade Offer Condition.");

                entity.Property(e => e.IntTradeOfferConditionReffId)
                    .HasColumnName("intTradeOfferConditionReffId")
                    .HasComment("Identity key field for individualTrade Offer Condition Refeence ID to which the condition is applied. Value of this field will specify the respective Reference Id such as ItemID, Item GroupID, All ItemID.");

                entity.Property(e => e.IntTradeOfferConditionTypeId)
                    .HasColumnName("intTradeOfferConditionTypeId")
                    .HasComment("A unique value field for identifing every individual Trade Offer Condition Type.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Trade Offer Condition is active or not.");

                entity.Property(e => e.IsMinimumApplied)
                    .HasColumnName("isMinimumApplied")
                    .HasComment("Value of this field will specify wheather the offer is active for minimum purchase amount. IF value of this field is true &  purchased amount should be equal to/more than  minimun offered amount then user will get the offered discount upon the purchased amount. This amount is offered on minimun quanitity of purchase.");

                entity.Property(e => e.IsSlabProgram)
                    .HasColumnName("isSlabProgram")
                    .HasComment("Value of this field will specify wheather the offer is active or not  for defined purchased amount.");

                entity.Property(e => e.IsValueBase)
                    .HasColumnName("isValueBase")
                    .HasComment("Value of this field will specify wheather the offer is active for defined purchased amount. IF value of this field is true &  purchased amount should be equal to/more than offered amount then user will get the offered discount amount  upon the purchased amount.This amount is offered on minimun amount of purchase.");

                entity.Property(e => e.StrPriceConditionTypeName)
                    .IsRequired()
                    .HasColumnName("strPriceConditionTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective Price Condition Type Name for individaul Trade Offer Condition. This field basiclly defines the customer hierarchy for whom this condition is applied. Levels of this hierarchy are- Customer, Territoy, Distribution Channel and Sales organization.");

                entity.Property(e => e.StrTradeOfferConditionTypeName)
                    .IsRequired()
                    .HasColumnName("strTradeOfferConditionTypeName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the respective Trade Offer Condition Type Name. This field basiclly defines the Item hierarchy for which respective Trade Offer Condition is applied. Levels of this hierarchy are-Item, Item Group, All Item.");
            });

            modelBuilder.Entity<TblTradeOfferSetupRow>(entity =>
            {
                entity.HasKey(e => e.IntRowId);

                entity.ToTable("tblTradeOfferSetupRow", "somo");

                entity.Property(e => e.IntRowId)
                    .HasColumnName("intRowId")
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
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify the clients.");

                entity.Property(e => e.IntOfferItemId)
                    .HasColumnName("intOfferItemId")
                    .HasComment("Identity key field for individua Items.Value of this fiedl will specify the respectuve item upon which any individual Trade Offer is  declared to be given.");

                entity.Property(e => e.IntOfferItemUom)
                    .HasColumnName("intOfferItemUom")
                    .HasComment("Identity key field for individua Item's Unit of Measurement.Value of this fiedl will specify the respectuve item's UoM  upon which Item any individual Trade Offer is  declared to be given.");

                entity.Property(e => e.IntTradeOfferConditionId)
                    .HasColumnName("intTradeOfferConditionId")
                    .HasComment("Identity key field for every individual Trade Odder Condition. Value of this field will specify the respective Trade Offer Condition.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Trade Offer Steup Row is active or not.");

                entity.Property(e => e.IsSlabProgram)
                    .HasColumnName("isSlabProgram")
                    .HasComment("Value of this field will specify wheather the offer is active or not  for defined purchased amount.");

                entity.Property(e => e.IsValueBase)
                    .HasColumnName("isValueBase")
                    .HasComment("Value of this field will specify wheather the offer is active for defined purchased amount. IF value of this field is true &  purchased amount should be equal to/more than offered amount then user will get the offered discount amount  upon the purchased amount.This amount is offered on minimun amount of purchase.");

                entity.Property(e => e.NumBaseFrom)
                    .HasColumnName("numBaseFrom")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of this field is will specify the number amount from which the Valuebase offer will be active.This field will be aplicable, if isValuebase field vlaue is true.");

                entity.Property(e => e.NumBaseTo)
                    .HasColumnName("numBaseTo")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of this field is will specify the number amount to( Ragne of the numBase) which the Valuebase offer will be active.This field will be aplicable, if isValuebase field vlaue is true.");

                entity.Property(e => e.NumOfferAmount)
                    .HasColumnName("numOfferAmount")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of this field will specify the offered amount that is declared to be given in respective trade offer.");

                entity.Property(e => e.NumOfferPercent)
                    .HasColumnName("numOfferPercent")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of this field will specify the percentance amount that is offered in respective trade offer.");

                entity.Property(e => e.NumOfferQuantity)
                    .HasColumnName("numOfferQuantity")
                    .HasColumnType("numeric(18, 6)")
                    .HasComment("Value of this field will specify the offered quantity of the respective item which is declared to be purchased to get the Trade offer.");
            });

            modelBuilder.Entity<TblTransportMode>(entity =>
            {
                entity.HasKey(e => e.IntTransportModeId);

                entity.ToTable("tblTransportMode", "somo");

                entity.Property(e => e.IntTransportModeId).HasColumnName("intTransportModeId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.StrTransportModeName)
                    .HasColumnName("strTransportModeName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblTransportZone>(entity =>
            {
                entity.HasKey(e => e.IntTransportZoneId);

                entity.ToTable("tblTransportZone", "somo");

                entity.Property(e => e.IntTransportZoneId).HasColumnName("intTransportZoneId");

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

                entity.Property(e => e.IntBusinessUintid).HasColumnName("intBusinessUintid");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.StrTransportZoneName)
                    .IsRequired()
                    .HasColumnName("strTransportZoneName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblUnitOfMeasurement>(entity =>
            {
                entity.HasKey(e => e.IntUomid);

                entity.ToTable("tblUnitOfMeasurement", "msto");

                entity.Property(e => e.IntUomid)
                    .HasColumnName("intUOMId")
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
                    .HasComment("Identity field for Business Unit. Value of this field will specify individual Business Unit. ");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Unit of Measurement is active or not.");

                entity.Property(e => e.StrUomname)
                    .IsRequired()
                    .HasColumnName("strUOMName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Unit of Measurement.");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.IntUserId);

                entity.ToTable("tblUser", "msto");

                entity.Property(e => e.IntUserId)
                    .HasColumnName("intUserId")
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

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity field for Clients. Value of this field will specify individual clients.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this User is active or not.");

                entity.Property(e => e.StrLoginId)
                    .IsRequired()
                    .HasColumnName("strLoginId")
                    .HasMaxLength(50)
                    .HasComment("This field is used to keep Login Id for individual user. ");

                entity.Property(e => e.StrPassword)
                    .IsRequired()
                    .HasColumnName("strPassword")
                    .HasMaxLength(25)
                    .HasComment("This field is used to keep Login Password for individual user. ");

                entity.Property(e => e.StrUserName)
                    .IsRequired()
                    .HasColumnName("strUserName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual User.");
            });

            modelBuilder.Entity<TblVehicle>(entity =>
            {
                entity.HasKey(e => e.IntVehicleId);

                entity.ToTable("tblVehicle", "msto");

                entity.Property(e => e.IntVehicleId).HasColumnName("intVehicleId");

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

                entity.Property(e => e.IntBusinessUnitId).HasColumnName("intBusinessUnitId");

                entity.Property(e => e.IntClientId).HasColumnName("intClientId");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Currency Conversion is active or not.");

                entity.Property(e => e.StrVehicleCode)
                    .IsRequired()
                    .HasColumnName("strVehicleCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StrVehicleNo)
                    .IsRequired()
                    .HasColumnName("strVehicleNo")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TblWarehouse>(entity =>
            {
                entity.HasKey(e => e.IntWarehouseId);

                entity.ToTable("tblWarehouse", "msto");

                entity.Property(e => e.IntWarehouseId)
                    .HasColumnName("intWarehouseId")
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
                    .HasComment("Identity field for Business Unit. Value of this field will specify the Business Unit Where the Warehouse belongs to.");

                entity.Property(e => e.IntClientId)
                    .HasColumnName("intClientId")
                    .HasComment("Identity key field for every individual client. Value of this field will specify the respective client whom the warehouse belongs to.");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))")
                    .HasComment("An acitivity status field.Value of this field will identify whether this Warehouse is active or not.");

                entity.Property(e => e.StrWarehouseAddress)
                    .IsRequired()
                    .HasColumnName("strWarehouseAddress")
                    .HasMaxLength(300)
                    .HasComment("Value of this field will specify the Address of individual Warehouse.");

                entity.Property(e => e.StrWarehouseCode)
                    .IsRequired()
                    .HasColumnName("strWarehouseCode")
                    .HasMaxLength(50)
                    .HasComment("A uniqe key field for identifying every individual Warehouse.");

                entity.Property(e => e.StrWarehouseName)
                    .IsRequired()
                    .HasColumnName("strWarehouseName")
                    .HasMaxLength(100)
                    .HasComment("Value of this field will specify the Name of individual Warehouse.");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
