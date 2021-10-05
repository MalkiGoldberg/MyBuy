using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public static class ProofPurchaseConverts
    {
        public static DTO.ProofPurchaseDTO GetProofPurchaseDTOFromDal(DAL.ProofPurchase proofPurchase)
        {
            DTO.ProofPurchaseDTO proofPurchaseDTO = new DTO.ProofPurchaseDTO();
            proofPurchaseDTO.proofPurchaseId = proofPurchase.proofPurchaseId;
            proofPurchaseDTO.idAction = proofPurchase.idAction;
            proofPurchaseDTO.idUsers = proofPurchase.idUsers;
            proofPurchaseDTO.idCategory = proofPurchase.idCategory;
            proofPurchaseDTO.date = proofPurchase.date;
            proofPurchaseDTO.isActive = proofPurchase.isActive;
            proofPurchaseDTO.paymentId = proofPurchase.paymentId;
           // proofPurchaseDTO.numPayment = proofPurchase.numPayment;
            proofPurchaseDTO.sum = proofPurchase.sum;
            return proofPurchaseDTO;
        }

        public static List<DTO.ProofPurchaseDTO> GetProofPurchasesDTOFromDal(List<DAL.ProofPurchase>proofPurchases)
        {
            List<DTO.ProofPurchaseDTO> proofPurchaseDTOs = new List<DTO.ProofPurchaseDTO>();
            foreach (var item in proofPurchases)
            {
                proofPurchaseDTOs.Add(GetProofPurchaseDTOFromDal(item));
            }
            return proofPurchaseDTOs;
        }
    }
}
