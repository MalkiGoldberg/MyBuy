using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converts
{
    public static class CategoryConverts
    {
        public static DTO.CategoryDTO GetCategoryDTOFromDAL(DAL.Category category)
        {
            DTO.CategoryDTO  categoryDTO = new DTO.CategoryDTO();
            categoryDTO.categoryId = category.categoryId;
            categoryDTO.categoryName = category.categoryName;
            categoryDTO.date = (int)category.date;
            return categoryDTO;
        }
        public static List<DTO.CategoryDTO> GetCategoriesDTOFromDAL(List<DAL.Category> categories)
        {
            List<DTO.CategoryDTO> categoriesDTO = new List<DTO.CategoryDTO>();
            foreach (var item in categories)
            {
                categoriesDTO.Add(GetCategoryDTOFromDAL(item));
            }
            return categoriesDTO;
        }
    }
}
