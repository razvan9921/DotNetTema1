
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product;

namespace ProductTest
{
    [TestClass]
    public class ProductLogicTest
    {
        [TestMethod]
        public void Given_ProductEntityAndProductLogic_When_CallingIsValid_Then_ReturnTrueIfEndDateIsBiggerThanTheStartDateAndIfProductEntityIsNotNull()
        {
            //arrange
            var productEntity = new ProductEntity()
            {
                Id = new Guid("761DFFC4-B76B-42BF-98C7-EFE7FB28F283"),
                Name = "Generic Name",
                Description = "generic description",
                StartDate = new DateTime(2008, 3, 15),
                EndDate = new DateTime(2018, 3, 15),
                Price = 399.99,
                VAT = 0.15
            };
            var productLogic = new ProductLogic(productEntity);
            //act
            var isValid = productLogic.isValid();

            //assert
            Assert.AreEqual(true,isValid);
        }
    }
}
