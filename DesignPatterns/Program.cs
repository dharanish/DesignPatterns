using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Singleton_Pattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass.Name = "TestName";
            TestClass.Name = "Testname1";
        }
    }

    public class A
    {
        public int value1 = 10;
    }

    public class b
    {
        public int value1 = 10;
    }
}
