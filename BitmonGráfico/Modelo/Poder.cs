﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Poder
    {
        public int danio, costo;
        public string tipo, ulti, nombre;

        public Poder(int danio, int costo, string tipo, string ulti, string nombre)
        {
            this.danio = danio;
            this.costo = costo;
            this.tipo = tipo;
            this.ulti = ulti;
            this.nombre = nombre;
        }
    }
}
