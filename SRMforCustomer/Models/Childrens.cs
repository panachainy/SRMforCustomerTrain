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
    
    public partial class Childrens
    {
        public int ChildrenId { get; set; }
        public string Username { get; set; }
        public string NationalID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public System.DateTime Birthdate { get; set; }
        public bool EducationStatus { get; set; }
        public System.DateTime DateModified { get; set; }
        public string LastModifiedByUser { get; set; }
        public int ActiveLevel { get; set; }
        public string Remark { get; set; }
    }
}