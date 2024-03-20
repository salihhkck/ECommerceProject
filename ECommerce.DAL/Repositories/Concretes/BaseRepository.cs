using ECommerce.DAL.Context;
using ECommerce.DAL.Repositories.Abstracts;
using ECommerce.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Repositories.Concretes
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        MyContext _db;

        public BaseRepository(MyContext db)
        {
            _db = db;
        }

        public async Task AddAsync(T item)
        {
            await _db.Set<T>().AddAsync(item);
            await _db.SaveChangesAsync();
        }

        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            _db.SaveChanges();
        }

        public async Task AddRange(List<T> items)
        {
            await _db.Set<T>().AddRangeAsync(items);
            await _db.SaveChangesAsync();
        }

        public bool Any(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Any(predicate);
        }

        /// <summary>
        /// verinin pasife çekilme işlemidir.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Delete(T item)
        {
            item.Status = Entities.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            _db.SaveChanges();
        }

        public void DeleteRange(List<T> items)
        {
            foreach (T item in items) Delete(item);
        }

        public void Destroy(T item)
        {
            _db.Set<T>().Remove(item);
            _db.SaveChanges();
        }

        public void DestroyRange(List<T> items)
        {
            _db.Set<T>().RemoveRange(items);
            _db.SaveChanges();
        }

        public async Task<T> FindAsync(int id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _db.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public IQueryable<T> GetActives()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetModified()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetPassives()
        {
            throw new NotImplementedException();
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(List<T> items)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
