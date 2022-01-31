using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProofPurchaseDal
    {
        public int GetProofPurchase(int idAction, string idUser)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {
                    return db.ProofPurchases.Count(i => i.idAction == idAction && i.idUsers == idUser);
                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public List<ProofPurchase> GetProofPurchases(DTO.FilterProofDTO filterProofDTO)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {
                    List<ProofPurchase> list = new List<ProofPurchase>();
                    if (filterProofDTO.recycling == true)
                        list = db.ProofPurchases.Where(a => a.idAction == filterProofDTO.action && a.idBranch == filterProofDTO.branch && a.idCategory == filterProofDTO.category &&
                         a.idUsers == filterProofDTO.idUser 
                         && a.paymentId == filterProofDTO.kindOfPayment && a.date >= filterProofDTO.beginDate&& a.date <= filterProofDTO.endDate).ToList();
                     
                    
                    else
                        list = db.ProofPurchases.Where(a => a.idAction == filterProofDTO.action &&
                        a.idBranch == filterProofDTO.branch && a.idCategory == filterProofDTO.category
                        && a.idUsers == filterProofDTO.idUser && a.paymentId == filterProofDTO.kindOfPayment
                        && a.date >= filterProofDTO.beginDate && a.date <= filterProofDTO.endDate
                        && a.isActive == true).ToList();
                   
                    return list;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool PostProofPurchase(ProofPurchase proofPurchase)
        {
            using (MyBuyEntities db = new MyBuyEntities())
            {
                db.ProofPurchases.Add(proofPurchase);
                try
                {
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {

                    throw e;
                   
                }
            }
        }
    }
}
