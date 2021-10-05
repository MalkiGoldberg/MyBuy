using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CategoryController:ApiController
    {
        public DTO.CategoryDTO GetCategory(int id)
        {
            BL.CategoryBL categoryBL = new BL.CategoryBL();
            return categoryBL.GetCategory(id);
        }
        [HttpGet]
        [Route("api/GetCategories")]
        public List<DTO.CategoryDTO> GetCategories()
        {

            return new BL.CategoryBL().GetCategories();
        }
    }
}