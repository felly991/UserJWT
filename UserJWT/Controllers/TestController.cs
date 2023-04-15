using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserJWT.UserData;

namespace UserJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("test"), Authorize(Roles = "Admin")]
        public ActionResult<User> Login2()
        {
            return Ok("test");
        }
    }
}
