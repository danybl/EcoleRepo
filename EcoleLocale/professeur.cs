namespace EcoleLocale
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ecole.professeur")]
    public partial class professeur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public professeur()
        {
            cours = new HashSet<cours>();
            disponibilite = new HashSet<disponibilite>();
        }

        [Key]
        public int idProfesseur { get; set; }

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
        public DateTime dateEmbauche { get; set; }

        public int? idCoursPossible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cours> cours { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<disponibilite> disponibilite { get; set; }
    }
}
