using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace AcademicManagator.Models
{
    public class ResultModel
    {
        [Required]
        [DisplayName("l'id")]
        public System.Guid Evaluation_Id { get; set; }

        [Required]
        [DisplayName("l'id de l'eleve")]
        public System.Guid Pupil_Id { get; set; }

        [Required]
        [DisplayName("la note")]
        public double Note { get; set; }

        [Required]
        [DisplayName("l'evalutation")]
        public virtual Evaluations Evaluations { get; set; }

        [Required]
        [DisplayName("l'eleve")]
        public virtual Pupils Pupils { get; set; }
    }
}