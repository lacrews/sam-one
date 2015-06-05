namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TxnLine
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        [Required]
        public string Rate { get; set; }

        [Required]
        public string Quantity { get; set; }

        [Required]
        public string Description { get; set; }

        public int TxnType { get; set; }

        public int? PurchaseId { get; set; }

        public int? OrderId { get; set; }

        public virtual Item Item { get; set; }

        public virtual Order Order { get; set; }

        public virtual Purchase Purchase { get; set; }
    }
}
