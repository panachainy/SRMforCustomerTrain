//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRMforCustomer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Marriages
    {
        public int SpouseId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int TitleCode { get; set; }
        public string NationalId { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public int Status { get; set; }
        public string DadName { get; set; }
        public string DadLastName { get; set; }
        public Nullable<int> DadTitleCode { get; set; }
        public string DadNationalId { get; set; }
        public Nullable<System.DateTime> DadBirthDate { get; set; }
        public string MomName { get; set; }
        public string MomLastName { get; set; }
        public Nullable<int> MomTitleCode { get; set; }
        public string MomNationalId { get; set; }
        public Nullable<System.DateTime> MomBirthDate { get; set; }
    
        public virtual MasterTypes MasterTypes { get; set; }
        public virtual MasterTypes MasterTypes1 { get; set; }
    }
}