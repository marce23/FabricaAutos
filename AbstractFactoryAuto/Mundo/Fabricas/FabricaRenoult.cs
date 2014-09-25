using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAuto.Mundo.Interfaces;
using AbstractFactoryAuto.Mundo.Clases; 

namespace AbstractFactoryAuto.Mundo.Fabricas
{
    class FabricaRenoult:IFabricaDePartes
    {
        public IAuto crearAuto()
        {
            return new AutoRenoult();
        }

        public IMotor crearMotor()
        {
            return new MotorRenoult();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaRenoult();
        }
    }
}
