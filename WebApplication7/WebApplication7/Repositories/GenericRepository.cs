using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication7.DataBase;
using WebApplication7.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApplication7.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        CustomerDBContext Context;

        public GenericRepository(CustomerDBContext Context)
        {
            this.Context = Context;

        }

        public async Task<int> Create(T T)
        {
            Context.Add(T);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> Delete(T T)
        {
            Context.Remove(T);
            return await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> ReadAll()
         => await Context.Set<T>().ToListAsync();

        public async Task<T> ReadById(int? id)
        => await Context.Set<T>().FindAsync(id);

        public async Task<int> Update(T T)
        {
            Context.Update(T);
            return await Context.SaveChangesAsync();
        }
    }
}
