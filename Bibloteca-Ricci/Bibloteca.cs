﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca_Ricci
{
    internal class Bibloteca
    {
        internal string Nome { get; set; }
        internal int orarioDiApertura { get; set; }
        internal int orarioDiCiusura { get; set; }
        List<Libro> ElenciLibri = new();

        internal Bibloteca(Libro Libro, string nome, int oraIn, int oraOut)
        {

            ElenciLibri.Add(Libro);
            this.orarioDiApertura = oraIn;
            this.Nome = nome;
            this.orarioDiCiusura = oraOut;
        }
    }
    
    
}
