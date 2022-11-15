using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TalentPlusProjectAPI.Entity;

namespace TalentPlusProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalentPlusController : ControllerBase
    {
        private readonly ILogger<TalentPlusController> _logger;

        public TalentPlusController(ILogger<TalentPlusController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTalentPlusTitle")]
        public async Task<IActionResult> Get()
        {
            return Ok(new TalentProfile());
        }
    }
}
