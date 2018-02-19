using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace AcademicManagator.Models
{
    public class YearModel
    {
        [Required]
        [DisplayName("l'id")]
        public System.Guid Id { get; set; }

        [Required]
        [DisplayName("l'annee")]
        public int Year { get; set; }

        [Required]
        [DisplayName("l'ensemble des salles de classe")]
        public virtual ICollection<Classrooms> Classrooms { get; set; }

        [Required]
        [DisplayName("l'ensemble des periodes")]
        public virtual ICollection<Periods> Periods { get; set; }
    }
}