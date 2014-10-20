using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem.Library
{
    public class PolisenScreenScraperService: SiteBase
    {
        public override string ScrapeUrl
        {
            get { return "http://www.polisen.se"; }
        }

        public override string xPath
        {
            get { return "//*[@id='newslist-1']/div/ul/li[1]/p[1]/a"; }
        }
    }
}
