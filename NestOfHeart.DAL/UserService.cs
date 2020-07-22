using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class UserService : BaseService<Model.User>, IDAL.IUserService
    {
        public UserService(dbContext db) : base(db)
        {
        }
    }
}