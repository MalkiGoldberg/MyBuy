//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProofPurchase
    {
        public int proofPurchaseId { get; set; }
        public int idAction { get; set; }
        public string idUsers { get; set; }
        public int idBranch { get; set; }
        public Nullable<int> idCategory { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<bool> isActive { get; set; }
        public int paymentId { get; set; }
        public double sum { get; set; }
        public string numPayment { get; set; }
    
        public virtual Action Action { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Category Category { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual User User { get; set; }
    }
}
