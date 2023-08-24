using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AWorksDataModels;
using AWorksAPIDemo.ORM;
using AWorksWeb.Controllers;

namespace AWorksAPI.Controllers
{

    [ApiController]
    public class EmailAddressController : GenericApiController<EmailAddress, int>
    {
        public EmailAddressController(AdventureWorksContext context) : base(context)
        { }

    }
}
