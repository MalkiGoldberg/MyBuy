using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class UserDal
    {
        public User GetUser(string id)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {
                    return db.Users.Single(i => i.userId == id);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        public List<User> GetUsers()
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {
                    return db.Users.ToList();
                }
            }
            catch (Exception)
            {

                return null;
            }
        }

    }
}
