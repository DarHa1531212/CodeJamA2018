namespace CodeJamA2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUser")]
    public partial class tblUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idemploye { get; set; }

        [Key]
        [StringLength(25)]
        public string noEmploye { get; set; }

        [Required]
        [StringLength(50)]
        public string prenomNom { get; set; }

        [Required]
        [StringLength(50)]
        public string motPasse { get; set; }

        public int gold { get; set; }

        public int xpTotal { get; set; }

        public DateTime dateEmbaudhe { get; set; }
    }
}
