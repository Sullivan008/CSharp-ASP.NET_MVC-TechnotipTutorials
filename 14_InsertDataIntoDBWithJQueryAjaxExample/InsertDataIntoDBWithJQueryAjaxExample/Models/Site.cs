//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InsertDataIntoDBWithJQueryAjaxExample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Site
    {
        public int SitesID { get; set; }
        public int EmployeeID { get; set; }
        public string SiteName { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
