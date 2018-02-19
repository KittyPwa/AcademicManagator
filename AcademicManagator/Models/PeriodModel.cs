using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace AcademicManagator.Models
{
    public class PeriodModel
    {
        [Required]
        [DisplayName("l'id")]
        public System.Guid Id { get; set; }

        [Required]
        [DisplayName("la date du debut")]
        public System.DateTime Begin { get; set; }

        [Required]
        [DisplayName("la date de fin")]
        public System.DateTime End { get; set; }

        [Required]
        [DisplayName("l'id de l'annee")]
        public System.Guid Year_Id { get; set; }

        [Required]
        [DisplayName("l'ensemble des evaluations")]
        public virtual ICollection<Evaluations> Evaluations { get; set; }

        [Required]
        [DisplayName("l'annee")]
        public virtual Years Years { get; set; }
    }
}