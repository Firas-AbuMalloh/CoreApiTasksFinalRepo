using CoreApiTask.Server.DTO;
using CoreApiTask.Server.IDataService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiTask.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class categoryController : ControllerBase
    {

        private readonly IDataServiceInterface _data;

        public categoryController(IDataServiceInterface dataService)
        {
            _data = dataService;
        }


        [HttpGet("GetAllCategories")]
        public IActionResult GetAllCategories()
        {
            var categories = _data.GetAllCategories();
            if (categories == null || !categories.Any())
            {
                return NotFound("No categories found.");
            }
            return Ok(categories);
        }


        [HttpPost("addCategory")]

        public IActionResult addCategory([FromBody]AddCategoryRequest categoryReq)
        {
            if (categoryReq == null)
            {
                return BadRequest();
            }

            _data.AddCategory(categoryReq);

            return Ok("Category added successfully.");

        }

        [HttpPost("UpdateCategory/{id}")]
        public IActionResult UpdateCategory([FromForm] int id, AddCategoryRequest categoryReq)
        {
            if (categoryReq == null)
            {
                return BadRequest("Invalid category data.");
            }

            bool status = _data.UpdateCategory(id, categoryReq);
            if (status)
            {
                return Ok("Category updated successfully.");
            }
            else
            {
                return NotFound("Category not found.");
            }
        }

    }
}



