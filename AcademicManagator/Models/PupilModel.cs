using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace AcademicManagator.Models
{
    public class PupilModel
    {
        [Required]
        [DisplayName("l'id")]
        public System.Guid Id { get; set; }

        [Required]
        [DisplayName("le prenom")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("le nom de famille")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("le sexe")]
        public short Sex { get; set; }

        [Required]
        [DisplayName("la date de naissance")]
        public System.DateTime BirthdayDate { get; set; }

        [Required]
        [DisplayName("l'etat")]
        public short State { get; set; }

        [Required]
        [DisplayName("l'id du tuteur")]
        public System.Guid Tutor_Id { get; set; }

        [Required]
        [DisplayName("l'id de la classroom")]
        public System.Guid Classroom_Id { get; set; }

        [Required]
        [DisplayName("l'id du niveau")]
        public System.Guid Level_Id { get; set; }

        [Required]
        [DisplayName("la salle de classe")]
        public virtual Classrooms Classrooms { get; set; }

        [Required]
        [DisplayName("le niveau")]
        public virtual Levels Levels { get; set; }

        [Required]
        [DisplayName("le tuteur")]
        public virtual Tutors Tutors { get; set; }

        [Required]
        [DisplayName("l'ensemble des resultats")]
        public virtual ICollection<Results> Results { get; set; }
    }
}