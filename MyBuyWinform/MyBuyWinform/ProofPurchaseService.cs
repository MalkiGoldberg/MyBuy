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

        public void GenerateProofPurchase(int idAction, DateTime date,int category,string idUsers,
            string img,int numPayment,int paymentId,double sum)
        {
            ImageSevice imageSevice = new ImageSevice();
            img= imageSevice.ImgToBase64(img);

            PostProofPurchase(new ProofPurchase()
            {
                idAction = idAction,
                date = date,
                idCategory = category,
                idUsers = idUsers,
                img = img,
                isActive = true,
                numPayment = numPayment,
                paymentId = paymentId,
                sum = sum
            }) ;
        }
    }
}
