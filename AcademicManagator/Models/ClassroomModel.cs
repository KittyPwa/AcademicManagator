using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace AcademicManagator.Models
{
    public class ClassroomModel
    {
        [Required]
        [DisplayName("l'id")]
        public System.Guid Id { get; set; }

        [Required]
        [DisplayName("le titre")]
        public string Title { get; set; }

        [Required]
        [DisplayName("l'id du professeur referant")]
        public System.Guid User_Id { get; set; }

        [Required]
        [DisplayName("l'id de l'annee")]
        public System.Guid Year_Id { get; set; }

        [Required]
        [DisplayName("l'id de l'etablissement")]
        public System.Guid Establishment_Id { get; set; }

        [Required]
        [DisplayName("l'etablissement")]
        public virtual Establishments Establishments { get; set; }

        [Required]
        [DisplayName("l'usager")]
        public virtual Users Users { get; set; }

        [Required]
        [DisplayName("l'annee")]
        public virtual Years Years { get; set; }

        [Required]
        [DisplayName("l'ensemble des evaluations")]
        public virtual ICollection<Evaluations> Evaluations { get; set; }

        [Required]
        [DisplayName("l'ensemble des eleves")]
        public virtual ICollection<Pupils> Pupils { get; set; }
    }
}