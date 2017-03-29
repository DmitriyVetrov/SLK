namespace Slk.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class inf_tag
    {
        public int id { get; set; }

        [Required]
        public string title { get; set; }

        public DateTime creation_date { get; set; }

        public int record_state { get; set; }
    }
}
