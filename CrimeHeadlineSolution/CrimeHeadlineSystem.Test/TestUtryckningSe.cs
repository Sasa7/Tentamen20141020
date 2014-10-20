using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrimeHeadlineSystem.Library;

namespace CrimeHeadlineSystem.Test
{
    /// <summary>
    /// Summary description for TestUtryckningSe
    /// </summary>
    [TestClass]
    public class TestUtryckningSe
    {
      

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Test_Get_Headline_From_UtryckningSe()
        {
            CrimeHeadlineSystemMediator mediator = new CrimeHeadlineSystemMediator();
            IScreenScraperFactory factory = new ScreenScraperFactory();
            IScreenScraperService polisService = factory.GetScreenScraperType("www.utryckning.se", mediator);
            polisService.ReadTopCrime();
        }

        [TestMethod]
        public void Test_That_UtryckningService_Returns_Headline()
        {
            CrimeHeadlineSystemMediator system = new CrimeHeadlineSystemMediator();
            var expectedHeadline = "Brand på Ahlstroms i Ställdalen";
            IScreenScraperService service = new UtryckningScreenScraperService(system);
            var headline = service.GetHeadline();

            Assert.AreEqual(expectedHeadline, headline);
        }
    }
}
