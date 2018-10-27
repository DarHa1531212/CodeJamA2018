namespace CGICodeJamA2018CHSS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblNiveau")]
    public partial class tblNiveau
    {
        [Key]
        public int idNiveau { get; set; }

        public int xpMinNiveau { get; set; }
    }
}
