namespace CodeJamA2018
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tblBadge> tblBadge { get; set; }
        public virtual DbSet<tblCheckIn> tblCheckIn { get; set; }
        public virtual DbSet<tblDonAgreabilite> tblDonAgreabilite { get; set; }
        public virtual DbSet<tblGainXP> tblGainXP { get; set; }
        public virtual DbSet<tblNiveau> tblNiveau { get; set; }
        public virtual DbSet<tblraisonAgreabilite> tblraisonAgreabilite { get; set; }
        public virtual DbSet<tblUser> tblUser { get; set; }
        public virtual DbSet<tblXPGagne> tblXPGagne { get; set; }
        public virtual DbSet<tbluserBadge> tbluserBadge { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblBadge>()
                .Property(e => e.nombadge)
                .IsUnicode(false);

            modelBuilder.Entity<tblBadge>()
                .Property(e => e.descriptionbadge)
                .IsUnicode(false);

            modelBuilder.Entity<tblBadge>()
                .HasMany(e => e.tbluserBadge)
                .WithRequired(e => e.tblBadge)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblDonAgreabilite>()
                .Property(e => e.descriptionSupp)
                .IsUnicode(false);

            modelBuilder.Entity<tblGainXP>()
                .Property(e => e.nomCauseGain)
                .IsUnicode(false);

            modelBuilder.Entity<tblGainXP>()
                .HasMany(e => e.tblXPGagne)
                .WithRequired(e => e.tblGainXP)
                .HasForeignKey(e => e.idCauseGainXP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblraisonAgreabilite>()
                .Property(e => e.nomRaison)
                .IsUnicode(false);

            modelBuilder.Entity<tblraisonAgreabilite>()
                .HasMany(e => e.tblDonAgreabilite)
                .WithRequired(e => e.tblraisonAgreabilite)
                .HasForeignKey(e => e.idRaisonEnvoi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.noEmploye)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.prenomNom)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.motPasse)
                .IsUnicode(false);
        }
    }
}
