//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SystemMngmt.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public Patient()
        {
            this.Diagnostics = new HashSet<Diagnostic>();
        }
    
        public string Patient_ID { get; set; }
        public string Name { get; set; }
        public System.DateTime Birth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
    
        public virtual ICollection<Diagnostic> Diagnostics { get; set; }
    }
}
