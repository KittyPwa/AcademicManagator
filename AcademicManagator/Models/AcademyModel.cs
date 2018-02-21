using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AcademicManagator.Models
{
    public class AcademyModel
    {
        [Required]
        [DisplayName("l'id")]
        public System.Guid Id { get; set; }

        [Required]
        [DisplayName("le nom de l'academie")]
        public string Name { get; set; }

        [Required]
        [DisplayName("l'ensemble des etablissements")]
        public virtual ICollection<Establishments> Establishments { get; set; }
    }
}