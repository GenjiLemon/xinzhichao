
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

            List<int> testList = new List<int>();
            testList.Add(2);
            testList.Add(1);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(0);
            
            foreach(int i in testList)
            {
                Console.Write(i);
            }
            Console.Read();

        }
    }
}
