using Microsoft.AspNetCore.Mvc;

namespace AWorksWeb.Controllers;

[Route("api/[controller]/[action]/{id?}")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly AdventureWorksContext _dbcontext;
    public PersonController(AdventureWorksContext context)
    {
        _dbcontext = context;
    }

    [HttpGet]
    public Person Get(int id)
    {
        Person p = _dbcontext.Person.Find(id);

        return p;
    }

    [HttpGet]
    public List<Person> GetAll()
    {
        return _dbcontext.Person.ToList();        
    }

    [HttpDelete]
    public int Delete(Person person)
    {
        var p = _dbcontext.Person.Remove(person);
        int retval = _dbcontext.SaveChanges();

        return retval;
    }

    [HttpPost]
    public Person Post(Person person)
    {
        var p = _dbcontext.Person.Add(person);
        _dbcontext.SaveChanges();

        return p.Entity;
    }

    [HttpPut]
    public Person Put(Person person)
    {
        var p = _dbcontext.Person.Update(person);

        try
        {
            Person q = _dbcontext.Person.Find(30780);
            q.FirstName = null;
            q.MiddleName = "test";
            var r = _dbcontext.Person.Update(q);
        }
        catch (Exception)
        {


        }

        _dbcontext.SaveChanges();

        return p.Entity;
    }

}
