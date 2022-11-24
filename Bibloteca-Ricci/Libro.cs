using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca_Ricci
{
    internal class Libro
    {
        internal string Autore { get; set; }
        internal string titolo { get; set; }
        internal string AnnoDiPublicazione { get; set; }
        internal string Editore { get; set; }
        internal int numeroDiPagine { get; set; }

        internal  string toString() {

            return $"L'autore {Autore},Titolo: {titolo}, anno Di Publicazione: {AnnoDiPublicazione},editore: {Editore},numero Di Paggine: {numeroDiPagine} ";
        
        }

        internal string readingTime(Libro Libro)
        { 
            int tempoDiLettura = 0;

            if (Libro.numeroDiPagine < 100)
            {
                tempoDiLettura = 1;
            }
            else if (Libro.numeroDiPagine > 100 || Libro.numeroDiPagine < 200)
            {
                tempoDiLettura = 2;
            }
            else 
            {
                return "Il tempo Di lettura e superiore alle due ore";

            }
            return tempoDiLettura.ToString();
        
        }

    }
}
