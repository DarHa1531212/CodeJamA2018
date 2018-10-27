namespace CGICodeJamA2018CHSS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbluserBadge")]
    public partial class tbluserBadge
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idUser { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idBadge { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime dateObtention { get; set; }

        public virtual tblBadge tblBadge { get; set; }
    }
}
