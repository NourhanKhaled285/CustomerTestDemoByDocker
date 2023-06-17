using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication7.Interfaces
{
    public interface IGenericRepository<T>
    {

        Task<int> Create(T T);
        Task<IEnumerable<T>> ReadAll();
        Task<T> ReadById(int? id);
        Task<int> Update(T T);

        Task<int> Delete(T T);
    }
}
