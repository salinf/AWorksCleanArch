using Microsoft.AspNetCore.Mvc;

namespace AWorksWeb.Controllers;

[ApiController]
public class AddressController : GenericApiController<Address, int>
{
    public AddressController(AdventureWorksContext context) : base(context)
    { }

}
