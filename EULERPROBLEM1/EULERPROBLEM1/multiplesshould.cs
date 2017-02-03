using System;
using NUnit.Framework;

namespace EULERPROBLEM1
{
    [TestFixture]


    public class multiplesshould
    {
        
        [Test]

        public void returnTrueWhenMultipleOfFive()
        { 
            
            //arrange
            problem1solution solution = new problem1solution();
            int multipleOfFive;
            //act
            multipleOfFive = 2;
            solution.sumOfMultiplesOfFive(multipleOfFive);
            //assert
            int expected = 5;
            Assert.AreEqual(expected, multipleOfFive);
        }
    }
}
