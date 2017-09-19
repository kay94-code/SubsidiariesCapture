//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Association
    {
        public int AssocID { get; set; }
        public int CompanyID { get; set; }
        public int AssocType { get; set; }
        public double AssPercent { get; set; }
        public string DirectRel { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public System.DateTime ChangeDate { get; set; }
        public int NoShares_YN { get; set; }
    
        public virtual AssociationType AssociationType { get; set; }
        public virtual CompanyName CompanyName { get; set; }
        public object Exchange { get; internal set; }
        public object CompanyType { get; internal set; }
    }
}
