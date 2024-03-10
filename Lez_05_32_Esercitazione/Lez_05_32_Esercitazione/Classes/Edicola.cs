using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lez_05_32_Esercitazione.Classes
{
    internal class  Edicola
    {
        public int qStock { get; set; }

        public Edicola()
        {

        }

        public virtual void aggiornaQuantita(int val)
        {
            qStock += val;
        }

        public virtual int stampaQuantita()
        {
            return qStock;
        }
    }
}
