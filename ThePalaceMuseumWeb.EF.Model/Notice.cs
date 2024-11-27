namespace ThePalaceMuseumWeb.EF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notice")]
    public partial class Notice
    {
        public int id { get; set; }

        public string OpenTitle { get; set; }

        public string OpenContent { get; set; }

        public string OpenReleaseTime { get; set; }

        public string OpenPublishDepatment { get; set; }

        public string ActivitiesContent { get; set; }

        public string ActivitiesTime { get; set; }

        public string AcademicContent { get; set; }

        public string AcademicTime { get; set; }

        public string ConsultTitle { get; set; }

        public string ConsultContent { get; set; }

        public string ConsultTime { get; set; }
    }
}
