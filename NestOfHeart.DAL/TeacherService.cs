using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class TeacherService : BaseService<Model.Teacher>, IDAL.ITeacherService
    {
        public TeacherService(dbContext db) : base(db)
        {
        }
    }
}