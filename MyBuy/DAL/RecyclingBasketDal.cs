using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class RecyclingBasketDal
    {

        public RecyclingBasket GetRecyclingBasket(int id)
        {
            try
            {
                using (MyBuyEntities db=new MyBuyEntities())
                {
                    return db.RecyclingBaskets.Single(i => i.recyclingBasketId==id);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<RecyclingBasket> GetRecyclingBaskets()
        {
            try
            {
                using (MyBuyEntities db=new MyBuyEntities())
                {
                    return db.RecyclingBaskets.ToList();
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
