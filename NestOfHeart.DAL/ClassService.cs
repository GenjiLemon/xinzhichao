using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class ClassService : BaseService<Class>, IDAL.IClassService
    {
        public ClassService(dbContext db) : base(db)
        {
        }
        public ClassService() { }
        public new IQueryable<Class> GetAll()
        {
            return db.Set<Class>().Where(m => !m.IsRemove && !m.IsGraduated).AsNoTracking();
        }
        public Guid GetIdByName(string classname)
        {
            return GetOneByName(classname).Id;
        }
        
        public Class GetOneByName(string classname)
        {
            return GetAll().First(m => m.Name == classname);
        }

        public List<Class> GetClassesByTeacherid(Guid teacherid)
        {
            return GetAll().Where(m => m.TeacherId == teacherid).ToList();
        }
    }
}