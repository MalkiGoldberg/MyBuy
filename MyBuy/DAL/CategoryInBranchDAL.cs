using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class CategoryInBranchDAL
    {
        public CategoryInBranch GetCategoryInBranch(int categoryInBranchId)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {

                    return db.CategoryInBranches.Single(i => i.categoryInBranchId == categoryInBranchId);
                }
            }
            catch
            {
                throw;

            }
        }
        public List<CategoryInBranch> GetCategoryInBranches()
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {

                    return db.CategoryInBranches.ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
