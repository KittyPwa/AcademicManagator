using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace AcademicManagator.Models
{
    public class TutorModel
    {
        [Required]
        [DisplayName("l'id")]
        public System.Guid Id { get; set; }

        [Required]
        [DisplayName("le nom")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("le prenom")]
        public string FirstName { get; set; }

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
        [DisplayName("le telephone")]
        public string Tel { get; set; }

        [Required]
        [DisplayName("le mail")]
        public string Mail { get; set; }

        [Required]
        [DisplayName("le commentaire")]
        public string Comment { get; set; }

        [Required]
        [DisplayName("l'ensemble des eleves")]
        public virtual ICollection<Pupils> Pupils { get; set; }
    }
}