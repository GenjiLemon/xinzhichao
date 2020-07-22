
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            NestOfHeart.Model.dbContext db = new NestOfHeart.Model.dbContext();
            NestOfHeart.IDAL.IUserService UserSVC= new NestOfHeart.DAL.UserService(db);
           
            Console.WriteLine(db.Users.First().Username);
            Console.Read();
        }
    }
}
