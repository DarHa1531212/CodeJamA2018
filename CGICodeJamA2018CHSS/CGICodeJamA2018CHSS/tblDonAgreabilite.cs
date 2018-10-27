namespace CGICodeJamA2018CHSS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDonAgreabilite")]
    public partial class tblDonAgreabilite
    {
        [Key]
        public int idDonAgreabilite { get; set; }

        public int idEnvoyeur { get; set; }

        public int idReceveur { get; set; }

        public int qteGoldEnvoye { get; set; }

        public int idRaisonEnvoi { get; set; }

        [StringLength(200)]
        public string descriptionSupp { get; set; }

        [Column(TypeName = "date")]
        public DateTime dateEnvoi { get; set; }

        public virtual tblraisonAgreabilite tblraisonAgreabilite { get; set; }
    }
}
