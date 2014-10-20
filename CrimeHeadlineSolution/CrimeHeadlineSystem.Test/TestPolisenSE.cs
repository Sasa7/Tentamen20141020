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
            CrimeHeadlineSystemMediator mediator = new CrimeHeadlineSystemMediator();
            IScreenScraperFactory factory = new ScreenScraperFactory();
            IScreenScraperService polisService = factory.GetScreenScraperType("www.polisen.se", mediator);
            polisService.ReadTopCrime();
        }

        [TestMethod]
        public void Test_That_PolisService_Returns_Headline()
        {
            CrimeHeadlineSystemMediator system = new CrimeHeadlineSystemMediator();
            var expected = "Så kan Polisen bättre utreda våldtäkter";
            IScreenScraperService service = new PolisenScreenScraperService(system);
            var headline = service.GetHeadline();

            Assert.AreEqual(expected, headline);
        }
    }
}
