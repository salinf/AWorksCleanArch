using AWorksDomain.Interfaces;
using AWorksInfrastructure.Data;
using AWorksInfrastructure.Optional;
using Microsoft.EntityFrameworkCore;


namespace AWorksInfrastructure.Repositories;

public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class, IBaseEntity, new()
{
    private readonly AdventureWorksContext _context;
    private readonly DbSet<TEntity> _dbset;

    public DbSet<TEntity> Set { get => _dbset; }
    public GenericRepository(AdventureWorksContext context)
    {
        _context = context;
        _dbset = _context.Set<TEntity>();
    }

    public TEntity? Get(TKey id)
    {
        TEntity entity = new();
        if (entity.IsComplexType)
        {
            //get complex key
            //else use value type directly below
        }
        return _dbset.Find(id);
    }

    public List<TEntity>? GetAll(IPagedSpecification? specification)
    {        
        return specification == null ? _dbset.ToList() : _dbset. Take(specification.RowsPerPage).ToList();
    }

    public TEntity? CompositeGet(string encodedId)
    {
        //int t2 = 2;
        //encodedId = t2.ToString().EncodeBase64Url();
        //TEntity entity = new();
        //var key = entity.GetKey(encodedId);
        //return Ok(_dbset.Find(key));
        return new();
    }

    public TEntity? Put(TEntity entity)
    {

        var rEntity = _dbset.Update(entity);
        _context.SaveChanges();
        return rEntity.Entity;
    }

    public TEntity? Post(TEntity entity)
    {
        var rEntity = _dbset.Add(entity);
        _context.SaveChanges();
        return rEntity.Entity;
    }

    public string Delete(TKey id)
    {
        TEntity? entity = _dbset.Find(id);
        if (entity != null)
        {
            _dbset.Remove(entity);
            _context.SaveChanges();
            return "The entity was deleted successfully.";
        } 
        
        return "A problem occurred during deletion. The entity may still be present.";
    }
}
