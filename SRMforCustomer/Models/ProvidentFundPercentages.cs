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
    
    public partial class ProvidentFundPercentages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProvidentFundPercentages()
        {
            this.ProvidentFunds = new HashSet<ProvidentFunds>();
        }
    
        public int ProvidentFundPercentageId { get; set; }
        public int ProvidentFundTypeId { get; set; }
        public int LengthInMinMonth { get; set; }
        public int LengthInMaxMonth { get; set; }
        public int MinRankTypeId { get; set; }
        public int MaxRankTypeId { get; set; }
        public double PercentageEmp { get; set; }
        public double PercentageComp { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
    
        public virtual MasterTypes MasterTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvidentFunds> ProvidentFunds { get; set; }
    }
}