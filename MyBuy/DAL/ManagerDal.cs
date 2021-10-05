using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManagerDal
    {
        public Manager GetManager(string id)
        {
            try
            {
                using (MyBuyEntities db=new MyBuyEntities())
                {
                    return db.Managers.Single(i => i.managerId == id);
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Manager> GetManagers()
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {
                    return db.Managers.ToList();
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
        public bool Login(Manager manager)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {
                    db.Managers.Add(manager);
                    db.SaveChanges();
                    return true;
                }
            }
            catch(Exception)
            
            {
                throw;
                return false;
            }
        }
    }
}
