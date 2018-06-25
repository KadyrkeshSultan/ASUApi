using ASU.DAL.Interfaces;
using ASU.DTO.EF;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASU.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext db;
        protected readonly DbSet<T> set;

        public Repository(AppDbContext context)
        {
            db = context;
            set = context.Set<T>();
        }

        public virtual void Add(T item)
        {
            set.Add(item);
        }

        public virtual async Task AddAsync(T item)
        {
            await set.AddAsync(item);
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            set.AddRange(entities);
        }

        public virtual async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await set.AddRangeAsync(entities);
        }

        public virtual void Remove(T item)
        {
            set.Remove(item);
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            set.RemoveRange(entities);
        }

        public virtual T Get(int id)
        {
            return set.Find(id);
        }

        public virtual async Task<T> GetAsync(int id)
        {
            return await set.FindAsync(id);
        }

        public virtual void Update(T item)
        {
            set.Update(item);
        }

        public virtual void UpdateRange(IEnumerable<T> entities)
        {
            set.UpdateRange(entities);
        }
    }
}
