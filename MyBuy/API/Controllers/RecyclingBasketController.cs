using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class RecyclingBasketController:ApiController
    {
        public DTO.RecyclingBasketDTO Get(int id)
        {
            BL.RecyclingBasketBL recyclingBasketBL = new BL.RecyclingBasketBL();
            return recyclingBasketBL.GetRecyclingBasket(id);
        }

        public List<DTO.RecyclingBasketDTO> Get()
        {
            BL.RecyclingBasketBL recyclingBasketBL = new BL.RecyclingBasketBL();
            return recyclingBasketBL.GetRecyclingBaskets();
        }
    }
}