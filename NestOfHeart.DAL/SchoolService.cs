using NestOfHeart.Model;
namespace NestOfHeart.DAL
{
    public class SchoolService : BaseService<Model.School>, IDAL.ISchoolService
    {
        public SchoolService(dbContext db) : base(db)
        {
        }
        public SchoolService() { }
    }
}