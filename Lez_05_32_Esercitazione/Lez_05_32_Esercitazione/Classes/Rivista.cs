using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_05_32_Esercitazione.Classes
{
    internal class Rivista
    {
        public string? Redazione { get; set; }
        public string? Titolo { get; set; }
        public string? Categoria { get; set; }
        public int Quantita { get; set; }

        public Rivista(string? redazione, string? titolo, string? categoria, int quantita) 
        {
            Redazione = redazione;
            Titolo = titolo;
            Categoria = categoria;
            Quantita = quantita;
        }

        public Rivista() { }

        public virtual string stampaDettaglio()
        {
            return $"[RIVISTA {Redazione.ToUpper()}] Titolo:{Titolo.ToUpper()}, Categoria:{Categoria.ToUpper()}, Quantità:{Quantita} unità.";
        }

        public virtual string esportaCsv()
        {
            return $"{Redazione};{Titolo};{Categoria};{Quantita}\n";
        }


    }
}
