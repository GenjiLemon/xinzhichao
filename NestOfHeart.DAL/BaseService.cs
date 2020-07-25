using NestOfHeart.Model;
using System;
using System.Linq;
using System.Data.Entity;
namespace NestOfHeart.DAL
{
    public class BaseService<T>: IDAL.IBaseService<T> where T:Model.BaseEntity,new()
    {
        protected readonly dbContext db = new dbContext();

        public BaseService()
        {

        }
        public BaseService(dbContext db)
        {
            this.db = db;
        }
        public void Add(T t)
        {
            db.Set<T>().Add(t);
            db.SaveChanges();
        }
        
        public void Edit(T t)
        {
            db.Configuration.ValidateOnSaveEnabled = false;
            db.Entry(t).State = EntityState.Modified;
            db.SaveChanges();
            db.Configuration.ValidateOnSaveEnabled = true;
        }
      

        public void Remove(Guid id)
        {
            db.Configuration.ValidateOnSaveEnabled = false;
            var t=new T(){ Id=id};
            db.Entry(t).State = EntityState.Deleted;
            db.SaveChanges();
            db.Configuration.ValidateOnSaveEnabled = true;
        }

        public void Remove(T model)
        {
            Remove(model.Id);
        }

        public T GetOne(Guid id)
        {
            return GetAll().First(m => m.Id == id);
        }
        public IQueryable<T> GetAll()
        {
            return db.Set<T>().Where(m => !m.IsRemove).AsNoTracking();
        }

        public IQueryable<T> GetAllByPage(int pageSize = 10, int pageIndex = 0)
        {
            return GetAll().Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<T> GetAllByPageOrder(int pageSize = 10, int pageIndex = 0, bool asc = true)
        {
            return GetAllOrder(asc).Skip(pageSize * pageIndex).Take(pageSize);
        }

        public IQueryable<T> GetAllOrder(bool asc = true)
        {
            var datas = GetAll();
            if (asc)
                datas = datas.OrderBy(m => m.CreateTime);
            else
                datas = datas.OrderByDescending(m => m.CreateTime);
            return datas;
        }

        
        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}