namespace EcoleLocale
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbModele : DbContext
    {
        public DbModele()
            : base("name=DbModele")
        {
        }

        public virtual DbSet<cours> cours { get; set; }
        public virtual DbSet<disponibilite> disponibilite { get; set; }
        public virtual DbSet<etudiant> etudiant { get; set; }
        public virtual DbSet<inscriptioncours> inscriptioncours { get; set; }
        public virtual DbSet<professeur> professeur { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cours>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<cours>()
                .Property(e => e.jour)
                .IsUnicode(false);

            modelBuilder.Entity<cours>()
                .Property(e => e.heures)
                .IsUnicode(false);

            modelBuilder.Entity<cours>()
                .Property(e => e.etatCours)
                .IsUnicode(false);

            modelBuilder.Entity<etudiant>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<etudiant>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<etudiant>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<etudiant>()
                .Property(e => e.courriel)
                .IsUnicode(false);

            modelBuilder.Entity<etudiant>()
                .Property(e => e.motDePasse)
                .IsUnicode(false);

            modelBuilder.Entity<professeur>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<professeur>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<professeur>()
                .Property(e => e.adresse)
                .IsUnicode(false);

            modelBuilder.Entity<professeur>()
                .Property(e => e.courriel)
                .IsUnicode(false);
        }
    }
}
