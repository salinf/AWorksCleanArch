using Microsoft.AspNetCore.Mvc;

namespace AWorksWeb.Controllers;

[ApiController]
public class EmailAddressController : GenericApiController<EmailAddress, int>
{
    public EmailAddressController(AdventureWorksContext context) : base(context)
    { }

}
