using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem.Library
{
    public abstract class SiteBase: IScreenScraperService
    {
        public string GetHeadline()
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            string url = string.Format(this.ScrapeUrl);
            HtmlDocument htmlDocument = htmlWeb.Load(url);

            HtmlNode headline = htmlDocument.DocumentNode.SelectSingleNode(this.xPath);

            return headline.InnerHtml;
        }

        public abstract string ScrapeUrl { get; }
        public abstract string xPath { get; }

        //public abstract void ReadTopCrime();



        public virtual void ReadTopCrime()
        {
        }
    }
}
