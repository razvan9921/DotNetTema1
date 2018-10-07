using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product;

namespace ProductTest
{
    [TestClass]
    public class ProductLogicTest
    {
        private ProductEntity productEntity = new ProductEntity();

        [TestInitialize]
        public void TestInitialize()
        {
            productEntity = new ProductEntity()
            {
                Id = new Guid("761DFFC4-B76B-42BF-98C7-EFE7FB28F283"),
                Name = "Generic Name",
                Description = "generic description",
                StartDate = new DateTime(2008, 3, 15),
                EndDate = new DateTime(2018, 3, 15),
                Price = 399.99,
                VAT = 0.15
            };
        }

        [TestMethod]
        public void Given_ProductEntityAndProductLogic_When_CallingIsValid_Then_ReturnTrueIfEndDateIsBiggerThanTheStartDateAndIfProductEntityIsNotNull()
        {
            //Arrange
            var productLogic = new ProductLogic(productEntity);

            //Act
            var isValid = productLogic.isValid();

            //Assert
            isValid.Should().BeTrue();
        }

        [TestMethod]
        public void Given_ProductEntity_When_CallingProjectLogicConstructor_Then_CheckIfProjectEntityIsNotNull()
        {
            //Arrange && Act
            var productLogic = new ProductLogic(productEntity);

            //Assert
            productLogic.Should().NotBeNull();
        }

        [TestMethod]
        public void Given_ProductEntityAndProductLogic_When_CallingComputeVAT_Then_ReturnTheProductPriceWithTheVATComputed()
        {
            //Arrange
            var productLogic = new ProductLogic(productEntity);

            //Act
            var productWithVat = productLogic.ComputeVAT();

            //Assert
            productWithVat.Should().BeGreaterThan(productEntity.Price);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            productEntity = null;
        }
    }
}
