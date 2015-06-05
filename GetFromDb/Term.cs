namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Term
    {
        public Term()
        {
            MoneyEntities = new HashSet<MoneyEntity>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        [Required]
        public string Terms { get; set; }

        public virtual ICollection<MoneyEntity> MoneyEntities { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
