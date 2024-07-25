using Microsoft.AspNetCore.Mvc;

namespace GroceryStore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private static List<Category> categories = new List<Category>
        {

        };

        [HttpGet(Name = "GetCategories")]
        public List<Category> Get()
        {
            return categories;
        }

        [HttpPost(Name = "PostCategories")]
        public ActionResult<Category> Post(Category category)
        {
            categories.Add(category);

            return Ok();
        }

        [HttpDelete(Name = "DeleteCategories")]
        public IActionResult Delete(string name)
        {
            var category = categories.FirstOrDefault(p => p.Name == name);
            if (category == null)
            {
                return NotFound();
            }
            categories.Remove(category);

            return Ok();
        }

        [HttpPut(Name = "PutCategories")]
        public IActionResult Put(string name, [FromBody] Category newCategory)
        {
            var oldCategory = categories.FirstOrDefault(p => p.Name == name);
            if (oldCategory == null)
            {
                return NotFound();
            }
            oldCategory.Name = newCategory.Name;
            oldCategory.Description = newCategory.Description;
            oldCategory.ParentCategoryId = newCategory.ParentCategoryId;

            return Ok();
        }
    }
}
