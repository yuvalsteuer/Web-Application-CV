//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MegiddoLionsWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMember
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string PrimaryRole { get; set; }
        public string SecondaryRole { get; set; }
    
        public virtual tblUser tblUser { get; set; }
    }
}
