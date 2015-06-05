namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        public Item()
        {
            ItemAdjustments = new HashSet<ItemAdjustment>();
            TxnLines = new HashSet<TxnLine>();
        }

        public int Id { get; set; }

        public string AlertLevel { get; set; }

        public string CriticalLevel { get; set; }

        public bool IsActive { get; set; }

        public bool IsSerialTrackingRequired { get; set; }

        public string ItemHeight { get; set; }

        public string ItemLength { get; set; }

        public string ItemType { get; set; }

        public string ItemWeight { get; set; }

        public string ItemWidth { get; set; }

        public string LeadTime { get; set; }

        public string LeadTimeFixed { get; set; }

        public string LotSizeMinimum { get; set; }

        public string LotSizeMultiple { get; set; }

        public string ManufacturerPartNumber { get; set; }

        public string MonitorLevel { get; set; }

        [Required]
        public string Name { get; set; }

        public string PrefVendor { get; set; }

        public string PurchaseCost { get; set; }

        public string PurchaseDesc { get; set; }

        public string QuantityOnHand { get; set; }

        public string QuantityOnOrder { get; set; }

        public string QuantityOnSalesOrder { get; set; }

        public string ReorderLevel { get; set; }

        public string ReplenishLevel { get; set; }

        public string SalesDesc { get; set; }

        public string SalesPrice { get; set; }

        public string SalesTaxCode { get; set; }

        public virtual ICollection<ItemAdjustment> ItemAdjustments { get; set; }

        public virtual ICollection<TxnLine> TxnLines { get; set; }
    }
}
