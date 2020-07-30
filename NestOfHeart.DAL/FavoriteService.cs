using System;
using System.Collections.Generic;
using System.Linq;
using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class FavoriteService:BaseService<Favorite>,IDAL.IFavoriteService
    {
        public FavoriteService(dbContext db) : base(db)
        {
        }
        public FavoriteService() { }

        public List<Favorite> GetUserFavorite(Guid userid)
        {
            return GetAllOrder().Where(m => m.UserId == userid).ToList();
        }
    }
}