using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MyBuyWinform
{

    class ControlerService
    {
        List<Action> actions = new List<Action>();

        private static readonly HttpClient client = new HttpClient();
        //static async Task<Action> GetProductAsync(string path)
        //{
        //    Action product = null;
        //    HttpResponseMessage response = await client.GetAsync(path);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        product = await response.Content.ReadAsAsync<Action>();
        //    }
        //    return product;
        //}

        public List<Action> GetActions()
        {
            HttpClient client = new HttpClient();
            List<Action> lstActions = new List<Action>();
            client.BaseAddress = new Uri("https://localhost:44391/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // List all Names.
            HttpResponseMessage response = client.GetAsync("api/Action/GetActions").Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                var products = response.Content.ReadAsStringAsync().Result;
                lstActions= JsonConvert.DeserializeObject<List<Action>>(products);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            return lstActions;
            
        }
        private string BASE_URL = "https://localhost:44391/";

        public Task<HttpResponseMessage> find()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return client.GetAsync("api/Action/GetActions");
            }
            catch
            {
                return null;
            }
        }
    }
}
