namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public Order()
        {
            TxnLines = new HashSet<TxnLine>();
        }

        public int Id { get; set; }

        public string BillAddr1 { get; set; }

        public string BillAddr2 { get; set; }

        public string BillAddr3 { get; set; }

        public string BillCity { get; set; }

        public string BillPostalCode { get; set; }

        public string BillState { get; set; }

        public string CustomerSalesTaxCode { get; set; }

        public DateTime? DueDate { get; set; }

        public string FOB { get; set; }

        public int FulfillmentStatusId { get; set; }

        [Required]
        public string IsFullyInvoiced { get; set; }

        [Required]
        public string IsManuallyClosed { get; set; }

        public string ItemSalesTax { get; set; }

        public string Memo { get; set; }

        public int MoneyEntityId { get; set; }

        public string PONumber { get; set; }

        public string RefNumber { get; set; }

        public int? SalesRepId { get; set; }

        public string SalesTaxPercentage { get; set; }

        public string SalesTaxTotal { get; set; }

        public string ShippingAddr1 { get; set; }

        public string ShippingAddr2 { get; set; }

        public string ShippingAddr3 { get; set; }

        public string ShippingCity { get; set; }

        public string ShippingPostalCode { get; set; }

        public string ShippingState { get; set; }

        public DateTime? ShippingDate { get; set; }

        public string ShippingMethod { get; set; }

        public int? TermId { get; set; }

        public DateTime? TxnDate { get; set; }

        public string TxnNumber { get; set; }

        public virtual FulfillmentStatu FulfillmentStatu { get; set; }

        public virtual MoneyEntity MoneyEntity { get; set; }

        public virtual ICollection<TxnLine> TxnLines { get; set; }

        public virtual SalesRep SalesRep { get; set; }

        public virtual Term Term { get; set; }
    }
}
