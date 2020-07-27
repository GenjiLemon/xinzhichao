
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NestOfHeart.DAL;
using NestOfHeart.IDAL;
using NestOfHeart.Model;
namespace test
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            NestOfHeart.BLL.UserManager um = new NestOfHeart.BLL.UserManager();
            um.ChangePassword("fay", "fay2","fay1");



        }
    }
}
