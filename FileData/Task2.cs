using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public static class Task2
    {
        public static void Task2prototype(string[] args)
        {
            if (!(args == null || args.Length == 0))
            {

                string first_argument = args[0];
                string second_argumentPath = args[1];

                string Task2_VersionResult = string.Empty;
                int Task2_SizeResult;
                FileDetails tsk2_Version = new FileDetails();
                FileDetails tsk2_Size = new FileDetails();
                if ((first_argument.Contains("-v") || first_argument.Contains("--v") || first_argument.Contains("/v") || first_argument.Contains("--version")) && (second_argumentPath.Contains("C:/test.txt")))
                {
                    Task2_VersionResult = tsk2_Version.Version(second_argumentPath);
                    Console.WriteLine($"The task second version result is {Task2_VersionResult}");
                }
                else if ((first_argument.Contains("-s") || first_argument.Contains("--s") || first_argument.Contains("/s") || first_argument.Contains("--size")) && (second_argumentPath.Contains("C:/test.txt")))
                {
                    Task2_SizeResult = tsk2_Size.Size(second_argumentPath);
                    Console.WriteLine($"The task second Size result is {Task2_SizeResult}");
                }
                else

                {
                    Console.WriteLine("Task2 - Invalid input string Received.Please provide Expected input either '-v C:/test.txt' or -s C:/test.txt... ");

                }

            }
            else
            {
                Console.WriteLine(" Task2 - Null or Empty Input Received,Please provide valid input '-v C:/test.txt'");

            }

        }
    }
}
