using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CategoryInBranchBL
    {
        public DTO.CategoryInBranchDTO GetCategoryInBranchBL(int id)
        {
            return Converts.CategoryInBranchConverts.GetCategoryInBranchDTOFromDAL(new DAL.CategoryInBranchDAL().GetCategoryInBranch(id));
        }
        public List<DTO.CategoryInBranchDTO> GetCategoryInBranchDTOs()
        {
            return Converts.CategoryInBranchConverts.GetCategoryInBranchesDTOFromDAL(new DAL.CategoryInBranchDAL().GetCategoryInBranches());
        }
    }
}
