namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log
    {
        public int Id { get; set; }

        [Required]
        public string AspUserId { get; set; }

        [Required]
        public string Note { get; set; }

        public DateTime TimeStamp { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
