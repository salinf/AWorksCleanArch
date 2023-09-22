using AWorksDomain.Specifications;
using AWorksInfrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AWorksWeb.Controllers;

[ApiController]
[Route("api/[controller]/[action]/")]
public class SalesCustomerController : Controller
{   
    private readonly IGenericRepository<SalesCustomer, int> _repo;

    public SalesCustomerController(AdventureWorksContext context)
    {
        _repo = new GenericRepository<SalesCustomer, int>(context);
    }

    [HttpGet("{id}")]
    public SalesCustomer? Get(int id)
    {
        return _repo.Get(id);
    }

    [HttpGet]
    public List<SalesCustomer>? GetAll([FromQuery]PagedSpecification? specification = null)
    {
        return _repo.GetAll(specification);
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return _repo.Delete(id);        
    }

    [HttpPost]
    public SalesCustomer? Post([FromBody] SalesCustomer salesCustomer)
    {
        return _repo.Post(salesCustomer);
    }

    [HttpPut]
    public SalesCustomer? Put([FromBody] SalesCustomer salesCustomer)
    {
        return _repo.Put(salesCustomer);
    }


}
