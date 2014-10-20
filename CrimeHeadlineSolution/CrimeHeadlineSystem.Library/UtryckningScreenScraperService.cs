using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem.Library
{
    public class UtryckningScreenScraperService: SiteBase
    {
        CrimeHeadlineSystemMediator mediator;

        public UtryckningScreenScraperService(CrimeHeadlineSystemMediator mediator)
        {
            this.mediator = mediator;
            this.mediator.RegisterUtryckningsService(this);
        }
        public override string ScrapeUrl
        {
            get { return "http://www.utryckning.se"; }
        }

        public override string xPath
        {
            get { return "//*[@id='cn_item']/li/a"; }
        }

        public override void ReadTopCrime()
        {
            mediator.FoundCrime();
        }
    }
}
