using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{[System.Web.Http.Cors.EnableCors(origins:"*",headers:"*",methods:"*")]

    public class ActionController : ApiController
    {
        [HttpGet]
        [Route("api/Action/Get:id")]
        public DTO.ActionDTO Get(int id)
        {
            BL.ActionBL actionBL = new BL.ActionBL();
            return  actionBL.GetAction(id);
        }

        [HttpGet]
        [Route("api/Action/GetActions")]
        public List<DTO.ActionDTO> Get()
        {

            return new BL.ActionBL().GetActions();

        }
    }
}