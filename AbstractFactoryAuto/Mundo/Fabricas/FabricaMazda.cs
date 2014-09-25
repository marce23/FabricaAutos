using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAuto.Mundo.Interfaces;
using AbstractFactoryAuto.Mundo.Clases; 

namespace AbstractFactoryAuto.Mundo.Fabricas
{
    class FabricaMazda:IFabricaDePartes
    {
        public IAuto crearAuto()
        {
            return new AutoMazda();
        }

        public IMotor crearMotor()
        {
            return new MotorMazda();
        }

        public ICarroceria crearCarroceria()
        {
            return new CarroceriaMazda();
        }
    }
}
