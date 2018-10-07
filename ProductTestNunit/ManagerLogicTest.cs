using System;
using FluentAssertions;
using NUnit.Framework;
using Product;

namespace Tests
{
    public class ManagerLogicTests
    {
        private ManagerEntity managerEntity = new ManagerEntity();

        [SetUp]
        public void Initialize()
        {
            managerEntity = new ManagerEntity()
            {
                Id = new Guid("97F201CD-9567-4361-8239-61EA74BBD2CD"),
                FirstName = "Dumitru",
                LastName = "Mafia",
                StartDate = new DateTime(2008, 3, 15),
                EndDate = new DateTime(2019, 3, 15),
                Salary = 2250
            };
        }


        [Test]
        public void Given_ManagerEntity_When_CallingManagerLogicConstructor_Then_CheckIfManagerEntityIsNotNull()
        {
            //Arrange && Act
            var managerLogic = new ManagerLogic(managerEntity);

            //Assert
            managerLogic.Should().NotBeNull();
        }

        [Test]
        public void Given_ManagerEntityAndManagerLogic_When_CallingIsActive_Then_ReturnTrueIfEndDateIsBiggerThanTheStartDateAndIfManagerEntityIsNotNull()
        {
            //Arrange
            var managerLogic = new ManagerLogic(managerEntity);

            //Act
            var isActive = managerLogic.isActive();

            //Assert
            isActive.Should().BeTrue();
        }

        [Test]
        public void Given_ManagerEntityAndManagerLogic_When_CallingGetFullNameMehtod_Then_ReturnTheFullNameOfTheManager()
        {
            //Arrange
            var managerLogic = new ManagerLogic(managerEntity);

            //Act
            var fullNameOFTheManager = managerLogic.GetFullName();

            //Assert
            fullNameOFTheManager.Should().Be("Dumitru Mafia");
        }

        [TearDown]
        public void TestCleanup()
        {
            managerEntity = null;
        }
    }
}