using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAuto.Mundo.Interfaces; 

namespace AbstractFactoryAuto.Mundo.Clases
{
    class AutoRenoult:IAuto
    {
        public string darNombre()
        {
            return "Auto Renoult";
        }
    }
}
