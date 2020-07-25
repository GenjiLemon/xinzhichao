using NestOfHeart.Model;
using System;

namespace NestOfHeart.DAL
{
    public class StudentService : BaseService<Model.Student>, IDAL.IStudentService
    {
        public StudentService(dbContext db) : base(db)
        {
        }
        public new Guid Add(Student t)
        {
            db.Set<Student>().Add(t);
            db.SaveChanges();
            return t.Id;
        }
    }
}