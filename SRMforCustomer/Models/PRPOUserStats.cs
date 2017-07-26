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
    
    public partial class PRPOUserStats
    {
        public int YearNo { get; set; }
        public string UserName { get; set; }
        public short TotalPRIRequested { get; set; }
        public short TotalPRIsApproved { get; set; }
        public short TotalPRIsRequested { get; set; }
        public short TotalPRIApproved { get; set; }
        public short TotalPOIsCompleted { get; set; }
        public short TotalFFIsCompleted { get; set; }
        public Nullable<double> SumHoursTakenIsProcessed { get; set; }
        public Nullable<double> MaxHoursTakenIsProcessed { get; set; }
        public Nullable<double> SumHoursTakenIProcessed { get; set; }
        public Nullable<double> MaxHoursTakenIProcessed { get; set; }
        public Nullable<double> SumPOHoursTakenIsCompleted { get; set; }
        public Nullable<double> MaxPOHoursTakenIsCompleted { get; set; }
        public Nullable<double> SumFFHoursTakenIsCompleted { get; set; }
        public Nullable<double> MaxFFHoursTakenIsCompleted { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}