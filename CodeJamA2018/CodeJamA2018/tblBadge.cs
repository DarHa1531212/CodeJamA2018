namespace CodeJamA2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBadge")]
    public partial class tblBadge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBadge()
        {
            tbluserBadge = new HashSet<tbluserBadge>();
        }

        [Key]
        public int idbadge { get; set; }

        [StringLength(100)]
        public string nombadge { get; set; }

        [StringLength(200)]
        public string descriptionbadge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbluserBadge> tbluserBadge { get; set; }
    }
}
