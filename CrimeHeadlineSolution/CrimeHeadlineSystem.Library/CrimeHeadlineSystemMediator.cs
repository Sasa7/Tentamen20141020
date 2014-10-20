using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem.Library
{
    public class CrimeHeadlineSystemMediator
    {
        PolisenScreenScraperService polis;
        UtryckningScreenScraperService utryckning;
        SiteBase service;

        internal void RegisterPolisService(PolisenScreenScraperService polisService)
        {
            polis = polisService;
            service = polisService;
        }

        internal void RegisterUtryckningsService(UtryckningScreenScraperService utryckningService)
        {
            utryckning = utryckningService;
            service = utryckningService;
        }

        internal void FoundCrime()
        {
            Console.WriteLine(service.GetHeadline() + " " + service.ScrapeUrl);
        }
    }
}
