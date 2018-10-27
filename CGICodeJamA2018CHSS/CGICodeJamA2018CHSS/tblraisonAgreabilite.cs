namespace CGICodeJamA2018CHSS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblraisonAgreabilite")]
    public partial class tblraisonAgreabilite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblraisonAgreabilite()
        {
            tblDonAgreabilite = new HashSet<tblDonAgreabilite>();
        }

        [Key]
        public int idRaison { get; set; }

        [Required]
        [StringLength(25)]
        public string nomRaison { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDonAgreabilite> tblDonAgreabilite { get; set; }
    }
}
