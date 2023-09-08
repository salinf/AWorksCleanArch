using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWorksWeb.Controllers;

[ApiController]
public class CountryRegionController : GenericApiController<CountryRegion, string>
{
    public CountryRegionController(AdventureWorksContext context) : base(context)
    { }
}