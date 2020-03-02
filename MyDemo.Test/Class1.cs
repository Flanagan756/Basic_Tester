using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyDemo;


namespace MyDemo.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public static void  t1()
        {
            //Arrange
            MyDemo.Program p1 = new Program();

            //Act
            int actualresult = p1.Add(5, 10);

            //Assert
            Assert.That(actualresult, Is.EqualTo(15));

        }
        [Test]
        public static void t2()
        {
            //Arrange
            MyDemo.Program p1 = new Program();

            //Act
            int actualresult = p1.Add(5, 10);

            //Assert
            Assert.That(actualresult, Is.EqualTo(25));

        }
    }
}
