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
    
    public partial class PeriodDetails
    {
        public int PeriodId { get; set; }
        public int ShiftOrder { get; set; }
        public string Day { get; set; }
        public Nullable<int> ShiftId { get; set; }
    
        public virtual Periods Periods { get; set; }
        public virtual Shifts Shifts { get; set; }
    }
}