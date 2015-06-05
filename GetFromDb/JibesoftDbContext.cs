namespace GetFromDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class JibesoftDbContext : DbContext
    {
        public JibesoftDbContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<FulfillmentStatu> FulfillmentStatus { get; set; }
        public virtual DbSet<ItemAdjustment> ItemAdjustments { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<LeadSource> LeadSources { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MoneyEntity> MoneyEntities { get; set; }
        public virtual DbSet<MoneyEntityTouch> MoneyEntityTouches { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<ReceiptStatu> ReceiptStatus { get; set; }
        public virtual DbSet<SalesRep> SalesReps { get; set; }
        public virtual DbSet<ShippingAddress> ShippingAddresses { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<TxnLine> TxnLines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FulfillmentStatu>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.FulfillmentStatu)
                .HasForeignKey(e => e.FulfillmentStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.ItemAdjustments)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.TxnLines)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MoneyEntity>()
                .HasMany(e => e.MoneyEntityTouches)
                .WithRequired(e => e.MoneyEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MoneyEntity>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.MoneyEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MoneyEntity>()
                .HasMany(e => e.Purchases)
                .WithRequired(e => e.MoneyEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MoneyEntity>()
                .HasMany(e => e.ShippingAddresses)
                .WithRequired(e => e.MoneyEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReceiptStatu>()
                .HasMany(e => e.Purchases)
                .WithRequired(e => e.ReceiptStatu)
                .HasForeignKey(e => e.ReceiptStatusId)
                .WillCascadeOnDelete(false);
        }
    }
}
