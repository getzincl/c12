using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContosoUniversity;
using ContosoUniversity.Controllers;
using ContosoUniversity.Models;

namespace ContosoUniversity.Tests.Controllers
{
    [TestClass]
    public class StudentControllerTest
    {
        [TestMethod]
        //FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")
        public void Create()
        {
            // Arrange
            StudentController controller = new StudentController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            
        }

        [TestMethod]
        //FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")
        public void TestEditPost()
        {
            // Arrange
            StudentController controller = new StudentController();

            // Act
            ViewResult result = controller.EditPost(2) as ViewResult;

            // Assert
            Assert.IsNotNull(result);

        }
    }



}
