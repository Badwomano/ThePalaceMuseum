namespace ThePalaceMuseumWeb.EF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cultural")]
    public partial class Cultural
    {
        public int id { get; set; }

        [Required]
        public string CulturalNumber { get; set; }

        [Required]
        public string CulturalName { get; set; }

        public string CulturalCategory { get; set; }

        [Required]
        public string CulturalAntique { get; set; }
    }
}
