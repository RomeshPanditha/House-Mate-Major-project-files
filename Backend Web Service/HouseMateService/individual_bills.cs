//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HouseMateService
{
    using System;
    using System.Collections.Generic;
    
    public partial class individual_bills
    {
        public int PK_indivBillID { get; set; }
        public int FK_houseBillID { get; set; }
        public int FK_tenantID { get; set; }
        public Nullable<double> splitAmount { get; set; }
        public Nullable<System.DateTime> datePaid { get; set; }
        public byte[] recurring_ { get; set; }
    
        public virtual house_bill house_bill { get; set; }
        public virtual tenant tenant { get; set; }
    }
}