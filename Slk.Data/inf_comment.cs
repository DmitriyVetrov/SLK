namespace Slk.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class inf_comment
    {
        public int id { get; set; }

        [Required]
        public string body { get; set; }

        public int user_id { get; set; }

        public int article_id { get; set; }

        public DateTime creation_date { get; set; }

        public int record_state { get; set; }

        public virtual inf_article inf_article { get; set; }

        public virtual inf_user inf_user { get; set; }
    }
}
