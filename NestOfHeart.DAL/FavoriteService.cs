using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class FavoriteService:BaseService<Favorite>,IDAL.IFavoriteService
    {
        public FavoriteService(dbContext db) : base(db)
        {
        }
        public FavoriteService() { }
    }
}