using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SUT_demo1;

namespace NUnit.Tests
{
    [TestFixture]
    public class ProgramTest
    {
        static int myExpectedResult;
        static Program p1;

        [SetUp] //Code here is executed before tests are executed
        public static void Init()
        {
            p1 = new Program();
        }

        [Test]
        // name = methodName_StateUnderTest_ExpectedBehaviour
        public static void Add_SimpleValues_Calculated_1()
        {
            //AAA pattern
            //Arrange
            //Act
            //Assert
            myExpectedResult = 9; //what my code should be returning
            int actualResult = p1.Add(4, 5); // call the SUT method
            Assert.AreEqual(myExpectedResult, actualResult);
        }

        [Test]
        public static void Add_SimpleValues_Calculated_2()
        {
            myExpectedResult = 24; //what my code should be returning
            int actualResult = p1.Add(12, 12); // call the SUT method
            Assert.AreEqual(myExpectedResult, actualResult);
        }

        [Test]
        public static void Add_SimpleValues_Calculated_3()
        {
            myExpectedResult = 180; //what my code should be returning
            int actualResult = p1.Add(65, 115); // call the SUT method
            Assert.AreEqual(myExpectedResult, actualResult);
        }
    }
}
