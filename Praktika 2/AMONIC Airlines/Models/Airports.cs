//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMONIC_Airlines.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Airports
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Airports()
        {
            this.Routes = new HashSet<Routes>();
            this.Routes1 = new HashSet<Routes>();
        }
    
        public int ID { get; set; }
        public int CountryID { get; set; }
        public string IATACode { get; set; }
        public string Name { get; set; }
    
        public virtual Countries Countries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Routes> Routes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Routes> Routes1 { get; set; }
    }
}