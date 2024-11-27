namespace ThePalaceMuseumWeb.EF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Voice")]
    public partial class Voice
    {
        public int id { get; set; }

        public string VoiceMessage { get; set; }

        public string VoiceResponse { get; set; }

        public string VoiceTime { get; set; }

        public string ProblemInquire { get; set; }

        public string ProblemAnswer { get; set; }
    }
}
