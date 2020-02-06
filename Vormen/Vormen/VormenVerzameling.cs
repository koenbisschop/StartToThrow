using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Vormen
{
    class VormenVerzameling
    {
        public int Aantal {
            get
            {
                return Vorm.Aantal;
            }
        }
        public List<Vorm> VormenLijst { get; private set; }
        public VormenVerzameling()
        {
            VormenLijst = new List<Vorm>();
        }
        public void Paint(Graphics g)
        {
            foreach (Vorm v in VormenLijst)
            {
                if (v is Cirkel)
                {
                    Cirkel c = (Cirkel)v;
                    c.Paint(g);
                }
                else if (v is Vierkant)
                {
                    Vierkant vierkant = (Vierkant)v;
                    vierkant.Paint(g);
                }
            }
        }
    }
}
