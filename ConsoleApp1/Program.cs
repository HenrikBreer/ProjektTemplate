using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCronberg; //bl.a. toStringEx   ConsoleEx

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            //


            // Keep console open when debugging
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
