using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHeroAPI_DotNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MercylandContactController : ControllerBase
    {
        [HttpGet]
        public string Get() {
    }
}
