using Microsoft.AspNetCore.Mvc;
using NetflixGang.Controllers.Base;
using NetflixGang.Services.Interfaces;

namespace NetflixGang.Controllers
{
    [Route("api/[controller]")]
    public class BotController : ApiControllerBase
    {
        private readonly IBotService _botService; 
        public BotController(IBotService botService) 
        {
            _botService = botService;
        }

        [HttpGet()]
        public string SayHi() 
        {
            return "Say hi";
        }
    }
}
