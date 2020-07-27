using NestOfHeart.Dto;
using System.Collections.Generic;

namespace NestOfHeart.IBLL
{
    public interface IFavoriteManager
    {
        void AddFavorite(string username, string title, string url);
        List<FavoriteDto> GetUserFavorite(string username);
    }
}
