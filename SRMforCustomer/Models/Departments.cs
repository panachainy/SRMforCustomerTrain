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
    
    public partial class Departments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Departments()
        {
            this.UserInfo = new HashSet<UserInfo>();
        }
    
        public int CompanyCode { get; set; }
        public Nullable<int> CompaySiteCode { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string DivisionCode { get; set; }
        public string DepartmentCode { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCodeName { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> ManPowerCEO { get; set; }
        public Nullable<int> ManPowerE3 { get; set; }
        public Nullable<int> ManPowerE2 { get; set; }
        public Nullable<int> ManPowerE1 { get; set; }
        public Nullable<int> ManPowerM3 { get; set; }
        public Nullable<int> ManPowerM2 { get; set; }
        public Nullable<int> ManPowerM1 { get; set; }
        public Nullable<int> ManPowerO3 { get; set; }
        public Nullable<int> ManPowerO2 { get; set; }
        public Nullable<int> ManPowerO1 { get; set; }
        public Nullable<int> ManPowerS { get; set; }
        public Nullable<int> ManPowerP { get; set; }
        public Nullable<int> DepartmentGroup { get; set; }
    
        public virtual Divisions Divisions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}