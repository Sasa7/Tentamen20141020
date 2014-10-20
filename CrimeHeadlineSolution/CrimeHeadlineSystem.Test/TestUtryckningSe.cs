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
            //
            // TODO: Add test logic here
            //
        }

        [TestMethod]
        public void Test_That_UtryckningService_Returns_Headline()
        {
            var expectedHeadline = "Brand på Ahlstroms i Ställdalen";
            IScreenScraperService service = new UtryckningScreenScraperService();
            var headline = service.GetHeadline();

            Assert.AreEqual(expectedHeadline, headline);
        }
    }
}
