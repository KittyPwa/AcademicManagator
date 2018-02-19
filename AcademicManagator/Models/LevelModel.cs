using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;



namespace AcademicManagator.Models
{
    public class LevelModel
    {
        [Required]
        [DisplayName("l'id")]
        public System.Guid Id { get; set; }

        [Required]
        [DisplayName("le titre")]
        public string Title { get; set; }

        [Required]
        [DisplayName("l'id du cycle")]
        public System.Guid Cycle_Id { get; set; }

        [Required]
        [DisplayName("le cycle")]
        public virtual Cycles Cycles { get; set; }

        [Required]
        [DisplayName("la collection des eleves")]
        public virtual ICollection<Pupils> Pupils { get; set; }
    }
}