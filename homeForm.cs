using Gestione_Calciatori.Classi;

namespace Gestione_Calciatori
{
    public partial class homeForm : Form
    {
        Lista lista1 = new();
        bool endedInit = false;

        public homeForm()
        {
            InitializeComponent();
        }

        private void homeForm_Load(object sender, EventArgs e)
        {
            #region Proprietà Form

            Size = new(668, 88);
            listaPanel.Visible = false;
            datiPanel.Visible = false;
            altroPanel.Visible = false;

            #endregion
        }

        #region Bottoni

        private void caricaButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelected = new()
            {
                Title = "Seleziona un file",
                Filter = "File di Testo (*.txt)|*.txt",
                Multiselect = false,
            };

            if (fileSelected.ShowDialog() == DialogResult.OK)
            {
                #region Lettura Dati

                string[] lines = File.ReadAllLines(fileSelected.FileName);

                foreach (string nomiGiocatori in lines)
                {
                    Giocatore giocatore1 = new(nomiGiocatori, "", 0, 0, null);

                    lista1.Inserimento(giocatore1);
                }

                giocatoriListBox.DataSource = lista1.ListaCompleta();
                giocatoriListBox.DisplayMember = "Nome";
                giocatoriListBox.ValueMember = "Nome";
                endedInit = true;

                #endregion

                #region Proprietà Form

                Size = new(668, 683);

                listaPanel.Visible = true;
                datiPanel.Visible = true;
                altroPanel.Visible = true;

                #endregion
            }
        }

        private void aggiornaButton_Click(object sender, EventArgs e)
        {
            bool check1 = true,
                check2 = true,
                check3 = true;

            if (giocatoriListBox.SelectedIndex != -1)
            {
                if (squadraTextBox.Texts == "")
                {
                    squadraTextBox.BackColor = Color.FromArgb(255, 159, 67);
                    check1 = false;
                }
                if (!int.TryParse(partiteTextBox.Texts, out _))
                {
                    partiteTextBox.BackColor = Color.FromArgb(255, 159, 67);
                    check2 = false;
                }
                if (!int.TryParse(goalTextBox.Texts, out _))
                {
                    goalTextBox.BackColor = Color.FromArgb(255, 159, 67);
                    check3 = false;
                }

                if (check1 && check2 && check3)
                {
                    Giocatore giocatore1 = new(
                        giocatoriListBox.SelectedValue.ToString(),
                        squadraTextBox.Texts,
                        Convert.ToInt32(partiteTextBox.Texts),
                        Convert.ToInt32(goalTextBox.Texts),
                        null);
                    lista1.Aggiornamento(giocatore1);
                }
            }
        }

        private void ripristinaButton_Click(object sender, EventArgs e)
        {
            squadraTextBox.Texts = "";
            partiteTextBox.Texts = "";
            goalTextBox.Texts = "";

            if (giocatoriListBox.SelectedIndex != -1)
            {
                Giocatore giocatore1 = new(
                    giocatoriListBox.SelectedValue.ToString(),
                    squadraTextBox.Texts,
                    0,
                    0,
                    null);

                lista1.Aggiornamento(giocatore1);
            }
        }

        private void cercagoalButton_Click(object sender, EventArgs e)
        {
            string[] risultati = lista1.Ricerca(cercagoalTextBox.Texts);

            MessageBox.Show("Ecco i risultati della ricerca: \n\n" +
                "Numero di goal segnati da " + cercagoalTextBox.Texts + ":\n\n" + risultati[2],
                "Informazione",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void cercasquadraButton_Click(object sender, EventArgs e)
        {
            string messaggioText = "";
            List<Giocatore> risultati = lista1.RicercaSquadra(cercasquadraTextBox.Texts);

            for (int i = 0; i < risultati.Count; i++)
            {
                messaggioText += "\n" + risultati[i].Nome;
            }

            MessageBox.Show("Ecco i risultati della ricerca: \n\n" +
                "Componenti della squadra " + cercasquadraTextBox.Texts + ":\n" + messaggioText,
                "Informazione",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            cercasquadraTextBox.Texts = "";
        }

        private void giocatoreinforButton_Click(object sender, EventArgs e)
        {
            bool esito = lista1.Rimozione(giocatoreinforTextBox.Texts);
            if (esito == false)
            {
                MessageBox.Show("L'operazione non è andata a buon fine:\n" +
                    "Il giocatore non è stato trovato",
                                "Avviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (esito == true)
            {
                MessageBox.Show("L'operazione è andata a buon fine:\n" +
                    "Il giocatore è stato rimosso",
                                "Informazione",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                giocatoriListBox.DataSource = lista1.ListaCompleta();
                giocatoriListBox.DisplayMember = "Nome";
                giocatoriListBox.ValueMember = "Nome";
                giocatoreinforTextBox.Texts = "";
            }
        }

        #endregion

        #region ListBox

        private void giocatoriListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (endedInit)
            {
                string[] risultati = lista1.Ricerca(giocatoriListBox.SelectedValue.ToString());

                if (risultati[0] != "")
                {
                    squadraTextBox.Texts = risultati[0];
                    partiteTextBox.Texts = risultati[1];
                    goalTextBox.Texts = risultati[2];
                }
                else
                {
                    squadraTextBox.Texts = "";
                    partiteTextBox.Texts = "";
                    goalTextBox.Texts = "";
                }

                squadraTextBox.BackColor = Color.FromArgb(38, 110, 181);
                partiteTextBox.BackColor = Color.FromArgb(38, 110, 181);
                goalTextBox.BackColor = Color.FromArgb(38, 110, 181);
            }
        }

        #endregion

        #region TextBox

        private void squadraTextBox__TextChanged(object sender, EventArgs e)
        {
            squadraTextBox.BackColor = Color.FromArgb(38, 110, 181);

            if (squadraTextBox.Texts.Length <= 0 || giocatoriListBox.SelectedIndex == -1)
            {
                ripristinaButton.BackColor = Color.FromArgb(224, 150, 150);
                ripristinaButton.Enabled = false;
                aggiornaButton.BackColor = Color.FromArgb(114, 171, 157);
                aggiornaButton.Enabled = false;
            }
            else
            {
                ripristinaButton.BackColor = Color.FromArgb(238, 82, 83);
                ripristinaButton.Enabled = true;
                aggiornaButton.BackColor = Color.FromArgb(16, 172, 132);
                aggiornaButton.Enabled = true;
            }
        }

        private void partiteTextBox__TextChanged(object sender, EventArgs e)
        {
            partiteTextBox.BackColor = Color.FromArgb(38, 110, 181);

            if (partiteTextBox.Texts.Length <= 0 || giocatoriListBox.SelectedIndex == -1)
            {
                ripristinaButton.BackColor = Color.FromArgb(224, 150, 150);
                ripristinaButton.Enabled = false;
                aggiornaButton.BackColor = Color.FromArgb(114, 171, 157);
                aggiornaButton.Enabled = false;
            }
            else
            {
                ripristinaButton.BackColor = Color.FromArgb(238, 82, 83);
                ripristinaButton.Enabled = true;
                aggiornaButton.BackColor = Color.FromArgb(16, 172, 132);
                aggiornaButton.Enabled = true;
            }
        }

        private void goalTextBox__TextChanged(object sender, EventArgs e)
        {
            goalTextBox.BackColor = Color.FromArgb(38, 110, 181);

            if (goalTextBox.Texts.Length <= 0 || giocatoriListBox.SelectedIndex == -1)
            {
                ripristinaButton.BackColor = Color.FromArgb(224, 150, 150);
                ripristinaButton.Enabled = false;
                aggiornaButton.BackColor = Color.FromArgb(114, 171, 157);
                aggiornaButton.Enabled = false;
            }
            else
            {
                ripristinaButton.BackColor = Color.FromArgb(238, 82, 83);
                ripristinaButton.Enabled = true;
                aggiornaButton.BackColor = Color.FromArgb(16, 172, 132);
                aggiornaButton.Enabled = true;
            }
        }

        private void cercagoalTextBox__TextChanged(object sender, EventArgs e)
        {
            if (cercagoalTextBox.Texts.Length <= 0)
            {
                cercagoalButton.BackColor = Color.FromArgb(91, 136, 181);
                cercagoalButton.Enabled = false;
            }
            else
            {
                cercagoalButton.BackColor = Color.FromArgb(38, 110, 181);
                cercagoalButton.Enabled = true;
            }
        }

        private void cercasquadraTextBox__TextChanged(object sender, EventArgs e)
        {
            if (cercasquadraTextBox.Texts.Length <= 0)
            {
                cercasquadraButton.BackColor = Color.FromArgb(91, 136, 181);
                cercasquadraButton.Enabled = false;
            }
            else
            {
                cercasquadraButton.BackColor = Color.FromArgb(38, 110, 181);
                cercasquadraButton.Enabled = true;
            }
        }

        private void giocatoreinforTextBox__TextChanged(object sender, EventArgs e)
        {
            if (giocatoreinforTextBox.Texts.Length <= 0)
            {
                giocatoreinforButton.BackColor = Color.FromArgb(91, 136, 181);
                giocatoreinforButton.Enabled = false;
            }
            else
            {
                giocatoreinforButton.BackColor = Color.FromArgb(38, 110, 181);
                giocatoreinforButton.Enabled = true;
            }
        }

        #endregion

    }
}