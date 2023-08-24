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
    public class AddressTypeController : GenericApiController<AddressType, string>
    {        
        public AddressTypeController(AdventureWorksContext context) : base(context)
        {           
        }

        [HttpGet("{id?}")]
        public override IActionResult Get(string id)
        {
            //force int key to string and back again, just to test generic type of api controller, this would be error prone without some guard clauses, 
            //but they are not needed in this test
            return Ok(base.Set.Find(Convert.ToInt32(id)));
        }
    }
}
