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
    public class CountryRegionController : GenericApiController<CountryRegion, string>
    {
        public CountryRegionController(AdventureWorksContext context) : base(context)
        { }
      
    }
}
