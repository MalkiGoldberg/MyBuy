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
            string url =  System.Configuration.ConfigurationManager.AppSettings["urlApi"];
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(proofPurchase);
            IRestResponse response = client.Execute(request);
            return response.IsSuccessful;

        }

        public void GenerateProofPurchase()
        {
            ImageSevice imageSevice = new ImageSevice();
            string b = imageSevice.ImgToBase64("c:\\IMG_1271 copy.jpg");
          
            PostProofPurchase(new ProofPurchase()
            {
                idAction = 1,
                date = new DateTime(),
                idCategory = 1,
                idUsers = "212124044",
                img = b,
                isActive = true,
                numPayment = 3,
                paymentId = 1,
                proofPurchaseId = 1,
                sum = 30
            });
        }
    }
}
