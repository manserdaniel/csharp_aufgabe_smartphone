using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    internal class Game : App
    {
        public bool Multiplayer { get; set; }
        public int timer { get; set; }

        public Game(string name, string version, bool multiplayer) : base(name, version)
        {
            Multiplayer = multiplayer;
        }

        public override string ToString()
        {
            return $"{Name} Version: {Version} Multiplayer: {Multiplayer}";
        }

        public override string StartApp()
        {
            base.On = true;
            return "Game is On!";
        }
    }
}
