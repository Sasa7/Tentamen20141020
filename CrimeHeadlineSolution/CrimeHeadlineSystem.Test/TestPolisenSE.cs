using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrimeHeadlineSystem.Library;

namespace CrimeHeadlineSystem.Test
{
    [TestClass]
    public class TestPolisenSE
    {
        [TestMethod]
        public void Test_Get_Headline_From_PolisenSe()
        {
        }

        [TestMethod]
        public void Test_That_PolisService_Returns_Headline()
        {
            var expected = "Så kan Polisen bättre utreda våldtäkter";
            IScreenScraperService service = new PolisenScreenScraperService();
            var headline = service.GetHeadline();

            Assert.AreEqual(expected, headline);
        }
    }
}
