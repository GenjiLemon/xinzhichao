using System;
using System.Linq;
using NestOfHeart.Model;

namespace NestOfHeart.DAL
{
    public class UserService : BaseService<Model.User>, IDAL.IUserService
    {
        public UserService(dbContext db) : base(db)
        {
        }
        public UserService()
        {
        }

        public Guid GetIdByUsername(string username)
        {
            return GetAll().First(m => m.Username == username).Id;

        }
        

        public User GetOneByUsername(string username)
        {
            return GetAll().First(m => m.Username == username);
        }
    }
}