using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IskconAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddMemberController : ControllerBase
    {
        private readonly string _connectionString;
        public AddMemberController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SQLConnection") ?? throw new InvalidOperationException("Connection string cannot be null or whitespace");
        }


    }
}
