//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Movie_Booking
{
    using System;
    using System.Collections.Generic;
    
    public partial class movy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public movy()
        {
            this.bookings = new HashSet<booking>();
        }
    
        public int id { get; set; }
        public string mname { get; set; }
        public string mimg { get; set; }
        public string mdesc { get; set; }
        public string director { get; set; }
        public string casting { get; set; }
        public Nullable<int> price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<booking> bookings { get; set; }
    }
}