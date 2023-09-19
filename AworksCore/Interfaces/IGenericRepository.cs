namespace AWorksDomain.Interfaces;

public interface IGenericRepository<TEntity, TKey> where TEntity : class, IBaseEntity, new()
{
    TEntity? CompositeGet(string encodedId);
    string Delete(TKey id);
    TEntity? Get(TKey id);
    List<TEntity>? GetAll();
    TEntity? Post(TEntity entity);
    TEntity? Put(TEntity entity);
}