using AWorksWeb.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AWorksWeb.Controllers;

[ApiController]
public class testDefaultController : GenericApiController<testDefault, int>
{
    public testDefaultController(AdventureWorksContext context) : base(context)
    { }
}



