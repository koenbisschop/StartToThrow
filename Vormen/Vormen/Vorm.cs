using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vormen
{
    class Vorm
    {
        private static Int32 _aantal = 0;
        public static Int32 Aantal
        {
            get
            {
                return _aantal;
            }
        }
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
        public Vorm()
        {
            _aantal++;
            Nummer = _aantal;
        }
    }
}
