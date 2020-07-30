using System;
using System.Collections.Generic;

namespace NestOfHeart.IDAL
{
    public interface IFavoriteService:IBaseService<Model.Favorite>
    {
        List<Model.Favorite> GetUserFavorite(Guid userid);
    }
}