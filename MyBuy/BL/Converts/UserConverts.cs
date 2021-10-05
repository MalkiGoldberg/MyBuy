using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
  public static class UserConverts
    {
        public static DTO.UsersDTO GetUserDTOFromDal(DAL.User user)
        {
            DTO.UsersDTO usersDTO = new DTO.UsersDTO();
            usersDTO.address = user.address;
            usersDTO.city = user.city;
            usersDTO.firstName = user.firstName;
            usersDTO.lastName = user.lastName;
            usersDTO.mail = user.mail;
            usersDTO.password = user.password;
            usersDTO.phone = user.phone;
            usersDTO.userId = user.userId;
            return usersDTO;
        }

        public static List<DTO.UsersDTO> GetUsersDTOFromDal(List<DAL.User> users)
        {
            List<DTO.UsersDTO> usersDTOs = new List<DTO.UsersDTO>();
            foreach (var item in users)
            {
                usersDTOs.Add(GetUserDTOFromDal(item));
            }
            return usersDTOs;
        }
    }
}
