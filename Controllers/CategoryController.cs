using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using projekat.Services;
using projekat.Models;

namespace projekat.Controllers {


    [Route("category")]
    [ApiController]
    public class CategoryController : ControllerBase {
        private readonly ICategoryService categoryService;
        private readonly ILogger<CategoryController> _logger;
        
        public CategoryController(ICategoryService categoryService, ILogger<CategoryController> logger) {
            this.categoryService = categoryService;
            this._logger = logger;
        }

        [HttpPost("import")]
        public async Task<IActionResult> importCategories(){
            var result = await categoryService.importCategories();

            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

    }

}