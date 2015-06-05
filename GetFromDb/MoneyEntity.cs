namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MoneyEntity
    {
        public MoneyEntity()
        {
            MoneyEntityTouches = new HashSet<MoneyEntityTouch>();
            Orders = new HashSet<Order>();
            Purchases = new HashSet<Purchase>();
            ShippingAddresses = new HashSet<ShippingAddress>();
        }

        public int Id { get; set; }

        public string AccountNumber { get; set; }

        public string Altphone { get; set; }

        public string BillAddr1 { get; set; }

        public string BillAddr2 { get; set; }

        public string BillAddr3 { get; set; }

        public string BillCity { get; set; }

        public string BillPostalCode { get; set; }

        public string BillState { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string Email { get; set; }

        public string Fax { get; set; }

        public string FirstName { get; set; }

        public bool IsActive { get; set; }

        public string LastName { get; set; }

        public int? LeadSourceId { get; set; }

        public string MiddleName { get; set; }

        public int? MoneyEntityType { get; set; }

        [Required]
        public string Name { get; set; }

        public string Phone { get; set; }

        public string ResaleNumber { get; set; }

        public string Salutation { get; set; }

        public string Suffix { get; set; }

        public int? TermId { get; set; }

        public virtual LeadSource LeadSource { get; set; }

        public virtual ICollection<MoneyEntityTouch> MoneyEntityTouches { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }

        public virtual ICollection<ShippingAddress> ShippingAddresses { get; set; }

        public virtual Term Term { get; set; }
    }
}
