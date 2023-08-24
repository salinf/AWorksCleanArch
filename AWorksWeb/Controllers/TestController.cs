﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AWorksAPIDemo.ORM;
using AWorksDataModels.ClassExtensions;

namespace AWorksAPIDemo.Controllers
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly AdventureWorksContext _dbcontext;
        public TestController (AdventureWorksContext context)
        {
            _dbcontext = context;
        }

        [HttpGet]
        public string Get (int id)
        {
            var aTest = _dbcontext.Test456.ToList();
            string theResult = String.Empty;

            if (aTest.Count > 0)
            {
                theResult = aTest[id].another;
            }
            return theResult;
        }
        //test

        [HttpGet]
        public string Test(int id)
        {
            string ret = String.Empty;

            switch (id)
            {
                case 1:
                    ret = "it works";
                    break;
                case 2:
                    ret = "Too";
                    break;
                case 3:
                    ret = "Tree";
                    break;
                default:
                    break;
            }

            return ret;
        }

        [HttpPut]
        public string GenerateEncodedKey([FromBody] dynamic JsonStr)
        {
            return Convert.ToString(JsonStr).EncodeBase64Url();
        }
    }
}
