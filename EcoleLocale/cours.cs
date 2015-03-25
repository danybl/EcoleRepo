namespace EcoleLocale
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ecole.cours")]
    public partial class cours
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cours()
        {
            inscriptioncours = new HashSet<inscriptioncours>();
        }

        [Key]
        public int idCours { get; set; }

        [Required]
        [StringLength(45)]
        public string nom { get; set; }

        public int? idProfesseur { get; set; }

        public int dureeTotale { get; set; }

        public int dureeParJour { get; set; }

        public double prix { get; set; }

        [Required]
        [StringLength(10)]
        public string jour { get; set; }

        [Required]
        [StringLength(20)]
        public string heures { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime dateLimite { get; set; }

        public int nbInscriptionMin { get; set; }

        public int nbInscriptionMax { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime dateDebut { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime dateFin { get; set; }

        [Required]
        [StringLength(45)]
        public string etatCours { get; set; }

        public virtual professeur professeur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inscriptioncours> inscriptioncours { get; set; }
    }
}
