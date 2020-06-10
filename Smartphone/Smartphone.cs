using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    class Smartphone
    {
        List<App> Apps = new List<App>();

        internal List<App> Apps1 { get => Apps; set => Apps = value; }
    }
}
