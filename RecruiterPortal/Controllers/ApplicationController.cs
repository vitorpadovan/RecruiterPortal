using Microsoft.AspNetCore.Mvc;
using RecruiterPortal.Business.Interfaces;
using RecruiterPortal.Controllers.Request.Application;
using RecruiterPortal.Controllers.Response.Application;
using RecruiterPortal.Model;

namespace RecruiterPortal.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationBusiness _applicationBusiness;
        private readonly ILogger<ApplicationController> _logger;

        public ApplicationController(IApplicationBusiness applicationBusiness, ILogger<ApplicationController> logger)
        {
            _applicationBusiness = applicationBusiness;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromBody] NewApplicationRequest newApplicationRequest)
        {
            NewApplicationResponse r = await _applicationBusiness.SaveApplication(newApplicationRequest);
            return Ok(r);
        }

        [HttpPost("Analyse")]
        public async Task<IActionResult> Analyse([FromBody] AnalyseAiRequest newAiAnalyse)
        {
            await _applicationBusiness.SaveAnalyseAi(newAiAnalyse);
            return Ok();
        }

        [HttpGet("Analyse")]
        public async Task<IActionResult> GetAnalyse()
        {
            List<AnaliseAiDataModel> response = await _applicationBusiness.GetAnaliseAiData();
            return Ok(response);
        }
    }
}
