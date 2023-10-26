using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        protected bool cabinaSimple;

        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(propulsion)
        {
            this.cabinaSimple = cabinaSimple;
            base.esAWD = true;
        }

        protected override string Tipo
        {
            get
            {
                return "Camioneta";
            }
        }

        protected override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"[{base.GetInfo}], con cabina: [Simple {this.cabinaSimple} o doble {!this.cabinaSimple}]");
            return sb.ToString();
        }

    }
}
