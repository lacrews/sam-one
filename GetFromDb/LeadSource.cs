namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LeadSource
    {
        public LeadSource()
        {
            MoneyEntities = new HashSet<MoneyEntity>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<MoneyEntity> MoneyEntities { get; set; }
    }
}
