namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Purchase
    {
        public Purchase()
        {
            TxnLines = new HashSet<TxnLine>();
        }

        public int Id { get; set; }

        public string DueDate { get; set; }

        public string ExpectedDate { get; set; }

        public string FOB { get; set; }

        [Required]
        public string IsFullyReceived { get; set; }

        [Required]
        public string IsManuallyClosed { get; set; }

        public string Memo { get; set; }

        public int MoneyEntityId { get; set; }

        public int ReceiptStatusId { get; set; }

        public string RefNumber { get; set; }

        public string ReleaseDate { get; set; }

        public string SalesTaxTotal { get; set; }

        public string ShipMethod { get; set; }

        public string ShipToEntity { get; set; }

        public string TxnDate { get; set; }

        public string TxnId { get; set; }

        public string TxnNumber { get; set; }

        public virtual MoneyEntity MoneyEntity { get; set; }

        public virtual ICollection<TxnLine> TxnLines { get; set; }

        public virtual ReceiptStatu ReceiptStatu { get; set; }
    }
}
