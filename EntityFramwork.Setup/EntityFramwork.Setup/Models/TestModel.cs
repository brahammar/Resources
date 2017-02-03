namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestModel : DbContext
    {
        public TestModel()
            : base("name=TestModel")
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
        public virtual DbSet<Inspection> Inspections { get; set; }
        public virtual DbSet<InspectionImage> InspectionImages { get; set; }
        public virtual DbSet<InspectionPlanogram> InspectionPlanograms { get; set; }
        public virtual DbSet<InspectionPlanogramImage> InspectionPlanogramImages { get; set; }
        public virtual DbSet<InspectionPlanogramItem> InspectionPlanogramItems { get; set; }
        public virtual DbSet<Planogram> Planograms { get; set; }
        public virtual DbSet<PlanogramConfiguration> PlanogramConfigurations { get; set; }
        public virtual DbSet<PlanogramConnection> PlanogramConnections { get; set; }
        public virtual DbSet<PlanogramCountry> PlanogramCountries { get; set; }
        public virtual DbSet<PlanogramItem> PlanogramItems { get; set; }
        public virtual DbSet<PlanogramItemOption> PlanogramItemOptions { get; set; }
        public virtual DbSet<PlanogramItemType> PlanogramItemTypes { get; set; }
        public virtual DbSet<PlanogramType> PlanogramTypes { get; set; }
        public virtual DbSet<AccountAddressbackup> AccountAddressbackups { get; set; }

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
                .HasMany(e => e.Inspections)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccountAddressType>()
                .HasMany(e => e.AccountAddresses)
                .WithRequired(e => e.AccountAddressType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccountPlanogramConfiguration>()
                .HasMany(e => e.PlanogramConfigurations)
                .WithRequired(e => e.AccountPlanogramConfiguration)
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
        }
    }
}
