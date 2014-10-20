using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem.Library
{
    public interface IScreenScraperService
    {
        string GetHeadline();
        void ReadTopCrime();
    }
}
