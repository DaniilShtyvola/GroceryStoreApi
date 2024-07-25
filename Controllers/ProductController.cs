using GroceryStore;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {

        };

        [HttpGet(Name = "GetProducts")]
        public List<Product> Get()
        {
            return products;
        }

        [HttpPost(Name = "PostProducts")]
        public ActionResult<Product> Post(Product product)
        {
            products.Add(product);

            return Ok();
        }

        [HttpDelete(Name = "DeleteProducts")]
        public IActionResult Delete(string name)
        {
            var product = products.FirstOrDefault(p => p.Name == name);
            if (product == null)
            {
                return NotFound();
            }
            products.Remove(product);

            return Ok();
        }

        [HttpPut(Name = "PutProducts")]
        public IActionResult Put(string name, [FromBody] Product newProduct)
        {
            var oldProduct = products.FirstOrDefault(p => p.Name == name);
            if (oldProduct == null)
            {
                return NotFound();
            }
            oldProduct.Name = newProduct.Name;
            oldProduct.Description = newProduct.Description;
            oldProduct.CategoryId = newProduct.CategoryId;
            oldProduct.Price = newProduct.Price;
            oldProduct.Amount = newProduct.Amount;
            oldProduct.ManufacturerId = newProduct.ManufacturerId;
            oldProduct.ProviderId = newProduct.ProviderId;

            return Ok();
        }
    }
}
