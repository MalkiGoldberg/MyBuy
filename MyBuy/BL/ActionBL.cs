using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ActionBL
    {
        public DTO.ActionDTO GetAction(int id)
        {
            return Converts.ActionConverts.GetActionDTOFromDAL(new DAL.ActionDAL().GetAction(id));
        }
        public List<DTO.ActionDTO> GetActions()
        {
            return Converts.ActionConverts.GetActionsDTOFromDAL(new DAL.ActionDAL().GetActions());
        }
    }
}
