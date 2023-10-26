using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public Fabrica(int capacidad)
        {
            this.capacidad = capacidad;
        }

        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public List<Vehiculo> Vehiculos { get => vehiculos; }

        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if ( fabrica.vehiculos.Count < fabrica.capacidad)
            {
                fabrica.vehiculos.Add(vehiculo);                
            }
            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            foreach (var item in fabrica.vehiculos)
            {
                if (item.GetType() == vehiculo.GetType() && item == vehiculo)
                {
                    fabrica.vehiculos.Remove(vehiculo);
                    break;
                }
            }
            return fabrica;
        }
    }
}
