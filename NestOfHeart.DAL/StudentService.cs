using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class StudentService : BaseService<Model.Student>, IDAL.IStudentService
    {
        public StudentService(dbContext db) : base(db)
        {
        }
    }
}