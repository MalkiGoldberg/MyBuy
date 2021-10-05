using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ManagerController : ApiController
    {

        public DTO.ManagersDTO Get(string id)
        {
            BL.ManagerBL managerBL = new BL.ManagerBL();
            return managerBL.GetManager(id);
        }
        public List<DTO.ManagersDTO> Get()
        {
            BL.ManagerBL managerBL = new BL.ManagerBL();
            return managerBL.GetManagers();
        }

        [HttpPost]
        [Route("api/Manager/Login")]
        public bool Login([FromBody] DTO.ManagersDTO managersDTO)
        {

            BL.ManagerBL managerBL = new BL.ManagerBL();
            return managerBL.Login(managersDTO);
        }

    }
}