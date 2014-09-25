using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryAuto.Mundo.Interfaces;

namespace AbstractFactoryAuto.Mundo.Clases
{
    class CarroceriaMazda:ICarroceria
    {
       
     public string  darNombre()
    {
        return "Carroceria Mazda";
    }
}
}
