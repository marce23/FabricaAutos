using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryAuto.Mundo.Interfaces
{
    interface IFabricaDePartes
    {
        IAuto crearAuto();
        IMotor crearMotor();
        ICarroceria crearCarroceria();
    }
}
