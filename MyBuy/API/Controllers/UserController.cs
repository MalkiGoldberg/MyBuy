using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
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
    }
}