namespace LearningAPI.Models
{
    public interface IDataRepository<T>
    {
        IEnumerable<T> GetAll();

        T GetById(int id);
        void Add(T entity);
        void Update(T entity, string newName);
        void Delete(T entity);

    }
}