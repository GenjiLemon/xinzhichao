using System;
using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class TeacherService : BaseService<Model.Teacher>
    {
        public TeacherService(dbContext db) : base(db)
        {
        }
        public TeacherService() { }
        public new Guid Add(Teacher t)
        {
            db.Set<Teacher>().Add(t);
            db.SaveChanges();
            return t.Id;
        }
    }
}