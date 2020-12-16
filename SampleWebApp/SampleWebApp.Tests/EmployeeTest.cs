using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleWebApp.Controllers;
using SampleWebApp.Models;

namespace SampleWebApp.Tests
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var employeeList = GetAllEmployees();

            EmployeeController controller = new EmployeeController();

            var result = controller.GetAllEmployees();
            Assert.AreEqual(employeeList.Count, result.Count);
        }

        private List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee()
                {
                    EmployeeId = 1, EmployeeName = "Sangeetha", Address = "Chennai", Department = "IT"
                },
                new Employee()
                {
                    EmployeeId = 2, EmployeeName = "BulBuli Swain", Address = "Chennai", Department = "HR"
                },
                new Employee()
                {
                    EmployeeId = 3, EmployeeName = "Manickam", Address = "Thanbaram", Department = "Tech Lead"
                },
                new Employee()
                {
                    EmployeeId = 4, EmployeeName = "Kalai", Address = "Guduvanchery", Department = "Senior Developer"
                },
                new Employee()
                {
                    EmployeeId = 5, EmployeeName = "Sowmiya", Address = "Trichy", Department = "HR"
                },
            };

            return employees;
        }
    }
}
