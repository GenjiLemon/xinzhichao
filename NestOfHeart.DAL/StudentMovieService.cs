using NestOfHeart.Model;
namespace NestOfHeart.DAL
{
    public class StudentMovieService : BaseService<Model.StudentMovie>, IDAL.IStudentMovieService
    {
        public StudentMovieService(dbContext db) : base(db)
        {
        }
    }
}