using System;
using FluentAssertions;
using NUnit.Framework;
using Product;

namespace Tests
{
    public class ArchitectLogicTests
    {
        private ArchitectEntity architectEntity = new ArchitectEntity();

        [SetUp]
        public void Initialize()
        {
            architectEntity = new ArchitectEntity()
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
        public void Given_ArchitectEntity_When_CallingArchitectLogicConstructor_Then_CheckIfArchitectEntityIsNotNull()
        {
            //Arrange && Act
            var architectLogic = new ArchitectLogic(architectEntity);

            //Assert
            architectLogic.Should().NotBeNull();
        }

        [Test]
        public void Given_ArchitectEntityAndArchitectLogic_When_CallingIsActive_Then_ReturnTrueIfEndDateIsBiggerThanTheStartDateAndIfArchitectEntityIsNotNull()
        {
            //Arrange
            var architectLogic = new ArchitectLogic(architectEntity);

            //Act
            var isActive = architectLogic.isActive();

            //Assert
            isActive.Should().BeTrue();
        }

        [Test]
        public void Given_ArchitectEntityAndArchitectLogic_When_CallingGetFullNameMehtod_Then_ReturnTheFullNameOfTheArchitect()
        {
            //Arrange
            var architectLogic = new ArchitectLogic(architectEntity);

            //Act
            var fullNameOFTheArchitect = architectLogic.GetFullName();

            //Assert
            fullNameOFTheArchitect.Should().Be("Dumitru Mafia");
        }

        [TearDown]
        public void TestCleanup()
        {
            architectEntity = null;
        }
    }
}