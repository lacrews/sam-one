namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FulfillmentStatu
    {
        public FulfillmentStatu()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        [Required]
        public string Status { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
