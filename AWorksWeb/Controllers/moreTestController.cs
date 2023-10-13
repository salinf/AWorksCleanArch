using Microsoft.AspNetCore.Mvc;

namespace AWorksWeb.Controllers;

public class moreTestController : ControllerBase
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("ErrorRoute")]
    public IActionResult ErrorRoute() => Problem("Some detailed details about the error");
}
