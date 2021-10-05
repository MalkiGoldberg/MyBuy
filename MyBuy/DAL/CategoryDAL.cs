using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class CategoryDAL
    {
        public Category GetCategory(int categoryId)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {

                    return db.Categories.Single(i => i.categoryId == categoryId);
                }
            }
            catch
            {
                throw;

            }
        }
        public List<Category> GetCategories()
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {

                    return db.Categories.ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
  
}
}
