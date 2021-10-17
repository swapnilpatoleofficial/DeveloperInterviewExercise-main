using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTestFileData
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Task1Method()
        {
            string[] expectedArgs = new[] { "-v", "C:/test.txt" };
            FileData.Task1.Task1prototype(expectedArgs);
        }
        [TestMethod]
        public void Task2Method()
        {
            //Excepted input 
            string[] expectedArgs = new[] { "--v", "C:/test.txt" };
            
                FileData.Task2.Task2prototype(expectedArgs);
            
        }

    }
}
