using Microsoft.AspNetCore.Mvc;

namespace GroceryStore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private static List<Provider> providers = new List<Provider>
        {

        };

        [HttpGet(Name = "GetProviders")]
        public List<Provider> Get()
        {
            return providers;
        }

        [HttpPost(Name = "PostProviders")]
        public ActionResult<Provider> Post([FromBody] Provider provider)
        {
            providers.Add(provider);
            return Ok();
        }

        [HttpDelete(Name = "DeleteProviders")]
        public IActionResult Delete(string name)
        {
            var provider = providers.FirstOrDefault(p => p.Name == name);
            if (provider == null)
            {
                return NotFound();
            }
            providers.Remove(provider);
            return Ok();
        }

        [HttpPut(Name = "PutProviders")]
        public IActionResult Put(string name, [FromBody] Provider newProvider)
        {
            var oldProvider = providers.FirstOrDefault(p => p.Name == name);
            if (oldProvider == null)
            {
                return NotFound();
            }
            oldProvider.Name = newProvider.Name;
            oldProvider.Description = newProvider.Description;
            oldProvider.Address = newProvider.Address;
            oldProvider.Country = newProvider.Country;
            oldProvider.ContactNumber = newProvider.ContactNumber;
            oldProvider.Email = newProvider.Email;
            oldProvider.IsActive = newProvider.IsActive;

            return Ok();
        }
    }
}
