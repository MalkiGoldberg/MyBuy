using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;

namespace API.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProofPurchaseController:ApiController
    {
        [HttpGet]
        [Route("api/ProofPurchase/GetNumberOfProofPruchase")]
        public int GetNumberOfProofPruchase(int idAction,string idUser)
        {
            BL.ProofPurchaseBL proofPurchaseBL = new BL.ProofPurchaseBL();
            return proofPurchaseBL.GetProofPurchase(idAction,idUser);
        }
        [HttpGet]
        [Route("api/ProofPurchase/GetProofPruchases")]
        public List<DTO.ProofPurchaseDTO> GetProofPruchases(string idUser,int kindOfPayment,int action,int category,
             int chainStore,int branch,DateTime beginDate,DateTime endDate,bool recycling)
        {
/*
            HttpPostedFile imageData = HttpContext.Current.Request.Files[0];
            imageData.SaveAs(HostingEnvironment.MapPath("/Images/"imageData.FileName));
*/

            DTO.FilterProofDTO filterProofDTO = new DTO.FilterProofDTO();
            filterProofDTO.action = action;
            filterProofDTO.beginDate = beginDate;
            filterProofDTO.branch = branch;
            filterProofDTO.category = category;
            filterProofDTO.chainStore = chainStore;
            filterProofDTO.endDate = endDate;
            filterProofDTO.idUser = idUser;
            filterProofDTO.kindOfPayment = kindOfPayment;
            filterProofDTO.recycling = recycling;
            BL.ProofPurchaseBL proofPurchaseBL = new BL.ProofPurchaseBL();
            return proofPurchaseBL.GetProofPurchases(filterProofDTO);
        }
        
    }
}