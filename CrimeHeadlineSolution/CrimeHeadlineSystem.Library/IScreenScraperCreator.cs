using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem.Library
{
    public interface IScreenScraperCreator
    {
        IScreenScraperService GetScreenScraperType(string site, CrimeHeadlineSystemMediator mediator);
    }
}
