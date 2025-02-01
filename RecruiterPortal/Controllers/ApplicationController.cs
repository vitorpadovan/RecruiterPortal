using Microsoft.AspNetCore.Mvc;
using RecruiterPortal.Business.Interfaces;
using RecruiterPortal.Controllers.Request.Application;
using RecruiterPortal.Controllers.Response.Application;

namespace RecruiterPortal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationBusiness _applicationBusiness;

        public ApplicationController(IApplicationBusiness applicationBusiness)
        {
            _applicationBusiness = applicationBusiness;
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromBody] NewApplicationRequest newApplicationRequest)
        {
            NewApplicationResponse r = await _applicationBusiness.SaveApplication(newApplicationRequest);
            return Ok(r);
        }
    }
}
