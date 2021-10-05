using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ChainStoreDAL
    {
        public ChainStore GetChainStore(int chainStoreId)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {

                    return db.ChainStores.Single(i => i.chainStoreId == chainStoreId);
                }
            }
            catch
            {
                throw;

            }
        }
        public List<ChainStore> GetChainStores()
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {

                    return db.ChainStores.ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
