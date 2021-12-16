using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public static class ManagerConverts
    {
        public static DTO.ManagersDTO GetManagerDTOFromDal(DAL.Manager manager)
        {
            DTO.ManagersDTO managersDTO = new DTO.ManagersDTO();
            managersDTO.managerId = manager.managerId;
            managersDTO.firstName = manager.firstName;
            managersDTO.lastName = manager.lastName;
            managersDTO.mail = manager.mail;
            managersDTO.phone = manager.phone;
            managersDTO.password = manager.password;
            managersDTO.userName = manager.userName;
            return managersDTO;
        }

        public static List<DTO.ManagersDTO> GetManagersDTOFromDal(List<DAL.Manager> managers)
        {
            List<DTO.ManagersDTO> managersDTOs = new List<DTO.ManagersDTO>();
            foreach (var item in managers)
            {
                managersDTOs.Add(GetManagerDTOFromDal(item));
            }
            return managersDTOs;
        }
        public static DAL.Manager GetManagerDALFromDTO(DTO.ManagersDTO managerDTO)
        {
            DAL.Manager manager = new DAL.Manager();
            manager.managerId = managerDTO.managerId;
            manager.firstName = managerDTO.firstName;
            manager.lastName = managerDTO.lastName;
            manager.mail = managerDTO.mail;
            manager.phone = managerDTO.phone;
            manager.password = managerDTO.password;
            manager.userName = managerDTO.userName;
            return manager;
        }
    }
}
