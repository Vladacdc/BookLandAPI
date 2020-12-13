using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        public TokenController()
        {
            
        }

        public async Task<IActionResult> Create()
        {
            return Ok();
        }

        public async Task GenerateToken()
        {
            
        }
    }
}