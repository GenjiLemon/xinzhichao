
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
    class Base
    {
        public Base()
        {
            Console.Write("Base");
        }
        
    }
    class Son:Base
    {
        public string name = "fay";
        public static string sex = "nan";
    }
    class Program
    {
        static void w(string a,string b = "hahh")
        {
            Console.WriteLine("a=" + a + ",b=" + b);
        }
        static void Main(string[] args)
        {
            w("jaj");
            Console.Read();
           

        }
    }
}
