using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProofPurchaseDTO
    {
        public int proofPurchaseId { get; set; }
        public int idAction { get; set; }
        public string idUsers { get; set; }
        public Nullable<int> idCategory { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<bool> isActive { get; set; }
        public int paymentId { get; set; }
        public Nullable<int> numPayment { get; set; }
        public double sum { get; set; }

    }
}
