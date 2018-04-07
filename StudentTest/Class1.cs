using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Student3;

namespace StudentTest
{
    [TestFixture]
    public class StudentTest
    {
        [Test]
        public void TestConstructor()
        {
            Student st1 = new Student("karel", 22);
            Assert.AreEqual("karel", st1.GetName());
            
        }

        [Test]
        public void TestGetAge()
        {
            Student st1 = new Student("Luke Irving", 23);
            Assert.AreEqual(23, st1.GetAge());
        }
        
        [Test]
        public void TestNewbieStatus()
        {
            Student st1 = new Student("Chloe Horner", 24);
            Assert.AreEqual("I am not a newbie anymore", st1.NewbieStatus());
        }

        [Test]
        public void TestYearStudyingStatusBar()
        {
            Student st1 = new Student("Stephanie DeLorenzo", 22);
            Assert.AreEqual("---@@@@", st1.YearStudyingStatusBar());
        }

        [Test]
        public void TestGetPyramidValidBaseLen()
        {
            Assert.AreEqual("   *   \n  ***  \n ***** \n*******\n", Student.GetPyramid(7));
        }

        [Test]
        public void TestGetPyramidInvalidBaseLen()
        {
            try
            {
                Student.GetPyramid(7);

            }

            catch(ArgumentException)
            {
                Assert.Pass();
            }

            catch
            {
                Assert.Fail();
            }

        }
    }
}
