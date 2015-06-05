namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ShippingAddress
    {
        public int Id { get; set; }

        public int MoneyEntityId { get; set; }

        public string ShippingAddr1 { get; set; }

        public string ShippingAddr2 { get; set; }

        public string ShippingAddr3 { get; set; }

        public string ShippingCity { get; set; }

        public string ShippingPostal { get; set; }

        public string ShippingState { get; set; }

        public virtual MoneyEntity MoneyEntity { get; set; }
    }
}
