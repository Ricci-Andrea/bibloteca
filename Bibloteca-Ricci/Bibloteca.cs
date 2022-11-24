using System;
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

        internal Bibloteca(Libro Libro)
        {
            ElenciLibri.Add(Libro);
        }

        internal string ricercaLibroPerAutore(string autore) 
        {
            foreach (Libro Libro in ElenciLibri) {

                if (Libro.Autore.Contains(autore)) {

                    return Libro.toString();
                }
                
            }
            return null;
        }
        internal string ricercaLibroPerTtitolo(string tittolo)
        {
            foreach (Libro Libro in ElenciLibri)
            {

                if (Libro.titolo.Contains(tittolo))
                {

                    return Libro.toString();
                }

            }
            return null;
        }
    }
    
    
}

