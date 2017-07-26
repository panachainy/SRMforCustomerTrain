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
    
    public partial class vwAssets
    {
        public string AssetCode { get; set; }
        public string ParentAssetCode { get; set; }
        public string AssetName { get; set; }
        public string SerialNo { get; set; }
        public int BrandId { get; set; }
        public int AssetTypeId { get; set; }
        public string ModelNo { get; set; }
        public string Condition { get; set; }
        public int StatusId { get; set; }
        public System.DateTime DateReceived { get; set; }
        public string ReceiveBy { get; set; }
        public string ReferenceNo { get; set; }
        public decimal Price { get; set; }
        public Nullable<System.Guid> UserGUID { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string DepartmentName { get; set; }
        public string CreateByUser { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string ModifiedByUser { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string Remark { get; set; }
        public string Location { get; set; }
        public byte[] Image { get; set; }
        public string StatusName { get; set; }
        public string AssetTypeName { get; set; }
        public string BrandName { get; set; }
        public string ParentAssetTypeName { get; set; }
        public Nullable<int> ParentAssetTypeId { get; set; }
        public string ParentAssetName { get; set; }
        public bool IsCalculateDP { get; set; }
        public Nullable<int> QtyYearDP { get; set; }
        public Nullable<System.DateTime> DateStartDP { get; set; }
        public Nullable<bool> IsPCSet { get; set; }
        public string DepartmentCode { get; set; }
        public string AssetPartName { get; set; }
        public Nullable<int> AssetPartId { get; set; }
    }
}