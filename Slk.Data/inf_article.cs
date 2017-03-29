namespace Slk.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class inf_article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public inf_article()
        {
            inf_article_picture = new HashSet<inf_article_picture>();
            inf_comment = new HashSet<inf_comment>();
        }

        public int id { get; set; }

        public string title { get; set; }

        public string body { get; set; }

        public int category_id { get; set; }

        public int user_id { get; set; }

        public DateTime creation_date { get; set; }

        public int record_state { get; set; }

        public string bg_image { get; set; }

        public string subtitle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inf_article_picture> inf_article_picture { get; set; }

        public virtual inf_category inf_category { get; set; }

        public virtual inf_user inf_user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inf_comment> inf_comment { get; set; }
    }
}
