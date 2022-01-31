using DTO;
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
        public bool Login (DTO.UserDTO userDTO)
        {
            DAL.User  user= Converts.UserConverts.GetUserDALFromDTO(userDTO);
            DAL.UserDal userDAL = new DAL.UserDal();
            return userDAL.Login(user);
             
        }

        public bool SignUp(UserDTO userDTO)
        {
            DAL.User user = Converts.UserConverts.GetUserDALFromDTO(userDTO);
            DAL.UserDal userDal = new DAL.UserDal();
            return userDal.SignUp(user);
        }
       
    }
}
