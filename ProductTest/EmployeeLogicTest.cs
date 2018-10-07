using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product;

namespace ProductTest
{
    [TestClass]
    public class EmployeeLogicTest
    {
        private EmployeeEntity employeeEntity = new EmployeeEntity();

        [TestInitialize]
        public void TestInitialize()
        {
            employeeEntity = new EmployeeEntity()
            {
                Id = new Guid("97F201CD-9567-4361-8239-61EA74BBD2CD"),
                FirstName = "Dumitru",
                LastName = "Mafia",
                StartDate = new DateTime(2008, 3, 15),
                EndDate = new DateTime(2019, 3, 15),
                Salary = 2250
            };
        }

        [TestMethod]
        public void Given_EmployeeEntity_When_CallingEmployeeLogicConstructor_Then_CheckIfEmployeeEntityIsNotNull()
        {
            //Arrange && Act
            var employeeLogic = new EmployeeLogic(employeeEntity);

            //Assert
            employeeLogic.Should().NotBeNull();
        }

        [TestMethod]
        public void Given_EmployeeEntityAndEmployeeLogic_When_CallingIsActive_Then_ReturnTrueIfEndDateIsBiggerThanTheStartDateAndIfEmployeeEntityIsNotNull()
        {
            //Arrange
            var employeeLogic = new EmployeeLogic(employeeEntity);

            //Act
            var isActive = employeeLogic.isActive();

            //Assert
            isActive.Should().BeTrue();
        }

        [TestMethod]
        public void Given_EmployeeEntityAndEmployeeLogic_When_CallingGetFullNameMehtod_Then_ReturnTheFullNameOfTheEmployee()
        {
            //Arrange
            var employeeLogic = new EmployeeLogic(employeeEntity);

            //Act
            var fullNameOFTheEmployee = employeeLogic.GetFullName();

            //Assert
            fullNameOFTheEmployee.Should().Be("Dumitru Mafia");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            employeeEntity = null;
        }
    }
}
