using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public static  class CategoryInBranchConverts
    {
        public static DTO.CategoryInBranchDTO GetCategoryInBranchDTOFromDAL(DAL.CategoryInBranch categoryInBranch)
        {
            DTO.CategoryInBranchDTO categoryInBranchDTO = new DTO.CategoryInBranchDTO();
            categoryInBranchDTO.categoryInBranchId = categoryInBranch.categoryInBranchId;
            categoryInBranchDTO.idBranch = categoryInBranch.idBranch;
            categoryInBranchDTO.idCategory = categoryInBranch.idCategory;
            return categoryInBranchDTO;
        }
        public static List<DTO.CategoryInBranchDTO> GetCategoryInBranchesDTOFromDAL(List<DAL.CategoryInBranch> categoriesInBranches)
        {
            List<DTO.CategoryInBranchDTO> categoryInBranchDTO = new List<DTO.CategoryInBranchDTO>();
            foreach (var item in categoriesInBranches)
            {
                categoryInBranchDTO.Add(GetCategoryInBranchDTOFromDAL(item));
            }
            return categoryInBranchDTO;
        }
    }
}
