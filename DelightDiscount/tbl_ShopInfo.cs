//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DelightDiscount
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ShopInfo
    {
        public long Id { get; set; }
        public string ShopName { get; set; }
        public string ShopLocation { get; set; }
        public string Address { get; set; }
        public Nullable<int> Rank { get; set; }
        public string Status { get; set; }
        public byte[] ShopLogo { get; set; }
        public string EntryBy { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
    }
}