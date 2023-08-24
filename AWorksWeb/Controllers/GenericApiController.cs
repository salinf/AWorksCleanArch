using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AWorksDomain.Entities;
using AWorksDomain.Interfaces;
using AWorksInfrastructure.Data;
using AWorksDomain.ClassExtensions;
using System.Net;
using System.Net.Http;

namespace AWorksWeb.Controllers
{
    [Route("api/[controller]/[action]")]
    public class GenericApiController<TEntity, TKey> : ControllerBase where TEntity : class, IBaseEntity, new()
    {
        private readonly AdventureWorksContext _context;
        private readonly DbSet<TEntity> _dbset;

        public DbSet<TEntity> Set { get => _dbset; }
        public GenericApiController(AdventureWorksContext context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }

        [HttpGet("{id?}")]
        public virtual IActionResult Get(TKey id)
        {
            TEntity entity = new();
            if (entity.IsComplexType)
            {
                //get complex key
                //else use value type directly below
            }
            return Ok(_dbset.Find(id));
        }

        [HttpGet("{encodedId?}")]
        public IActionResult CompositeGet(string encodedId)
        {
            //int t2 = 2;
            //encodedId = t2.ToString().EncodeBase64Url();
            //TEntity entity = new();
            //var key = entity.GetKey(encodedId);
            //return Ok(_dbset.Find(key));
            return Ok();
        }

        [HttpPut]
        public virtual IActionResult Put([FromBody] TEntity entity)
        {
            try
            {
                var rEntity = _dbset.Update(entity);
                _context.SaveChanges();
                return Ok(rEntity.Entity);
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        [HttpPost]
        public virtual IActionResult Post([FromBody] TEntity entity)
        {
            try
            {
                var rEntity = _dbset.Add(entity);
                _context.SaveChanges();
                return Ok(rEntity.Entity);
            }
            catch (Exception e)
            {
                string message = e.Message;
                if (e.InnerException != null)
                {
                    message = e.InnerException.Message;
                }
                return Ok(e.Message);
            }

        }

        [HttpDelete]
        public virtual IActionResult Delete(TKey id)
        {
            TEntity entity = new TEntity();

            return Ok(_dbset.Find(id));
        }
    }
}
