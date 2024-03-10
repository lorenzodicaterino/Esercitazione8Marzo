using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_05_32_Esercitazione.Classes
{
    internal class Giornale : Rivista
    {
        public bool HasInserto { get; set; }

        public Giornale(string? redazione, string? titolo, string? categoria, int quantita, bool hasInserto)
        {
            Redazione = redazione;
            Titolo= titolo;
            Categoria= categoria;
            Quantita = quantita;
            HasInserto = hasInserto;
        }

        protected Giornale () { }
        
        public override string stampaDettaglio()
        {
            return $"[GIORNALE {Redazione.ToUpper()}] Titolo:{Titolo.ToUpper()}, Categoria:{Categoria.ToUpper()}, Quantita:{Quantita} unità, Inserto:{HasInserto.ToString().ToUpper()}.";
        }

        public string esportaCsv()
        {
            return $"{Redazione};{Titolo};{Categoria};{Quantita};{HasInserto.ToString()}\n";
        }
    }
}

