using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    class App
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public bool On { get; set; }

        public App(string name, string version)
        {
            Name = name;
            Version = version;
        }

        public override string ToString()
        {
            return $"{Name} Version: {Version}";
        }

        public virtual string StartApp()
        {
            On = true;
            return "App has started!";
        }
    }
}
