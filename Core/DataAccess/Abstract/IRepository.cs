using Core.Entities;

namespace Core.DataAccess.Abstract
{
    public interface IRepository<T> where T: BaseEntity,new ()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
