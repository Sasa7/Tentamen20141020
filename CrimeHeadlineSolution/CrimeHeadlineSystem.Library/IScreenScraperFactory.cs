using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem.Library
{
    public interface IScreenScraperFactory
    {
        IScreenScraperService GetSite(string site);
    }
}
