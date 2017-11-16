


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

            IProduct product1 = ProductFactory.GetProduct(booth1, ProductFactory.Category.Electronic, "IphoneXxX", 12000);
            IProduct product2 = ProductFactory.GetProduct(booth1, ProductFactory.Category.Electronic, "Doro", 200);

            booth1.AddToStock(product1);
            booth1.AddToStock(product2);

            Assert.That(booth1.Stock.Count == 2);

        }

        [Test]

        public void TestRemove()
        {
            Booth booth1 = new Booth("Booth1");

            IProduct product1 = ProductFactory.GetProduct(booth1, ProductFactory.Category.Electronic, "IphoneXxX", 12000);
            IProduct product2 = ProductFactory.GetProduct(booth1, ProductFactory.Category.Electronic, "Doro", 200);

            booth1.AddToStock(product1);
            booth1.AddToStock(product2);

            Assert.That(booth1.Stock.Count == 2);

            booth1.RemoveFromStock(product1.Key);

            Assert.That(booth1.Stock.Count != 2);

        }

        [Test]

        public void TestGuid()
        {
            string Guid1 = BazarController.GenerateUid();
            string Guid2 = BazarController.GenerateUid();

            Assert.AreNotEqual(Guid1, Guid2);

        }

        [Test]

        public void TestGetName()
        {
            Booth booth1 = new Booth("Booth1");
            Assert.NotNull(booth1.Name);
            
        }


    }
}
