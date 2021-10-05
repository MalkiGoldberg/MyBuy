using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public static class ActionConverts
    {
        public static DTO.ActionDTO GetActionDTOFromDAL(DAL.Action action)
        {
            DTO.ActionDTO actionDTO = new DTO.ActionDTO();
            actionDTO.actionId = action.actionId;
            actionDTO.typeAction = action.typeAction;
            return actionDTO;
        }
        public static List<DTO.ActionDTO> GetActionsDTOFromDAL(List<DAL.Action> actions)
        {
            List<DTO.ActionDTO> actionDTOs = new List<DTO.ActionDTO>();
            foreach (var item in actions)
            {
            actionDTOs.Add(GetActionDTOFromDAL(item));
            }
            return actionDTOs;
        }
    }
}
