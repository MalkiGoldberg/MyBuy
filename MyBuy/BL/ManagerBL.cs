using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ManagerBL
    {
        public DTO.ManagersDTO GetManager(string id)
        {
            return Converts.ManagerConverts.GetManagerDTOFromDal(new DAL.ManagerDal().GetManager(id));
        }

        public List<DTO.ManagersDTO> GetManagers()
        {
            return Converts.ManagerConverts.GetManagersDTOFromDal(new DAL.ManagerDal().GetManagers());
        }
  public bool Login(DTO.ManagersDTO manager)
        {DAL.Manager manager1= Converts.ManagerConverts.GetManagerDALFromDTO(manager);
            DAL.ManagerDal managerDal = new DAL.ManagerDal();
            return managerDal.Login(manager1);
        }
        public string SignUp(DTO.ManagersDTO managersDTO)
        {
            DAL.Manager m = Converts.ManagerConverts.GetManagerDALFromDTO(managersDTO);
            DAL.ManagerDal managerDAL = new DAL.ManagerDal();
              return  managerDAL.SignUp(m);
          
        }
    }
}
