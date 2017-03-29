namespace Slk.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class inf_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public inf_user()
        {
            inf_article = new HashSet<inf_article>();
            inf_comment = new HashSet<inf_comment>();
        }

        public int id { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string pass { get; set; }

        public string avatar { get; set; }

        public DateTime creation_date { get; set; }

        public int record_state { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inf_article> inf_article { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inf_comment> inf_comment { get; set; }
    }
}
