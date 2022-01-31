using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        public DTO.UsersDTO Get(string id)
        {
            BL.UserBL userBL = new BL.UserBL();
            return userBL.GetUser(id);
        }

        public List<DTO.UsersDTO> Get()
        {
            BL.UserBL usersBL = new BL.UserBL();
            return usersBL.GetUsers();
        }
        [HttpGet]
        [Route("api/User/Login")]
        public bool Login(string userName, string password)
        {
            DTO.UserDTO usersDTO = new DTO.UserDTO();
           usersDTO.userId = userName;
           usersDTO.password = password;
            return new BL.UserBL().Login(usersDTO);
        }
        [HttpPost]
        [Route("api/User/SignUp")]
        public bool SignUp([FromBody]DTO.UserDTO userDTO)
        {
            BL.UserBL userBL = new BL.UserBL();
            return userBL.SignUp(userDTO);
        }
    }
}