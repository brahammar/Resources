namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseModel : DbContext
    {
        public DatabaseModel()
            : base("name=DatabaseModel")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountAddress> AccountAddresses { get; set; }
        public virtual DbSet<AccountAddressType> AccountAddressTypes { get; set; }
        public virtual DbSet<AccountBusinessUnitPartnerProgram> AccountBusinessUnitPartnerPrograms { get; set; }
        public virtual DbSet<AccountContract> AccountContracts { get; set; }
        public virtual DbSet<AccountPlanogram> AccountPlanograms { get; set; }
        public virtual DbSet<AccountPlanogramConfiguration> AccountPlanogramConfigurations { get; set; }
        public virtual DbSet<AccountSalesChannel> AccountSalesChannels { get; set; }
        public virtual DbSet<AccountTraining> AccountTrainings { get; set; }
        public virtual DbSet<APPR_Answer> APPR_Answer { get; set; }
        public virtual DbSet<APPR_FieldType> APPR_FieldType { get; set; }
        public virtual DbSet<APPR_Language> APPR_Language { get; set; }
        public virtual DbSet<APPR_LanguageCountry> APPR_LanguageCountry { get; set; }
        public virtual DbSet<APPR_Page> APPR_Page { get; set; }
        public virtual DbSet<APPR_PageTranslations> APPR_PageTranslations { get; set; }
        public virtual DbSet<APPR_Question> APPR_Question { get; set; }
        public virtual DbSet<APPR_QuestionTranslations> APPR_QuestionTranslations { get; set; }
        public virtual DbSet<APPR_Review> APPR_Review { get; set; }
        public virtual DbSet<APPR_ReviewVersion> APPR_ReviewVersion { get; set; }
        public virtual DbSet<APPR_Section> APPR_Section { get; set; }
        public virtual DbSet<APPR_SectionTranslations> APPR_SectionTranslations { get; set; }
        public virtual DbSet<APPR_SectionType> APPR_SectionType { get; set; }
        public virtual DbSet<Assortment> Assortments { get; set; }
        public virtual DbSet<AssortmentAccountStatistic> AssortmentAccountStatistics { get; set; }
        public virtual DbSet<AssortmentBrand> AssortmentBrands { get; set; }
        public virtual DbSet<AssortmentBrandAccount> AssortmentBrandAccounts { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<BrandPartnerProgram> BrandPartnerPrograms { get; set; }
        public virtual DbSet<BusinessArea> BusinessAreas { get; set; }
        public virtual DbSet<BusinessUnit> BusinessUnits { get; set; }
        public virtual DbSet<BusinessUnitAccount> BusinessUnitAccounts { get; set; }
        public virtual DbSet<BusinessUnitBrand> BusinessUnitBrands { get; set; }
        public virtual DbSet<BusinessUnitPartnerProgram> BusinessUnitPartnerPrograms { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CRMSync> CRMSyncs { get; set; }
        public virtual DbSet<Inspection> Inspections { get; set; }
        public virtual DbSet<InspectionImage> InspectionImages { get; set; }
        public virtual DbSet<InspectionPlanogram> InspectionPlanograms { get; set; }
        public virtual DbSet<InspectionPlanogramImage> InspectionPlanogramImages { get; set; }
        public virtual DbSet<InspectionPlanogramItem> InspectionPlanogramItems { get; set; }
        public virtual DbSet<PartnerProgram> PartnerPrograms { get; set; }
        public virtual DbSet<Planogram> Planograms { get; set; }
        public virtual DbSet<PlanogramConfiguration> PlanogramConfigurations { get; set; }
        public virtual DbSet<PlanogramConnection> PlanogramConnections { get; set; }
        public virtual DbSet<PlanogramCountry> PlanogramCountries { get; set; }
        public virtual DbSet<PlanogramItem> PlanogramItems { get; set; }
        public virtual DbSet<PlanogramItemOption> PlanogramItemOptions { get; set; }
        public virtual DbSet<PlanogramItemType> PlanogramItemTypes { get; set; }
        public virtual DbSet<PlanogramType> PlanogramTypes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SalesChannel> SalesChannels { get; set; }
        public virtual DbSet<SalesChannelPlanogramType> SalesChannelPlanogramTypes { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<AccountAddressbackup> AccountAddressbackups { get; set; }
        public virtual DbSet<CRMSyncDeleted> CRMSyncDeleteds { get; set; }
        public virtual DbSet<PDOS_CountryEmail> PDOS_CountryEmail { get; set; }
        public virtual DbSet<site_ThemeCss> site_ThemeCss { get; set; }
        public virtual DbSet<site_Themes> site_Themes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasMany(e => e.AccountAddresses)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AccountBusinessUnitPartnerPrograms)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AccountContracts)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AccountPlanograms)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AccountPlanogramConfigurations)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AccountSalesChannels)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AccountTrainings)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AssortmentBrandAccounts)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.BusinessUnitAccounts)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Inspections)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.APPR_Review)
                .WithRequired(e => e.Account)
                .HasForeignKey(e => e.DealerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccountAddressType>()
                .HasMany(e => e.AccountAddresses)
                .WithRequired(e => e.AccountAddressType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccountPlanogramConfiguration>()
                .HasMany(e => e.PlanogramConfigurations)
                .WithRequired(e => e.AccountPlanogramConfiguration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Answer>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<APPR_Answer>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<APPR_Answer>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<APPR_FieldType>()
                .HasMany(e => e.APPR_Question)
                .WithRequired(e => e.APPR_FieldType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Language>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<APPR_Language>()
                .HasMany(e => e.APPR_PageTranslations)
                .WithRequired(e => e.APPR_Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Language>()
                .HasMany(e => e.APPR_QuestionTranslations)
                .WithRequired(e => e.APPR_Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Language>()
                .HasMany(e => e.APPR_Review)
                .WithRequired(e => e.APPR_Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Language>()
                .HasMany(e => e.APPR_SectionTranslations)
                .WithRequired(e => e.APPR_Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Language>()
                .HasMany(e => e.APPR_LanguageCountry)
                .WithRequired(e => e.APPR_Language)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Page>()
                .HasMany(e => e.APPR_PageTranslations)
                .WithRequired(e => e.APPR_Page)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Page>()
                .HasMany(e => e.APPR_Section)
                .WithRequired(e => e.APPR_Page)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Question>()
                .HasMany(e => e.APPR_Answer)
                .WithRequired(e => e.APPR_Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Question>()
                .HasMany(e => e.APPR_QuestionTranslations)
                .WithRequired(e => e.APPR_Question)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Review>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<APPR_Review>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<APPR_Review>()
                .HasMany(e => e.APPR_Answer)
                .WithRequired(e => e.APPR_Review)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_ReviewVersion>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<APPR_ReviewVersion>()
                .HasMany(e => e.APPR_Review)
                .WithRequired(e => e.APPR_ReviewVersion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Section>()
                .HasMany(e => e.APPR_Question)
                .WithRequired(e => e.APPR_Section)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_Section>()
                .HasMany(e => e.APPR_SectionTranslations)
                .WithRequired(e => e.APPR_Section)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<APPR_SectionType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<APPR_SectionType>()
                .HasMany(e => e.APPR_Section)
                .WithRequired(e => e.APPR_SectionType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Assortment>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Assortment>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<Assortment>()
                .HasMany(e => e.AssortmentAccountStatistics)
                .WithRequired(e => e.Assortment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Assortment>()
                .HasMany(e => e.AssortmentBrands)
                .WithRequired(e => e.Assortment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Assortment>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Assortment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AssortmentBrand>()
                .HasMany(e => e.AssortmentBrandAccounts)
                .WithRequired(e => e.AssortmentBrand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Brand>()
                .HasMany(e => e.AssortmentBrands)
                .WithRequired(e => e.Brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Brand>()
                .HasMany(e => e.BrandPartnerPrograms)
                .WithRequired(e => e.Brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Brand>()
                .HasMany(e => e.BusinessUnitBrands)
                .WithRequired(e => e.Brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessArea>()
                .HasMany(e => e.BusinessUnits)
                .WithRequired(e => e.BusinessArea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnit>()
                .HasMany(e => e.BusinessUnitAccounts)
                .WithRequired(e => e.BusinessUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnit>()
                .HasMany(e => e.BusinessUnitBrands)
                .WithRequired(e => e.BusinessUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnit>()
                .HasMany(e => e.BusinessUnitPartnerPrograms)
                .WithRequired(e => e.BusinessUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BusinessUnitAccount>()
                .Property(e => e.PriceList)
                .IsFixedLength();

            modelBuilder.Entity<BusinessUnitAccount>()
                .Property(e => e.FreeFreightLimit)
                .HasPrecision(9, 2);

            modelBuilder.Entity<BusinessUnitPartnerProgram>()
                .HasMany(e => e.AccountBusinessUnitPartnerPrograms)
                .WithRequired(e => e.BusinessUnitPartnerProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contract>()
                .HasMany(e => e.AccountContracts)
                .WithRequired(e => e.Contract)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Abbrevation)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.ThuleAbbrevation)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.APPR_LanguageCountry)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.AssortmentAccountStatistics)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.PlanogramCountries)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRMSync>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<CRMSync>()
                .Property(e => e.InternalIdColumn)
                .IsUnicode(false);

            modelBuilder.Entity<CRMSync>()
                .Property(e => e.ExternalIdColumn)
                .IsUnicode(false);

            modelBuilder.Entity<CRMSync>()
                .Property(e => e.LastUpdatedColumn)
                .IsUnicode(false);

            modelBuilder.Entity<CRMSync>()
                .Property(e => e.UpdatedByColumn)
                .IsUnicode(false);

            modelBuilder.Entity<CRMSync>()
                .HasMany(e => e.CRMSyncDeleteds)
                .WithRequired(e => e.CRMSync)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspection>()
                .HasMany(e => e.InspectionImages)
                .WithRequired(e => e.Inspection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inspection>()
                .HasMany(e => e.InspectionPlanograms)
                .WithRequired(e => e.Inspection)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InspectionPlanogram>()
                .HasMany(e => e.InspectionPlanogramImages)
                .WithRequired(e => e.InspectionPlanogram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InspectionPlanogram>()
                .HasMany(e => e.InspectionPlanogramItems)
                .WithRequired(e => e.InspectionPlanogram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PartnerProgram>()
                .HasMany(e => e.BrandPartnerPrograms)
                .WithRequired(e => e.PartnerProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PartnerProgram>()
                .HasMany(e => e.BusinessUnitPartnerPrograms)
                .WithRequired(e => e.PartnerProgram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Planogram>()
                .HasMany(e => e.AccountPlanograms)
                .WithRequired(e => e.Planogram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Planogram>()
                .HasMany(e => e.InspectionPlanograms)
                .WithRequired(e => e.Planogram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Planogram>()
                .HasMany(e => e.PlanogramConfigurations)
                .WithRequired(e => e.Planogram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Planogram>()
                .HasMany(e => e.PlanogramCountries)
                .WithRequired(e => e.Planogram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Planogram>()
                .HasMany(e => e.PlanogramItems)
                .WithRequired(e => e.Planogram)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Planogram>()
                .HasMany(e => e.PlanogramConnections)
                .WithRequired(e => e.Planogram)
                .HasForeignKey(e => e.ChildPlanogramId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Planogram>()
                .HasMany(e => e.PlanogramConnections1)
                .WithRequired(e => e.Planogram1)
                .HasForeignKey(e => e.ParentPlanogramId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlanogramItem>()
                .HasMany(e => e.InspectionPlanogramItems)
                .WithRequired(e => e.PlanogramItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlanogramItem>()
                .HasMany(e => e.PlanogramItemOptions)
                .WithRequired(e => e.PlanogramItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlanogramItemType>()
                .HasMany(e => e.PlanogramItems)
                .WithRequired(e => e.PlanogramItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlanogramType>()
                .HasMany(e => e.Planograms)
                .WithRequired(e => e.PlanogramType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlanogramType>()
                .HasMany(e => e.SalesChannelPlanogramTypes)
                .WithRequired(e => e.PlanogramType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesChannel>()
                .HasMany(e => e.AccountSalesChannels)
                .WithRequired(e => e.SalesChannel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesChannel>()
                .HasMany(e => e.SalesChannelPlanogramTypes)
                .WithRequired(e => e.SalesChannel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Training>()
                .HasMany(e => e.AccountTrainings)
                .WithRequired(e => e.Training)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CRMSyncDeleted>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<CRMSyncDeleted>()
                .Property(e => e.DeletedBy)
                .IsUnicode(false);

            modelBuilder.Entity<PDOS_CountryEmail>()
                .Property(e => e.countryID)
                .IsUnicode(false);

            modelBuilder.Entity<PDOS_CountryEmail>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<PDOS_CountryEmail>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<PDOS_CountryEmail>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
