namespace CodeJamA2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblXPGagne")]
    public partial class tblXPGagne
    {
        [Key]
        public int idGainXP { get; set; }

        public int idUser { get; set; }

        public DateTime dateXPGagne { get; set; }

        public int idCauseGainXP { get; set; }

        public int qteXPGagne { get; set; }

        public virtual tblGainXP tblGainXP { get; set; }
    }
}
