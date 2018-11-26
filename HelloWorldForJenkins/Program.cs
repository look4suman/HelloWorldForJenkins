using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldForJenkins
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessge());
        }

        public static string CreateMessge()
        {
            return "Hello World";
        }
    }
}
