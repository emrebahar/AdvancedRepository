using IleriRepository.Context;
using IleriRepository.Repositories.BaseRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Repositories.BaseRepository.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        DatabaseContext db = new DatabaseContext();
        public bool Add(T entitiy)
        {
            try
            {
                DbSet().Add(entitiy);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void DbSaveChanges()
        {
             db.SaveChanges();
        }

        public DbSet<T> DbSet()
        {
            return db.Set<T>();
        }

        public bool Delete(T entitiy)
        {
            try
            {
                DbSet().Remove(entitiy);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T FindById(int id)
        {
            return DbSet().Find(id); 
        }
        public T FindById(string id)
        {
            return DbSet().Find(id);
        }
        public T FindById(int key1, int key2)
        {
            return DbSet().Find(key1,key2);
        }
        public List<T> List()
        {
            return DbSet().ToList();
        }
        public void Update()
        {
            DbSaveChanges();
        }
    }
}
