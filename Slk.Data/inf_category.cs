namespace Slk.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class inf_category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public inf_category()
        {
            inf_article = new HashSet<inf_article>();
        }

        public int id { get; set; }

        public int? parent_id { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string subtitle { get; set; }

        public DateTime creation_date { get; set; }

        public int record_state { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inf_article> inf_article { get; set; }
    }
}
