namespace LeaveManagement.ApplicationLogic.Contracts
{
    public interface IGenericRepository<T>
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
       
        Task<bool> Exist(int id);

        Task<T> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);

        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);


      


    }
}
