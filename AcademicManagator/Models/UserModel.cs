using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace AcademicManagator.Models
{
    public class UserModel
    {
        [Required]
        [DisplayName("l'id")]
        public System.Guid Id { get; set; }

        [Required]
        [DisplayName("le nom de l'utilisateur")]
        public string UserName { get; set; }

        [Required]
        [DisplayName("le mot de passe")]
        public string Password { get; set; }

        [Required]
        [DisplayName("le prenom")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("le nom de famille")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("l'email")]
        public string Mail { get; set; }

        [Required]
        [DisplayName("l'ensemble des salles de classe")]
        public virtual ICollection<Classrooms> Classrooms { get; set; }

        [Required]
        [DisplayName("l'ensemble des etablissements")]
        public virtual ICollection<Establishments> Establishments { get; set; }

        [Required]
        [DisplayName("l'ensemble des evaluation")]
        public virtual ICollection<Evaluations> Evaluations { get; set; }
    }
}