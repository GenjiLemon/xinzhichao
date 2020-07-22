using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class ClassService : BaseService<Class>, IDAL.IClassService
    {
        public ClassService(dbContext db) : base(db)
        {
        }
    }
}