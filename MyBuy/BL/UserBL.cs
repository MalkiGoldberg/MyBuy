using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    //try git
    public  class UserBL
    {
        public DTO.UsersDTO GetUser(string id)
        {
            return Converts.UserConverts.GetUserDTOFromDal(new DAL.UserDal().GetUser(id));
        }

        public List<DTO.UsersDTO> GetUsers()
        {
            return Converts.UserConverts.GetUsersDTOFromDal(new DAL.UserDal().GetUsers());
        }
    }
}
