using System;
using System.Linq;
namespace NestOfHeart.IDAL
{
    public interface IBaseService<T>:IDisposable where T : Model.BaseEntity 
    {
        void Add(T t);
        void Edit(T t);
        
        void Remove(Guid id);
        void Remove(T model);
        T GetOne(Guid id);
        IQueryable<T> GetAll();
        IQueryable<T> GetAllByPage(int pageSize = 10, int pageIndex = 0);
        IQueryable<T> GetAllOrder(bool asc = true);
        IQueryable<T> GetAllByPageOrder(int pageSize = 10, int pageIndex = 0, bool asc = true);
    }
}