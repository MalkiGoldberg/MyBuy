using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CategoryBL
    {
     
        public DTO.CategoryDTO GetCategory(int id)
        {
            return Converts.CategoryConverts.GetCategoryDTOFromDAL(new DAL.CategoryDAL().GetCategory(id));
        }
        public List<DTO.CategoryDTO> GetCategories()
        {
            return Converts.CategoryConverts.GetCategoriesDTOFromDAL(new DAL.CategoryDAL().GetCategories());
        }
    }
}
