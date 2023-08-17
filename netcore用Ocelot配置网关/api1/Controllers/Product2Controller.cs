using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Product2Controller : ControllerBase
    {
        [HttpGet(Name = "test3")]
        public string test3()
        {
            return "test3";
        }
    }
}
