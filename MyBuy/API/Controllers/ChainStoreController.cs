using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ChainStoreController: ApiController
    {
        public DTO.ChainStoreDTO GetChainStore(int id)
        {
            BL.ChainStoreBL chainStoreBL = new BL.ChainStoreBL();
            return chainStoreBL.GetChainStore(id);
        }
        [HttpGet]
        [Route("api/GetChainStores")]
        public List<DTO.ChainStoreDTO> GetChainStores()
        {
            return new BL.ChainStoreBL().GetChainStores();
        }
    }
}