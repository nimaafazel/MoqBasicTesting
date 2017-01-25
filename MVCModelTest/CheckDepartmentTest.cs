using NUnit.Framework;
using MVC5_Testing_1.ModelAccess;
using Moq;
using System.Collections.Generic;

namespace MVCModelTest
{
    [TestFixture]
    public class CheckDepartmentTest
    {
        //[Test]
        //public void CheckDepartmentExists()
        //{
        //    var obj = new DepartmentAccess();
        //    var res = obj.CheckDepartmentExists(10);
        //    Assert.That(res, Is.True);
        //}

        [Test]
        public void CheckDepartmentExistsWithMoq()
        {
            // Create fake object
            var fakeObject = new Mock<IDepartmentAccess>();

            // Set the mock configuration
            // The CheckDeptExists() method call is set with an Integer type parameter
            // The configuration also defines the return type for the method
            fakeObject.Setup(x => x.CheckDepartmentExists(It.IsAny<int>())).Returns(true);


            // call the method
            var res = fakeObject.Object.CheckDepartmentExists(10);

            Assert.That(res, Is.True);
        }
    }
}
