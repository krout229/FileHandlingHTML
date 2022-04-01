using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandlingInput fileHandling = new FileHandlingInput();
            fileHandling.ReadFile();
            Console.Read();

        }
    }
}
