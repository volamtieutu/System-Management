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
    
    public partial class Timework
    {
        public string timework_id { get; set; }
        public string session { get; set; }
        public System.TimeSpan begin_time { get; set; }
        public System.TimeSpan end_time { get; set; }
    }
}
