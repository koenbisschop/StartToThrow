using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Vormen
{
    class Cirkel
    {
        const UInt32 MAX_SIZE = 100;
        private static Int32 _aantal = 0;
        private int _nummer;
        public int Nummer
        {
            get
            {
                return _nummer;
            }
            private set
            {
                _nummer = value;
            }
        }
        UInt32 _straal;
        public UInt32 Straal
        {
            get
            {
                return _straal;
            }
            set
            {
                if (value > MAX_SIZE)
                {
                    //mag niet!
                    throw new Exception("Straal is groter dan " + MAX_SIZE);
                }
                else
                {
                    _straal = value;
                }
            }
        }
        public Cirkel (UInt32 straal )
        {
            Straal = straal;
            _aantal++;
            Nummer = _aantal;
        }

        public void Paint(Graphics g)
        {
            Pen pen = new Pen(new SolidBrush(Color.Black));
            g.FillEllipse(new SolidBrush(Color.Yellow), 
                Straal, Straal, Straal, Straal);
            g.DrawEllipse(pen, Straal, Straal, Straal, Straal);

        }

        public override String ToString()
        {
            return $"cirkel {Nummer} met straal {Straal}";
        }
    }
}
