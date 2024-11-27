namespace ThePalaceMuseumWeb.EF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CollectCategory")]
    public partial class CollectCategory
    {
        public int id { get; set; }

        [Required]
        public string CollectImg { get; set; }

        [Column("CollectCategory")]
        [Required]
        public string CollectCategory1 { get; set; }

        [Required]
        public string CollectNum { get; set; }
    }
}
