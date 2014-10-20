using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem.Library
{
    public class ScreenScraperFactory: IScreenScraperFactory
    {
        public IScreenScraperService GetScreenScraperType(string site, CrimeHeadlineSystemMediator mediator)
        {
            IScreenScraperService service = null;
            switch(site)
            {
                case "www.polisen.se": service = new PolisenScreenScraperService(mediator);
                    break;
                case "www.utryckning.se": service = new UtryckningScreenScraperService(mediator);
                    break;
                default:
                    break;

            }
            return service;
        }
    }
}
