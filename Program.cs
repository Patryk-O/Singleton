using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var business = SigletonClass.GetInstance();

            business.SomeBusinessStaff();
            Thread.Sleep(3000);
            business.MultiLineAnimation();
            Console.ReadLine();
        }
    }
}
