namespace EcoleLocale
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ecole.inscriptioncours")]
    public partial class inscriptioncours
    {
        [Key]
        public int idInscription { get; set; }

        public int? idCours { get; set; }

        public int? idEtudiant { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime dateInscription { get; set; }

        public double paiments { get; set; }

        public virtual cours cours { get; set; }

        public virtual etudiant etudiant { get; set; }
    }
}
