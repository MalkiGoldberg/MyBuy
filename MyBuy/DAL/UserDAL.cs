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
        public bool Login(User user)
        { 
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                { 
                  user   = db.Users.Single(br => br.userId == user.userId && br.password == user.password);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool SignUp(User user)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {
                    db.Users.Add(user);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
