using Microsoft.AspNetCore.Mvc;

namespace GroceryStore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private static List<Manufacturer> manufacturers = new List<Manufacturer>
        {

        };

        [HttpGet(Name = "GetManufacturers")]
        public List<Manufacturer> Get()
        {
            return manufacturers;
        }

        [HttpPost(Name = "PostManufacturers")]
        public ActionResult<Manufacturer> Post(Manufacturer manufacturer)
        {
            manufacturers.Add(manufacturer);

            return Ok();
        }

        [HttpDelete(Name = "DeleteManufacturers")]
        public IActionResult Delete(string name)
        {
            var manufacturer = manufacturers.FirstOrDefault(p => p.Name == name);
            if (manufacturer == null)
            {
                return NotFound();
            }
            manufacturers.Remove(manufacturer);

            return Ok();
        }

        [HttpPut(Name = "PutManufacturers")]
        public IActionResult Put(string name, [FromBody] Manufacturer newManufacturer)
        {
            var oldManufacturer = manufacturers.FirstOrDefault(p => p.Name == name);
            if (oldManufacturer == null)
            {
                return NotFound();
            }
            oldManufacturer.Name = newManufacturer.Name;
            oldManufacturer.Description = newManufacturer.Description;
            oldManufacturer.Address = newManufacturer.Address;
            oldManufacturer.Country = newManufacturer.Country;
            oldManufacturer.ContactNumber = newManufacturer.ContactNumber;
            oldManufacturer.Email = newManufacturer.Email;
            oldManufacturer.IsActive = newManufacturer.IsActive;

            return Ok();
        }
    }
}
