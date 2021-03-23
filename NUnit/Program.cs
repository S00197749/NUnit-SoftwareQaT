using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    public class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5, 11);

            Console.WriteLine(result);
        }
        static public int Add(int x, int y)
        {
            return x + y;
        }
        
    }
}
