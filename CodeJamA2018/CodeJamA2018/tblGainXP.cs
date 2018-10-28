namespace CodeJamA2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblGainXP")]
    public partial class tblGainXP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGainXP()
        {
            tblXPGagne = new HashSet<tblXPGagne>();
        }

        [Key]
        public int idCauseGain { get; set; }

        [Required]
        [StringLength(25)]
        public string nomCauseGain { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblXPGagne> tblXPGagne { get; set; }
    }
}
