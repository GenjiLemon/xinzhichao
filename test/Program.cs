
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

            NestOfHeart.IBLL.IUserManager UserMgr = new NestOfHeart.BLL.UserManager();
            //UserMgr.Register("fay", "fay123", 2);
			//UserMgr.Register("fayfadsga34q325", "fa412341235weqy123", 2);
            UserMgr.Register("cjl", "cjl123", 1);

        }
    }
}
