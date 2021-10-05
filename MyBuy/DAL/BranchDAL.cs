using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class BranchDAL
    {
        public Branch GetBranch(int brachId)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {

                    return db.Branches.Include(b=>b.CategoryInBranches).Single(i => i.brachId == brachId);
                }
            }
            catch
            {
                throw;

            }
        }
        public Branch SignUp(Branch branch)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {
                    Branch seBranch = db.Branches.Include(b => b.CategoryInBranches).Single(br => br.userName == branch.userName && br.password == branch.password);
                    return seBranch;
                }
            }
            catch
            {

                return new Branch();
            }
        }
        public List<Branch> GetBranches()
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {

                    return db.Branches.Include(b => b.CategoryInBranches).ToList();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
     
        public bool AddBranch(Branch branch)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {
                    db.Branches.Add(branch);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool SignUpBranch(Branch branch)
        {
            try
            {
                using (MyBuyEntities db = new MyBuyEntities())
                {//idManager לא נקלט
                    branch.idManager = "123";
                    db.Branches.Add(branch);
                    db.SaveChanges();
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

