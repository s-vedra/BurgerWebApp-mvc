namespace BurgerWebApp.DataAccess.Abstraction
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetEntity(int? id);
        void Update(T entity);
        void Delete(T entity);
        void Add(T entity);

    }
}
