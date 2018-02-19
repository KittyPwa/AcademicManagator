using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace AcademicManagator.Models
{
    public class EvaluationModel
    {
        [Required]
        [DisplayName("l'id")]
        public System.Guid Id { get; set; }

        [Required]
        [DisplayName("l'id de la salle de classe")]
        public System.Guid Classroom_Id { get; set; }

        [Required]
        [DisplayName("l'id de l'utilisateur")]
        public System.Guid User_Id { get; set; }

        [Required]
        [DisplayName("l'id de la periode")]
        public System.Guid Period_Id { get; set; }

        [Required]
        [DisplayName("la date")]
        public System.DateTime Date { get; set; }

        [Required]
        [DisplayName("le total des points")]
        public int TotalPoint { get; set; }

        [Required]
        [DisplayName("la salle de classe")]
        public virtual Classrooms Classrooms { get; set; }

        [Required]
        [DisplayName("la period")]
        public virtual Periods Periods { get; set; }

        [Required]
        [DisplayName("l'utilisateur")]
        public virtual Users Users { get; set; }

        [Required]
        [DisplayName("l'ensemble des resultats")]
        public virtual ICollection<Results> Results { get; set; }
    }
}