using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class RecyclingBasketBL
    {
        public DTO.RecyclingBasketDTO GetRecyclingBasket(int id)
        {
            return Converts.RecyclingBasketConverts.GetRecyclingBasketDTOFromDal(new DAL.RecyclingBasketDal().GetRecyclingBasket(id));
        }

        public List<DTO.RecyclingBasketDTO> GetRecyclingBaskets()
        {
            return Converts.RecyclingBasketConverts.GetRecyclingBasketsDTOFromDal(new DAL.RecyclingBasketDal().GetRecyclingBaskets());
        }
    }
}
