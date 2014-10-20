using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem.Library
{
    class ScreenScraperFactory: IScreenScraperFactory
    {
        public IScreenScraperService GetSite(string site)
        {
            IScreenScraperService service = null;
            switch(site)
            {
                case "www.polisen.se": service = new PolisenScreenScraperService();
                    break;
                case "www.utryckning.se": service = new UtryckningScreenScraperService();
                    break;
                default:
                    break;

            }
            return service;
        }
    }
}
