//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcademicManagator.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Classrooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Classrooms()
        {
            this.Evaluations = new HashSet<Evaluations>();
            this.Pupils = new HashSet<Pupils>();
        }
    
        public System.Guid Id { get; set; }
        public string Title { get; set; }
        public System.Guid User_Id { get; set; }
        public System.Guid Year_Id { get; set; }
        public System.Guid Establishment_Id { get; set; }
    
        public virtual Establishments Establishments { get; set; }
        public virtual Users Users { get; set; }
        public virtual Years Years { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evaluations> Evaluations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pupils> Pupils { get; set; }
    }
}
