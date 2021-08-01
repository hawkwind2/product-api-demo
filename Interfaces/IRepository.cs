using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product_Kolmeo.Interfaces
{
    public interface IRepository<T>
    {
        Task<List<T>> SelectAll();
        Task<T> SelectById(long id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
