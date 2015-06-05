namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MoneyEntityTouch
    {
        public int Id { get; set; }

        public Guid? AspNetUserId { get; set; }

        public string Comment { get; set; }

        public DateTime? DateCreated { get; set; }

        public int MoneyEntityId { get; set; }

        public DateTime? ScheduledDate { get; set; }

        public int? Status { get; set; }

        public virtual MoneyEntity MoneyEntity { get; set; }
    }
}
