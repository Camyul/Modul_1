using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using NUnit.Framework;
using System;

namespace TestAcademy
{
    [TestFixture]
    public class TestHumans
    {
        [Test]
        public void TestUsename_ShouldThrowExeption_WhenStringIsTooShortOrTooLong()
        {
            //Arange
            IStudent student1 = new Student();
            

            //Act & Assert

            Assert.Throws<ArgumentOutOfRangeException>(() => student1.Username = "e");
        }

        [Test]
        public void TestSeasonPropCourse_ShouldBeIncreaseCourseCount()
        {
            //Arange
            ISeason season2017 = new Season(2016, 2017, Initiative.SoftwareAcademy);
            ICourse css = new Course("CSS", 6, DateTime.Parse("11-11-2016"));

            //Act
            season2017.Courses.Add(css);

            //Assert
            Assert.AreEqual(1, season2017.Courses.Count);
        }
    }
}
