using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace AcademicManagator.Models
{
    public class CycleModel
    {
        [Required]
        [DisplayName("l'id")]
        public System.Guid Id { get; set; }

        [Required]
        [DisplayName("le titre du cycle")]
        public string Title { get; set; }

        [Required]
        [DisplayName("la collection des niveaux")]
        public virtual ICollection<Levels> Levels { get; set; }
    }
}