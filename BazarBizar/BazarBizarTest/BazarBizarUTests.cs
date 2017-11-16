


using ProductFactory = BazarBizar.ProductFactory;
using Booth = BazarBizar.Booth;

namespace BazarBizarTest
{
    using System;
    using BazarBizar;
    using NUnit.Framework;
    using ProductFactory = ProductFactory;
    using Booth = Booth;

    [TestFixture]
    public class BazarBizarUTests
    {

        #region TestFixture Config
        [OneTimeSetUp]
        public void InitalSetup()
        {

        }


        [OneTimeTearDown]
        public void FinalTearDown()
        {

        }


        [SetUp]
        public void SetupForEachTest()
        {

        }

        [TearDown]
        public void TearDownForEachTest()
        {

        }
        #endregion /TestFixture Config
        [Test]
        public void TestCategory()
        {
            Booth booth1 = new Booth("Booth1");

            IProduct item = ProductFactory.GetProduct(booth1, ProductFactory.Category.Clothing, "genser", 200);
            Assert.That(item.Category == "Clothing");
        }

        [Test]

        public void TestBoothStockCount()
        {
            Booth booth1 = new Booth("Booth1");

            booth1.AddToStock(ProductFactory.GetProduct(booth1, ProductFactory.Category.Electronic, "IphoneXxX", 12000));
            booth1.AddToStock(ProductFactory.GetProduct(booth1, ProductFactory.Category.Electronic, "Doro", 200));

            Assert.That(booth1.Stock.Count == 2);

        }

        [Test]

        public void TestGuid()
        {
            string Guid1 = BazarController.GenerateUid();
            string Guid2 = BazarController.GenerateUid();

            Assert.AreNotEqual(Guid1, Guid2);

        }
    }
}
