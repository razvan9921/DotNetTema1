using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product;
// aici ii dai namespace-ul pe care il ai in clasa pe care o vrei; namespace Product

namespace ProductTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var product = new ProductEntity(){
            //  stai sa vad daca recunosate clasa la build
                Name = "Vlad"
                //trebuie sa le scrii la mana ca asta e prost, dar recunoaste la build deci e bine sp or 
            };
        }
    }
}
