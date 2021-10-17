using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                
               Task1.Task1prototype(args);
               Task2.Task2prototype(args);
                
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            
        }
        

    }



}
