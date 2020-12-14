using System.Threading.Tasks;
using Application.TestConnection.Queries.TestConnection;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class HomeController : BaseApiController
    {
        [HttpGet]
        [Route("testConnection")]
        public async Task<bool> TestConnection()
        {
            return await Mediator.Send(new TestConnection());
        }
    }
}
