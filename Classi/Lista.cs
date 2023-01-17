namespace Gestione_Calciatori.Classi
{
    class Lista
    {
        Giocatore testa;
        bool found = false;

        public Lista()
        {
            testa = new("", "", 0, 0, null);
            testa.Next = null;
        }

        #region Funzioni

        public void Inserimento(Giocatore giocatore1)
        {
            Giocatore p1;
            Giocatore inserito = giocatore1;

            p1 = testa;
            found = false;
            do
            {
                if (p1 == null)
                {
                    p1 = inserito;
                    found = true;
                    testa = p1;
                }
                else if (p1.Next == null)
                {
                    p1.Next = inserito;
                    found = true;
                }
                else if (p1.Next != null)
                {
                    p1 = p1.Next;
                }
            }
            while (!found);
        }

        public void Aggiornamento(Giocatore giocatore1)
        {
            Giocatore p1;

            p1 = testa;
            found = false;
            do
            {
                if (p1.Nome == giocatore1.Nome)
                {
                    p1.Squadra = giocatore1.Squadra;
                    p1.Partite = giocatore1.Partite;
                    p1.Goal = giocatore1.Goal;
                    found = true;
                }
                else if (p1.Nome != giocatore1.Nome)
                {
                    p1 = p1.Next;
                    found = false;
                }
            }
            while (!found);

        }

        public bool Rimozione(string giocatore1)
        {
            Giocatore p1, p2;
            bool esito = false;

            p1 = testa;
            p2 = p1;
            found = false;

            do
            {
                if (p1.Next == null)
                {
                    esito = false;
                    found = true;
                }
                else
                {
                    if (p1.Next.Nome == giocatore1)
                    {
                        p2 = p1.Next.Next;
                        p1.Next = p2;
                        found = true;
                        esito = true;
                    }
                    else if (p1.Next.Nome != giocatore1)
                    {
                        p2 = p1;
                        p1 = p1.Next;
                        found = false;
                    }
                }
            }
            while (!found);

            return esito;
        }
        public List<Giocatore> ListaCompleta()
        {
            List<Giocatore> listacompleta = new();
            bool end = false;
            Giocatore p1;

            p1 = testa;

            do
            {
                if (p1.Nome == "")
                {
                    p1 = p1.Next;
                }
                else
                {
                    if (p1.Next == null)
                    {
                        end = true;
                        listacompleta.Add(p1);
                    }
                    else
                    {
                        end = false;
                        listacompleta.Add(p1);
                        p1 = p1.Next;
                    }
                }
            }
            while (!end);

            return listacompleta;
        }
        #endregion

        #region Altro

        public string[] Ricerca(string giocatoreScelto)
        {
            Giocatore p1;

            string[] datiTotali = new string[3];

            p1 = testa;

            found = false;

            if (p1.Next != null)
            {
                do
                {
                    if (p1.Nome == giocatoreScelto)
                    {
                        found = true;
                        datiTotali[0] = p1.Squadra;
                        datiTotali[1] = Convert.ToString(p1.Partite);
                        datiTotali[2] = Convert.ToString(p1.Goal);

                    }
                    else if (p1.Nome != giocatoreScelto)
                    {
                        p1 = p1.Next;
                        found = false;
                    }
                }
                while (!found);
            }

            return datiTotali;
        }

        public List<Giocatore> RicercaSquadra(string nomesquadra)
        {
            List<Giocatore> squadra = new();
            Giocatore p1;

            p1 = testa;
            found = false;
            if (p1.Next != null)
            {
                do
                {
                    if (p1.Squadra == nomesquadra)
                    {
                        if (p1.Next == null)
                        {
                            found = true;
                            squadra.Add(p1);
                        }
                        else
                        {
                            found = false;
                            squadra.Add(p1);
                            p1 = p1.Next;
                        }
                    }
                    else if (p1.Squadra != nomesquadra)
                    {
                        if (p1.Next == null)
                        {
                            found = true;
                        }
                        else
                        {
                            p1 = p1.Next;
                            found = false;
                        }

                    }
                }
                while (!found);
            }

            return squadra;
        }

        #endregion
    }
}