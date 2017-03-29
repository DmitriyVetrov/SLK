namespace Slk.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class inf_article_tag
    {
        public int id { get; set; }

        public int article_id { get; set; }

        public int tag_id { get; set; }

        public DateTime creation_date { get; set; }

        public int record_state { get; set; }
    }
}
