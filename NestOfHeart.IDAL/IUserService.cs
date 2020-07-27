using System;

namespace NestOfHeart.IDAL
{
    public interface IUserService:IBaseService<Model.User>
    {
        Guid GetIdByUsername(string username);
        Model.User GetOneByUsername(string name);
    }
}