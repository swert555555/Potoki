using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Потоки
{
    public class Top_Polsovatelei
    {
        public string? Name;
        public List<Polsovatel>? Vse_polsovateli;
    }

    public class Polsovatel
    {
        public string? Name;
        public static int Vsego_Simvol = 0;
        private int Simvol_Minyta = Vsego_Simvol / 60;

        public Polsovatel(string Name)
        {
            this.Name = Name;
        }
    }


}
