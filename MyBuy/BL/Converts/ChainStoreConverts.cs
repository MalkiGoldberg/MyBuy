using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public static  class ChainStoreConverts
    {
        public static DTO.ChainStoreDTO GetChainStoreDTOFromDAL(DAL.ChainStore chainStore)
        {
            DTO.ChainStoreDTO chainStoreDTO = new DTO.ChainStoreDTO();
            chainStoreDTO.chainStoreId = chainStore.chainStoreId;
            chainStoreDTO.chainStoreName = chainStore.chainStoreName;
            chainStoreDTO.idManager = chainStore.idManager;
            return chainStoreDTO;
        }
        public static List<DTO.ChainStoreDTO> GetChainStoresDTOFromDAL(List<DAL.ChainStore> chainStores)
        {
            List<DTO.ChainStoreDTO> chainStoresDTO = new List<DTO.ChainStoreDTO>();
            foreach (var item in chainStores)
            {
                chainStoresDTO.Add(GetChainStoreDTOFromDAL(item));
            }
            return chainStoresDTO;
        }
    }
}
