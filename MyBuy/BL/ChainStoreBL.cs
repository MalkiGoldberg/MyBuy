using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ChainStoreBL
    {
        public DTO.ChainStoreDTO  GetChainStore(int id)
        {

            return Converts.ChainStoreConverts.GetChainStoreDTOFromDAL(new DAL.ChainStoreDAL().GetChainStore(id));
        }
        public List<DTO.ChainStoreDTO> GetChainStores()
        {
            return Converts.ChainStoreConverts.GetChainStoresDTOFromDAL(new DAL.ChainStoreDAL().GetChainStores());
        }
    }
}
