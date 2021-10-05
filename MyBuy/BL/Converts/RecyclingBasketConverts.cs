using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public static class RecyclingBasketConverts
    {
        public static DTO.RecyclingBasketDTO GetRecyclingBasketDTOFromDal(DAL.RecyclingBasket recyclingBasket)
        {
            DTO.RecyclingBasketDTO recyclingBasketDTO = new DTO.RecyclingBasketDTO();
            recyclingBasketDTO.idProofPurchase = recyclingBasket.idPoofPurchase;
            recyclingBasketDTO.recyclingBasketId = recyclingBasket.recyclingBasketId;
            return recyclingBasketDTO;
        }

        public static List<DTO.RecyclingBasketDTO> GetRecyclingBasketsDTOFromDal(List<DAL.RecyclingBasket> recyclingBaskets)
        {
            List<DTO.RecyclingBasketDTO> recyclingBasketDTOs = new List<DTO.RecyclingBasketDTO>();
            foreach (var item in recyclingBaskets)
            {
                recyclingBasketDTOs.Add(GetRecyclingBasketDTOFromDal(item));
            }
            return recyclingBasketDTOs;
        }
    }
}
