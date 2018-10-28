namespace CodeJamA2018
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCheckIn")]
    public partial class tblCheckIn
    {
        [Key]
        public int idCheckIn { get; set; }

        public int idUser { get; set; }

        public bool accepte { get; set; }

        public DateTime dateCheckIn { get; set; }
    }
}
