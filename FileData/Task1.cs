using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public static class Task1
    {
        public static void Task1prototype(string[] args)
        {
            if (!(args == null || args.Length == 0) || args.Length > 2)
            {

                string first_argument = args[0];
                string second_argumentPath = args[1];

                string Task1_Result = string.Empty;
                FileDetails tsk1 = new FileDetails();
                if (first_argument.Contains("-v") && second_argumentPath.Contains("C:/test.txt"))
                {
                    Task1_Result = tsk1.Version(second_argumentPath);
                    Console.WriteLine($"The task one result is {Task1_Result}");
                }
                else
                {
                    Console.WriteLine("Task1 - Invalid input string Received.Please provide Expected input '-v C:/test.txt'");

                }

            }
            else
            {
                Console.WriteLine("Task1 - Null or Empty Input Received,Please provide valid input '-v C:/test.txt'");

            }

        }

    }
}
