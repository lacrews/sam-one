namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReceiptStatu
    {
        public ReceiptStatu()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }

        [Required]
        public string Status { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
