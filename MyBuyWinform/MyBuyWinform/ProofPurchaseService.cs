using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBuyWinform
{
  public  class ProofPurchaseService
    {
      public bool PostProofPurchase(ProofPurchase proofPurchase)
        {
            var client = new RestClient("https://localhost:44391/api/ProofPurchase");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(proofPurchase);
            IRestResponse response = client.Execute(request);
            return response.IsSuccessful;

        }


    }
}
