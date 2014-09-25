using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAuto.Mundo.Interfaces;
using AbstractFactoryAuto.Mundo.Clases; 

namespace AbstractFactoryAuto.Mundo.Fabricas
{
    class FabricaChevrolet: IFabricaDePartes
        {
            public IAuto crearAuto()
        {
            return new AutoChevrolet();
        }

           public IMotor crearMotor()
        {
            return new MotorChevrolet();
        }

            public ICarroceria crearCarroceria()
        {
            return new CarroceriaChevrolet();
        }
        }
    }
}
