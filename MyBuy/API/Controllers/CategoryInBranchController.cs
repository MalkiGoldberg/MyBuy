using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Controllers
{
    public class CategoryInBranchController
    {
        public DTO.CategoryInBranchDTO GetCategoryInBranch(int id)
        {
            BL.CategoryInBranchBL categoryInBranchBL = new BL.CategoryInBranchBL();
            return categoryInBranchBL.GetCategoryInBranchBL(id);
        }
        public List<DTO.CategoryInBranchDTO> GetCategoryInBranches()
        {
            return new BL.CategoryInBranchBL().GetCategoryInBranchDTOs();
        }
    }
}