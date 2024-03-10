using Lez_05_32_Esercitazione.Classes;

namespace Lez_05_32_Esercitazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Giornale> giornali = new List<Giornale>();
            List<Rivista> riviste = new List<Rivista>();
            Edicola edicola = new Edicola();

            #region Dimensione edicola
            Console.Write("Inserisci dimensione inventario edicola: ");
            int qInput = Convert.ToInt32(Console.ReadLine());

            bool qMinore = true;

            if(qInput <= 0)
            {
                while (qMinore) 
                {
                    Console.WriteLine("La dimensione del'inventario non può essere minore o uguale a zero.");
                    Console.Write("Inserisci dimensione inventario edicola: ");
                    qInput = Convert.ToInt32(Console.ReadLine());
                    if (qInput > 0)
                    {
                        qMinore = false;
                    }
                }
            }

            edicola.aggiornaQuantita(qInput);
            Console.WriteLine($"Dimensione edicola imposta a {edicola.stampaQuantita()}");

            #endregion
            
            bool continua = true;

            Console.Write("Si vuole inserire un giornale o una rivista? (G/R) ");
            string? sceltaTipo = Console.ReadLine();

            if (sceltaTipo is not null && sceltaTipo.ToUpper().Equals("G"))
            {
                #region Giornale
                while (continua)
                {

                    Console.Write("Inserisci nome redazione: ");
                    string? redazioneGiornale = Console.ReadLine();

                    Console.Write("Inserisci titolo del giornale: ");
                    string? titoloGiornale = Console.ReadLine();

                    Console.Write("Inserisci categoria del giornale: ");
                    string? categoriaGiornale = Console.ReadLine();

                    Console.Write("Inserisci quantità: ");
                    int quantitaGiornale = Convert.ToInt32(Console.ReadLine());

                    bool haInsertoGiornale;

                    Console.Write("Il giornale ha un inserto? (true/false) ");
                    if (Console.ReadLine().ToLower().Equals("true"))
                        haInsertoGiornale = true;
                    else
                        haInsertoGiornale = false;

                    if (quantitaGiornale > 0)
                    {
                        Giornale giornaleOgg = new Giornale(redazioneGiornale, titoloGiornale, categoriaGiornale, quantitaGiornale, haInsertoGiornale);
                        giornali.Add(giornaleOgg);
                    }
                    
                    Console.Write("Desideri inserire altri giornali? (Y/N) ");
                    string? sceltaContinuaG = Console.ReadLine();

                    if (sceltaContinuaG is not null && sceltaContinuaG.ToUpper().Equals("N"))
                        continua = false;
                }

                Console.Write("Vuoi inserire una rivista? (Y/N) ");
                string? cambioSceltaG = Console.ReadLine();
                if (cambioSceltaG is not null && cambioSceltaG.ToUpper().Equals("Y"))
                {
                    continua = true;

                    #region Riviste in Giornali

                    while (continua)
                    {
                        Console.Write("Inserisci nome redazione: ");
                        string? redazioneRivista = Console.ReadLine();

                        Console.Write("Inserisci titolo della rivista: ");
                        string? titoloRivista = Console.ReadLine();

                        Console.Write("Inserisci categoria della rivista: ");
                        string? categoriaRivista = Console.ReadLine();

                        Console.Write("Inserisci quantità: ");
                        int quantitaRivista = Convert.ToInt32(Console.ReadLine());

                        if (quantitaRivista > 0)
                        {
                            Rivista rivistaOgg = new Rivista(redazioneRivista, titoloRivista, categoriaRivista, quantitaRivista);
                            riviste.Add(rivistaOgg);
                        }

                        Console.Write("Desideri inserire altre riviste? (Y/N) ");
                        string? sceltaContinuaR = Console.ReadLine();

                        if (sceltaContinuaR is not null && sceltaContinuaR.ToUpper().Equals("N"))
                            continua = false;
                    }

                    #endregion
                }


                #endregion
            }
            else if (sceltaTipo is not null && sceltaTipo.ToUpper().Equals("R"))
            {
                #region Rivista
                while (continua)
                {
                    Console.Write("Inserisci nome redazione: ");
                    string? redazioneRivista = Console.ReadLine();

                    Console.Write("Inserisci titolo della rivista: ");
                    string? titoloRivista = Console.ReadLine();

                    Console.Write("Inserisci categoria della rivista: ");
                    string? categoriaRivista = Console.ReadLine();

                    Console.Write("Inserisci quantità: ");
                    int quantitaRivista = Convert.ToInt32(Console.ReadLine());

                    if (quantitaRivista > 0)
                    {
                        Rivista rivistaOgg = new Rivista(redazioneRivista, titoloRivista, categoriaRivista, quantitaRivista);
                        riviste.Add(rivistaOgg);
                    }

                    Console.Write("Desideri inserire altre riviste: (Y/N) ");
                    string? sceltaContinuaR = Console.ReadLine();

                    if (sceltaContinuaR is not null && sceltaContinuaR.ToUpper().Equals("N"))
                        continua = false;
                }

                Console.WriteLine("Vuoi inserire un giornale? (Y/N) ");
                string? cambioSceltaR = Console.ReadLine();
                if (cambioSceltaR is not null && cambioSceltaR.ToUpper().Equals("Y"))
                {
                    #region Giornali In Riviste
                    continua = true;

                    while (continua)
                    {

                        Console.Write("Inserisci nome redazione: ");
                        string? redazioneGiornale = Console.ReadLine();

                        Console.Write("Inserisci titolo del giornale: ");
                        string? titoloGiornale = Console.ReadLine();

                        Console.Write("Inserisci categoria del giornale: ");
                        string? categoriaGiornale = Console.ReadLine();

                        Console.Write("Inserisci quantità: ");
                        int quantitaGiornale = Convert.ToInt32(Console.ReadLine());

                        bool haInsertoGiornale;

                        Console.Write("Il giornale ha un inserto? (true/false) ");
                        if (Console.ReadLine().ToLower().Equals("true"))
                            haInsertoGiornale = true;
                        else
                            haInsertoGiornale = false;

                        if (quantitaGiornale > 0)
                        {
                            Giornale giornaleOgg = new Giornale(redazioneGiornale, titoloGiornale, categoriaGiornale, quantitaGiornale, haInsertoGiornale);
                            giornali.Add(giornaleOgg);
                        }

                        Console.Write("Desideri inserire altri giornali?: (Y/N) ");
                        string? sceltaContinuaG = Console.ReadLine();

                        if (sceltaContinuaG is not null && sceltaContinuaG.ToUpper().Equals("N"))
                            continua = false;
                    }
                    #endregion
                }
                #endregion
            }
            else
                Console.WriteLine("Valore inserito non valido. Riprovare.");


            #region Elimina
            Console.Write("Vuoi eliminare qualcuno degli elementi inseriti? (Y/N) ");
            string? sceltaElimina = Console.ReadLine();

            if (sceltaElimina is not null && sceltaElimina.ToUpper().Equals("Y")) 
            {
                bool continuaElimina = true;
                
                #region Stampa
                Console.WriteLine("");
                for (int i = 0; i < giornali.Count; i++)
                {
                    Console.WriteLine(giornali[i].stampaDettaglio());
                }
                Console.WriteLine("");
                for (int i = 0; i < riviste.Count; i++)
                {
                    Console.WriteLine(riviste[i].stampaDettaglio());
                }
                #endregion
                Console.WriteLine("");

                while (continuaElimina)
                {
                    Console.Write("Inserisci la redazione dell'elemento da eliminare: ");
                    string? redazioneElimina = Console.ReadLine();

                    for (int i = 0; i < giornali.Count; i++)
                    {
                        if (giornali[i].Redazione.ToUpper().Equals(redazioneElimina.ToUpper())) 
                        { 
                            giornali.RemoveAt(i);
                            Console.WriteLine("Giornale Eliminato.");
                        }
                    }

                    for (int i = 0; i < riviste.Count; i++)
                    {
                        if (riviste[i].Redazione.ToUpper().Equals(redazioneElimina.ToUpper())) 
                        {
                            riviste.RemoveAt(i);
                            Console.WriteLine("Rivista Eliminato.");
                        }
                    }

                    Console.Write("Vuoi eliminare altri elementi? (Y/N) ");
                    string sceltaELimina = Console.ReadLine();

                    if (sceltaELimina is not null && sceltaELimina.ToUpper().Equals("N"))
                        continuaElimina = false;
                    
                } 
            }
            #endregion

            #region Aggiorna stock

            int con = 0;
            
            for(int i=0; i<giornali.Count; i++)
            {
                con += giornali[i].Quantita;
            }

            for (int i = 0; i < riviste.Count; i++)
            {
                con += riviste[i].Quantita;
            }

            bool controlloQ = true;

            if (qInput < con)
            {
                while (controlloQ)
                {
                    Console.Write("La quantità di riviste e giornali arrivati non consente di immagazinarli nell'edicola, inserisci quanta capacità da aggiungere all'edicola: ");
                    int aggQ = Convert.ToInt32(Console.ReadLine());
                    edicola.aggiornaQuantita(aggQ);

                    if (edicola.qStock > con)
                        controlloQ = false;
                }
            }

            Console.WriteLine($"L'attuale capacità dell'edicola equivale a {edicola.stampaQuantita()}.");
            #endregion

            #region Stampa
            Console.WriteLine("Ecco a te la lista di tutte le pubblicazioni disponibili:");
            Console.WriteLine("");
                for (int i = 0; i < giornali.Count; i++)
                {
                    Console.WriteLine(giornali[i].stampaDettaglio());
                }
                Console.WriteLine("");
                for (int i = 0; i < riviste.Count; i++)
                {
                    Console.WriteLine(riviste[i].stampaDettaglio());
                }
            Console.WriteLine("");
            #endregion

            #region Stampa per stock

            Console.Write("Si desidera filtrare l'elenco delle pubblicazioni per quantità disponibili in stock? (Y/N) ");
            string scFQ = Console.ReadLine();

            bool continuaFilterQ = true;

            if(scFQ is not null && scFQ.ToUpper().Equals("Y")) 
            {
                while (continuaFilterQ) 
                {
                    Console.WriteLine("Inserisci una quantità per visualizzare tutti gli elementi con una quantità maggiore: ");
                    int qInputF = Convert.ToInt32(Console.ReadLine());
                    if (qInputF > 0)
                    {
                        Console.WriteLine("GIORNALI:");
                        for (int i = 0; i < giornali.Count(); i++)
                        {
                            if (giornali[i].Quantita >= qInputF)
                            {
                                Console.WriteLine(giornali[i].stampaDettaglio());
                            }
                        }

                        Console.WriteLine("RIVISTE:");
                        for (int i = 0; i < riviste.Count(); i++)
                        {
                            if (riviste[i].Quantita > qInputF)
                            {
                                Console.WriteLine(riviste[i].stampaDettaglio());
                            }
                        }
                    }
                    else
                        Console.WriteLine("Non si possono stampare elementi con una quantità minore di zero.");

                    Console.WriteLine("Desideri filtrare per un altra quantità? (Y/N) ");
                    string sceltaFQ = Console.ReadLine();
                    if (sceltaFQ is not null && sceltaFQ.ToUpper().Equals("N"))
                        continuaFilterQ = false;
                }
            }


            #endregion

            #region Stampa per titolo

            Console.Write("Si desidera filtrare l'elenco delle pubblicazioni per titolo della pubblicazione? (Y/N) ");
            string scFT = Console.ReadLine();

            bool continuaFilterT = true;

            if (scFT is not null && scFT.ToUpper().Equals("Y"))
            {
                while (continuaFilterT)
                {
                    Console.Write("Inserisci un titolo per visualizzare tutte le pubblicazioni corrispondenti: ");
                    string tInputF = Console.ReadLine();
                    if (tInputF is not null)
                    {
                        Console.WriteLine("GIORNALI:");
                        for (int i = 0; i < giornali.Count(); i++)
                        {
                            if (giornali[i].Titolo.ToUpper().Equals(tInputF.ToUpper()))
                            {
                                Console.WriteLine(giornali[i].stampaDettaglio());
                            }
                        }

                        Console.WriteLine("RIVISTE:");
                        for (int i = 0; i < riviste.Count(); i++)
                        {
                            if (riviste[i].Titolo.ToUpper().Equals(tInputF.ToUpper()))
                            {
                                Console.WriteLine(riviste[i].stampaDettaglio());
                            }
                        }
                    }
                    else
                        Console.WriteLine("Il valore inserito non è riconosciuto. Riprovare.");

                    Console.Write("Desideri filtrare nuovamente per titolo? (Y/N) ");
                    string sceltaFT = Console.ReadLine();
                    if (sceltaFT is not null && sceltaFT.ToUpper().Equals("N"))
                        continuaFilterT = false;
                }
            }




            #endregion

            #region Stampa per categoria

            Console.Write("Si desidera filtrare l'elenco delle pubblicazioni per categoria della pubblicazione? (Y/N) ");
            string scFC = Console.ReadLine();

            bool continuaFilterC = true;

            if (scFC is not null && scFC.ToUpper().Equals("Y"))
            {
                while (continuaFilterC)
                {
                    Console.Write("Inserisci una categoria per visualizzare tutte le pubblicazioni corrispondenti: ");
                    string cInputF = Console.ReadLine();
                    if (cInputF is not null)
                    {
                        Console.WriteLine("GIORNALI:");
                        for (int i = 0; i < giornali.Count(); i++)
                        {
                            if (giornali[i].Categoria.ToUpper().Equals(cInputF.ToUpper()))
                            {
                                Console.WriteLine(giornali[i].stampaDettaglio());
                            }
                        }

                        Console.WriteLine("RIVISTE:");
                        for (int i = 0; i < riviste.Count(); i++)
                        {
                            if (riviste[i].Categoria.ToUpper().Equals(cInputF.ToUpper()))
                            {
                                Console.WriteLine(riviste[i].stampaDettaglio());
                            }
                        }
                    }
                    else
                        Console.WriteLine("Il valore inserito non è riconosciuto. Riprovare.");

                    Console.Write("Desideri filtrare nuovamente per categoria? (Y/N) ");
                    string sceltaFC = Console.ReadLine();
                    if (sceltaFC is not null && sceltaFC.ToUpper().Equals("N"))
                        continuaFilterC = false;
                }
            }

            #endregion

            #region Stampa
            Console.WriteLine("Ecco a te la lista di tutte le pubblicazioni disponibili:");
            Console.WriteLine("");
            for (int i = 0; i < giornali.Count; i++)
            {
                Console.WriteLine(giornali[i].stampaDettaglio());
            }
            Console.WriteLine("");
            for (int i = 0; i < riviste.Count; i++)
            {
                Console.WriteLine(riviste[i].stampaDettaglio());
            }
            Console.WriteLine("");
            #endregion

            #region Salvataggio
            Console.Write("Si desidera esportare sul Desktop i dati inseriti sotto forma di CSV? (Y/N) ");
            string espCSV = Console.ReadLine();

            if(espCSV is not null && espCSV.ToUpper().Equals("Y"))
            {
                try
                {
                    string? appoggioCSV="";

                    for (int i=0; i<giornali.Count(); i++) 
                    {
                        appoggioCSV += giornali[i].esportaCsv();
                    }
                    for (int i = 0; i < riviste.Count(); i++)
                    {
                        appoggioCSV += riviste[i].esportaCsv();
                    }

                    using (StreamWriter sw = new StreamWriter("C:\\Users\\utente\\Desktop\\pubblicazioni.txt"))
                    {
                            sw.WriteLine(appoggioCSV);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            #endregion

        }
    }
}