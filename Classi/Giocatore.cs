namespace Gestione_Calciatori.Classi
{
    class Giocatore
    {
        public Giocatore(string nome1, string squadra1, int partite1, int goal1, Giocatore next1)
        {
            Nome = nome1;
            Squadra = squadra1;
            Partite = partite1;
            Goal = goal1;
            Next = next1;
        }
        public string Nome { get; set; }
        public string Squadra { get; set; }
        public int Goal { get; set; }
        public int Partite { get; set; }
        public Giocatore Next { get; set; }
    }
}
