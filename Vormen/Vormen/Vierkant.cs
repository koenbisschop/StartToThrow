using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Vormen
{
    class Vierkant: Vorm
    {
        const UInt32 MAX_SIZE = 100;
        UInt32 _zijde;
        public UInt32 Zijde
        {
            get
            {
                return _zijde;
            }
            set
            {
                if (value > MAX_SIZE)
                {
                    //mag niet!
                    throw new Exception("Zijde is groter dan " + MAX_SIZE);
                }
                else
                {
                    _zijde = value;
                }
            }
        }
        public Vierkant (UInt32 zijde )
        {
            Zijde = zijde;
        }

        public void Paint(Graphics g)
        {
            Pen pen = new Pen(new SolidBrush(Color.Black));
            g.FillEllipse(new SolidBrush(Color.Yellow), 
                Zijde, Zijde, Zijde, Zijde);
            g.DrawEllipse(pen, Zijde, Zijde, Zijde, Zijde);

        }

        public override String ToString()
        {
            return $"vierkant {Nummer} met straal {Zijde}";
        }
    }
}
