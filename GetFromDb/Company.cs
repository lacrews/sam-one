namespace GetFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Company
    {
        public int Id { get; set; }

        [Required]
        public string Addr1 { get; set; }

        [Required]
        public string Addr2 { get; set; }

        [Required]
        public string Addr3 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string EIN { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Fax { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}
