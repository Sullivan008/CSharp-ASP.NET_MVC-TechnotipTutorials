//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HowToDisplayMultipleCheckBox.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SiteUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public Nullable<int> RoleID { get; set; }
    
        public virtual UserRole UserRole { get; set; }
    }
}
