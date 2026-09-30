using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        public void Add(){
            int a = 90, b = 78, c;
            c = a + b;
            Console.WriteLine("Add=" + c);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();
        }
    }
}
