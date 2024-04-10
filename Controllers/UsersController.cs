using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GymFit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        [HttpGet(Name = "UsersGet")]
        [Authorize]
        public IEnumerable<Models.User> Get()
        {
            return new List<Models.User>();
        }
    }
}
