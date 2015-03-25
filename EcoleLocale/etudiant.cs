namespace EcoleLocale
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ecole.etudiant")]
    public partial class etudiant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public etudiant()
        {
            inscriptioncours = new HashSet<inscriptioncours>();
        }

        [Key]
        public int idEtudiant { get; set; }

        [Required]
        [StringLength(45)]
        public string nom { get; set; }

        [Required]
        [StringLength(45)]
        public string prenom { get; set; }

        [Required]
        [StringLength(100)]
        public string adresse { get; set; }

        public int telephone { get; set; }

        [Required]
        [StringLength(45)]
        public string courriel { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime dateInscription { get; set; }

        [Required]
        [StringLength(128)]
        public string motDePasse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inscriptioncours> inscriptioncours { get; set; }
    }
}
