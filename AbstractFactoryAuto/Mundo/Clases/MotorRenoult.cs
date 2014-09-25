using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAuto.Mundo.Interfaces; 

namespace AbstractFactoryAuto.Mundo.Clases
{
    class MotorRenoult:IMotor
    {
        public string darNombre()
        {
            return "Motor Renoult";
        }
    }
}
