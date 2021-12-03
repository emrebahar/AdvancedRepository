using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Repositories.BaseRepository.Abstract
{
    public interface IBaseRepository<T> where T : class
    {
        void Update();
        bool Delete(T entitiy);
        bool Add(T entitiy);
        T FindById(int id);
        List<T> List();
        DbSet<T> DbSet();
        void DbSaveChanges();
        
    }
}
