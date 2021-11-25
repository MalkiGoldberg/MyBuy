using DAL;
using DTO;
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
            proofPurchaseDTO.img = proofPurchase.img;
            return proofPurchaseDTO;
        }

        public static ProofPurchase GetProofPurchaseDalFromDTO(ProofPurchaseDTO proofPurchaseDTO)
        {
            ProofPurchase proofPurchase= new ProofPurchase();
            proofPurchase.proofPurchaseId = proofPurchaseDTO.proofPurchaseId;
            proofPurchase.idAction = proofPurchaseDTO.idAction;
            proofPurchase.idUsers = proofPurchaseDTO.idUsers;
            proofPurchase.idCategory = proofPurchaseDTO.idCategory;
            proofPurchase.date = proofPurchaseDTO.date;
            proofPurchase.isActive = proofPurchaseDTO.isActive;
            proofPurchase.paymentId = proofPurchaseDTO.paymentId;
            // proofPurchDTO.numPayment = proofPurchase.numPayment;
            proofPurchase.sum = proofPurchaseDTO.sum;
            proofPurchase.img = proofPurchaseDTO.img;
            return proofPurchase;
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
