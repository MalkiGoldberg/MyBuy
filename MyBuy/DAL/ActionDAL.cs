using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
 public   class ActionDAL
    {
        public Action GetAction(int actionId)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {

                    return db.Actions.Single(i => i.actionId == actionId);
                }
            }
            catch
            {
                throw;

            }
        }
        public List<Action> GetActions()
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {

                    return db.Actions.ToList();
                }

            }
            catch 
            {

                throw;
            }
        }
    }
}
