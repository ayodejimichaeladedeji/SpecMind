namespace SpecMind.Application.Interfaces
{
    public interface IRepository<T>
    {
        Task<bool> Add(T entity);
        Task<T> GetById(int Id);
        Task<bool> Update(T entity);
        Task<bool> DeleteById(int Id);
    }
}