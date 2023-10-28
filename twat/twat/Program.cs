using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 0;
            
            try
            {
                int thuong = a / b;
                Console.WriteLine(thuong);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("J");
                Console.WriteLine(ex.Message);
                
            }
            Console.ReadLine();
        }
    }
}
