﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        public Automovil() : base(EPropulsion.Hibrida)
        {
        }

        protected override string Tipo
        {
            get
            {
                return "Automovil";
            }
        }

    }
}
