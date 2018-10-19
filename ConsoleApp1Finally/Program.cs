using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            string s = "Some string";
            object obj = s;

            try
            {
                // invalid conversion  ; obj contains a string , not a numeric type .
                i = (int)obj;
                // the following statement is not run . 
                Console.WriteLine("WriteLine at the end of the try bloc. ");
            }

            finally
            {
                // to run the program in Visual studio , type CTRl+F5. Then 
                //click Cancel in the error dialog
                //

                Console.WriteLine("\n Execution of the finally block after an unhandled \n " +
                    "error depends on how the exception unwind operation is triggered.");
                Console.WriteLine("i={0}", i);
                Console.ReadLine();

            }
        }
    }
}

