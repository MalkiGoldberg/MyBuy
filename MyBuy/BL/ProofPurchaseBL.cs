using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public  class ProofPurchaseBL
    {
        public int GetProofPurchase(int idAction,string idUser)
        {
            
            return new DAL.ProofPurchaseDal().GetProofPurchase(idAction,idUser);
        }
        public List<DTO.ProofPurchaseDTO> GetProofPurchases(DTO.FilterProofDTO filterProofDTO)
        {
            return Converts.ProofPurchaseConverts.GetProofPurchasesDTOFromDal(new DAL.ProofPurchaseDal().GetProofPurchases(filterProofDTO));
        }

        public bool PostProofPurchases(ProofPurchaseDTO ProofPurchase)
        {
            return new DAL.ProofPurchaseDal().PostProofPurchase(Converts.ProofPurchaseConverts.GetProofPurchaseDalFromDTO(ProofPurchase));
                

        }
    }
}
