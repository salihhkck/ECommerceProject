using ECommerce.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Repositories.Abstracts
{
    public interface IRepository<T> where T : class, IEntity
    {
        //List Commands
        IQueryable<T> GetAll();
        IQueryable<T> GetActives();
        IQueryable<T> GetModified();
        IQueryable<T> GetPassives();


        //Modify Commands
        void Add(T item);
        Task AddAsync(T item);
        Task AddRange(List<T> items);
        void Update(T item);
        void UpdateRange(List<T> items);
        void Delete(T item);
        void DeleteRange(List<T> items);
        void Destroy(T item);
        void DestroyRange(List<T> items);   


        //Ling Commands
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        bool Any(Expression<Func<T, bool>> predicate);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        IQueryable<X> Select<X>(Expression<Func<T, X>> predicate);
        Task<T> FindAsync(int id);
    }
}
