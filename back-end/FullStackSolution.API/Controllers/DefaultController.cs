using Microsoft.AspNetCore.Mvc;

namespace FullStackSolution.API.Controllers
{
    [Route("[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [Route("/")]
        [Route("/docs")]
        [Route("/swagger")]
        public IActionResult Index() => new RedirectResult("~/swagger");
    }
}