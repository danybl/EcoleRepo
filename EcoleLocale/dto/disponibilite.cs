namespace EcoleLocale
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ecole.disponibilite")]
    public partial class disponibilite
    {
        [Key]
        public int idDisponibilite { get; set; }

        public int? idProfesseur { get; set; }

        public bool lundi { get; set; }

        public bool mardi { get; set; }

        public bool mercredi { get; set; }

        public bool jeudi { get; set; }

        public bool vendredi { get; set; }

        public bool samedi { get; set; }

        public bool dimanche { get; set; }

        public virtual professeur professeur { get; set; }
    }
}
