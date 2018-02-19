using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace AcademicManagator.Models
{
    public class EstablishmentModel
    {
        [Required]
        [DisplayName("l'id")]
        public System.Guid Id { get; set; }

        [Required]
        [DisplayName("le nom")]
        public string Name { get; set; }

        [Required]
        [DisplayName("l'adresse")]
        public string Address { get; set; }

        [Required]
        [DisplayName("le code postal")]
        public string PostCode { get; set; }

        [Required]
        [DisplayName("la ville")]
        public string Town { get; set; }

        [Required]
        [DisplayName("l'id du l'utilisateur")]
        public System.Guid User_Id { get; set; }

        [Required]
        [DisplayName("l'id de l'academie")]
        public System.Guid Academie_Id { get; set; }

        [Required]
        [DisplayName("l'academie")]
        public virtual Academies Academies { get; set; }

        [Required]
        [DisplayName("l'ensemble des salles de classe")]
        public virtual ICollection<Classrooms> Classrooms { get; set; }

        [Required]
        [DisplayName("l'utilisateur")]
        public virtual Users Users { get; set; }
    }
}