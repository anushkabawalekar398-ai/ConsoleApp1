using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public void Addition()
        {
            int a = 10, b = 20, c;
            c = a + b;
            Console.WriteLine($"Addtion={c}");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Addition()
        }
    }
}
