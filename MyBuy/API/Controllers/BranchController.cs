using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BranchController : ApiController
    {
        [HttpGet]
        [Route("api/Branch/GetBranch")]
        public DTO.BranchDTO Get(int id)
        {
            BL.BranchBL branchBL = new BL.BranchBL();
            return branchBL.GetBranch(id);
        }
        [HttpGet]
        [Route("api/Branch/GetBranches")]
        public List<DTO.BranchDTO> GetBranches()
        {
            return new BL.BranchBL().GetBranches();
        }
        [HttpGet]
        [Route("api/Branch/SignUp")]
        public DTO.BranchDTO SignUp(string userName,string password)
        {
            DTO.BranchDTO branchDTO = new DTO.BranchDTO();
            branchDTO.userName = userName;
            branchDTO.password = password;
            branchDTO= new BL.BranchBL().SignUp(branchDTO);
            //branchDTO.userName = userName;
            //branchDTO.password = password;
            return branchDTO;
        }
        [HttpPost]
        [Route("api/Branch/AddBranch")]
        public bool AddBranch(DTO.BranchDTO branchDTO)
        { BL.BranchBL branchBL = new BL.BranchBL();
            return branchBL.AddBranch(branchDTO);
        }

        [HttpPost]
        [Route("api/Branch/SignUpBranch")]
        public bool SignUpBranch([FromBody]DTO.BranchDTO branchDTO)
        {
            BL.BranchBL branchBL = new BL.BranchBL();
            return branchBL.SignUpBranch(branchDTO);
        }

    }
}