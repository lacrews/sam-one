namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemAdjustment
    {
        public int Id { get; set; }

        public Guid AspUserId { get; set; }

        [Required]
        public string ChangeQuantity { get; set; }

        public int ItemId { get; set; }

        [Required]
        public string Memo { get; set; }

        [Required]
        public string RefNumber { get; set; }

        public DateTime TxnDate { get; set; }

        public virtual Item Item { get; set; }
    }
}
