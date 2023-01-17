namespace Gestione_Calciatori
{
    partial class homeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listaPanel = new Gestione_Calciatori.RoundedPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.giocatoriListBox = new System.Windows.Forms.ListBox();
            this.caricaButton = new CustomControls.RJControls.RJButton();
            this.datiPanel = new Gestione_Calciatori.RoundedPanel();
            this.aggiornaButton = new CustomControls.RJControls.RJButton();
            this.ripristinaButton = new CustomControls.RJControls.RJButton();
            this.partiteTextBox = new CustomControls.RJControls.RJTextBox();
            this.goalTextBox = new CustomControls.RJControls.RJTextBox();
            this.squadraTextBox = new CustomControls.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.altroPanel = new Gestione_Calciatori.RoundedPanel();
            this.giocatoreinforButton = new CustomControls.RJControls.RJButton();
            this.cercasquadraButton = new CustomControls.RJControls.RJButton();
            this.cercagoalButton = new CustomControls.RJControls.RJButton();
            this.giocatoreinforTextBox = new CustomControls.RJControls.RJTextBox();
            this.cercasquadraTextBox = new CustomControls.RJControls.RJTextBox();
            this.cercagoalTextBox = new CustomControls.RJControls.RJTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.listaPanel.SuspendLayout();
            this.datiPanel.SuspendLayout();
            this.altroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestione Calciatori";
            // 
            // listaPanel
            // 
            this.listaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.listaPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.listaPanel.Controls.Add(this.label6);
            this.listaPanel.Controls.Add(this.giocatoriListBox);
            this.listaPanel.Edge = 20;
            this.listaPanel.Location = new System.Drawing.Point(12, 51);
            this.listaPanel.Name = "listaPanel";
            this.listaPanel.Size = new System.Drawing.Size(308, 334);
            this.listaPanel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "Elenco";
            // 
            // giocatoriListBox
            // 
            this.giocatoriListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.giocatoriListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.giocatoriListBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.giocatoriListBox.ForeColor = System.Drawing.Color.White;
            this.giocatoriListBox.FormattingEnabled = true;
            this.giocatoriListBox.ItemHeight = 22;
            this.giocatoriListBox.Location = new System.Drawing.Point(25, 50);
            this.giocatoriListBox.Name = "giocatoriListBox";
            this.giocatoriListBox.Size = new System.Drawing.Size(260, 264);
            this.giocatoriListBox.TabIndex = 0;
            this.giocatoriListBox.SelectedIndexChanged += new System.EventHandler(this.giocatoriListBox_SelectedIndexChanged);
            // 
            // caricaButton
            // 
            this.caricaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.caricaButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.caricaButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.caricaButton.BorderRadius = 10;
            this.caricaButton.BorderSize = 2;
            this.caricaButton.FlatAppearance.BorderSize = 0;
            this.caricaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caricaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caricaButton.ForeColor = System.Drawing.Color.White;
            this.caricaButton.Location = new System.Drawing.Point(465, 8);
            this.caricaButton.Name = "caricaButton";
            this.caricaButton.Size = new System.Drawing.Size(175, 32);
            this.caricaButton.TabIndex = 2;
            this.caricaButton.Text = "Carica Giocatori";
            this.caricaButton.TextColor = System.Drawing.Color.White;
            this.caricaButton.UseVisualStyleBackColor = false;
            this.caricaButton.Click += new System.EventHandler(this.caricaButton_Click);
            // 
            // datiPanel
            // 
            this.datiPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.datiPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.datiPanel.Controls.Add(this.aggiornaButton);
            this.datiPanel.Controls.Add(this.ripristinaButton);
            this.datiPanel.Controls.Add(this.partiteTextBox);
            this.datiPanel.Controls.Add(this.goalTextBox);
            this.datiPanel.Controls.Add(this.squadraTextBox);
            this.datiPanel.Controls.Add(this.label5);
            this.datiPanel.Controls.Add(this.label4);
            this.datiPanel.Controls.Add(this.label3);
            this.datiPanel.Controls.Add(this.label7);
            this.datiPanel.Edge = 20;
            this.datiPanel.Location = new System.Drawing.Point(332, 51);
            this.datiPanel.Name = "datiPanel";
            this.datiPanel.Size = new System.Drawing.Size(308, 334);
            this.datiPanel.TabIndex = 3;
            this.datiPanel.Visible = false;
            // 
            // aggiornaButton
            // 
            this.aggiornaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(171)))), ((int)(((byte)(157)))));
            this.aggiornaButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(171)))), ((int)(((byte)(157)))));
            this.aggiornaButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(112)))), ((int)(((byte)(87)))));
            this.aggiornaButton.BorderRadius = 10;
            this.aggiornaButton.BorderSize = 2;
            this.aggiornaButton.Enabled = false;
            this.aggiornaButton.FlatAppearance.BorderSize = 0;
            this.aggiornaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aggiornaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aggiornaButton.ForeColor = System.Drawing.Color.White;
            this.aggiornaButton.Location = new System.Drawing.Point(156, 276);
            this.aggiornaButton.Name = "aggiornaButton";
            this.aggiornaButton.Size = new System.Drawing.Size(125, 38);
            this.aggiornaButton.TabIndex = 12;
            this.aggiornaButton.Text = "Aggiorna";
            this.aggiornaButton.TextColor = System.Drawing.Color.White;
            this.aggiornaButton.UseVisualStyleBackColor = false;
            this.aggiornaButton.Click += new System.EventHandler(this.aggiornaButton_Click);
            // 
            // ripristinaButton
            // 
            this.ripristinaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ripristinaButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ripristinaButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ripristinaButton.BorderRadius = 10;
            this.ripristinaButton.BorderSize = 2;
            this.ripristinaButton.Enabled = false;
            this.ripristinaButton.FlatAppearance.BorderSize = 0;
            this.ripristinaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ripristinaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ripristinaButton.ForeColor = System.Drawing.Color.White;
            this.ripristinaButton.Location = new System.Drawing.Point(25, 276);
            this.ripristinaButton.Name = "ripristinaButton";
            this.ripristinaButton.Size = new System.Drawing.Size(125, 38);
            this.ripristinaButton.TabIndex = 7;
            this.ripristinaButton.Text = "Ripristina";
            this.ripristinaButton.TextColor = System.Drawing.Color.White;
            this.ripristinaButton.UseVisualStyleBackColor = false;
            this.ripristinaButton.Click += new System.EventHandler(this.ripristinaButton_Click);
            // 
            // partiteTextBox
            // 
            this.partiteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.partiteTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.partiteTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.partiteTextBox.BorderRadius = 10;
            this.partiteTextBox.BorderSize = 2;
            this.partiteTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partiteTextBox.ForeColor = System.Drawing.Color.White;
            this.partiteTextBox.Location = new System.Drawing.Point(25, 145);
            this.partiteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.partiteTextBox.Multiline = false;
            this.partiteTextBox.Name = "partiteTextBox";
            this.partiteTextBox.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.partiteTextBox.PasswordChar = false;
            this.partiteTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.partiteTextBox.PlaceholderText = "";
            this.partiteTextBox.Size = new System.Drawing.Size(260, 38);
            this.partiteTextBox.TabIndex = 10;
            this.partiteTextBox.Texts = "";
            this.partiteTextBox.UnderlinedStyle = false;
            this.partiteTextBox._TextChanged += new System.EventHandler(this.partiteTextBox__TextChanged);
            // 
            // goalTextBox
            // 
            this.goalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.goalTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.goalTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.goalTextBox.BorderRadius = 10;
            this.goalTextBox.BorderSize = 2;
            this.goalTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goalTextBox.ForeColor = System.Drawing.Color.White;
            this.goalTextBox.Location = new System.Drawing.Point(25, 219);
            this.goalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.goalTextBox.Multiline = false;
            this.goalTextBox.Name = "goalTextBox";
            this.goalTextBox.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.goalTextBox.PasswordChar = false;
            this.goalTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.goalTextBox.PlaceholderText = "";
            this.goalTextBox.Size = new System.Drawing.Size(260, 38);
            this.goalTextBox.TabIndex = 11;
            this.goalTextBox.Texts = "";
            this.goalTextBox.UnderlinedStyle = false;
            this.goalTextBox._TextChanged += new System.EventHandler(this.goalTextBox__TextChanged);
            // 
            // squadraTextBox
            // 
            this.squadraTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.squadraTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.squadraTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.squadraTextBox.BorderRadius = 10;
            this.squadraTextBox.BorderSize = 2;
            this.squadraTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.squadraTextBox.ForeColor = System.Drawing.Color.White;
            this.squadraTextBox.Location = new System.Drawing.Point(25, 74);
            this.squadraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.squadraTextBox.Multiline = false;
            this.squadraTextBox.Name = "squadraTextBox";
            this.squadraTextBox.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.squadraTextBox.PasswordChar = false;
            this.squadraTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.squadraTextBox.PlaceholderText = "";
            this.squadraTextBox.Size = new System.Drawing.Size(260, 38);
            this.squadraTextBox.TabIndex = 9;
            this.squadraTextBox.Texts = "";
            this.squadraTextBox.UnderlinedStyle = false;
            this.squadraTextBox._TextChanged += new System.EventHandler(this.squadraTextBox__TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(128, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Goal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(121, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Partite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Squadra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dati e statistiche";
            // 
            // altroPanel
            // 
            this.altroPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.altroPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.altroPanel.Controls.Add(this.giocatoreinforButton);
            this.altroPanel.Controls.Add(this.cercasquadraButton);
            this.altroPanel.Controls.Add(this.cercagoalButton);
            this.altroPanel.Controls.Add(this.giocatoreinforTextBox);
            this.altroPanel.Controls.Add(this.cercasquadraTextBox);
            this.altroPanel.Controls.Add(this.cercagoalTextBox);
            this.altroPanel.Controls.Add(this.label10);
            this.altroPanel.Controls.Add(this.label9);
            this.altroPanel.Controls.Add(this.label8);
            this.altroPanel.Controls.Add(this.rjButton2);
            this.altroPanel.Controls.Add(this.rjButton1);
            this.altroPanel.Controls.Add(this.label2);
            this.altroPanel.Edge = 20;
            this.altroPanel.Location = new System.Drawing.Point(12, 396);
            this.altroPanel.Name = "altroPanel";
            this.altroPanel.Size = new System.Drawing.Size(628, 237);
            this.altroPanel.TabIndex = 6;
            // 
            // giocatoreinforButton
            // 
            this.giocatoreinforButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(181)))));
            this.giocatoreinforButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(181)))));
            this.giocatoreinforButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.giocatoreinforButton.BorderRadius = 10;
            this.giocatoreinforButton.BorderSize = 2;
            this.giocatoreinforButton.Enabled = false;
            this.giocatoreinforButton.FlatAppearance.BorderSize = 0;
            this.giocatoreinforButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giocatoreinforButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.giocatoreinforButton.ForeColor = System.Drawing.Color.White;
            this.giocatoreinforButton.Location = new System.Drawing.Point(346, 174);
            this.giocatoreinforButton.Name = "giocatoreinforButton";
            this.giocatoreinforButton.Size = new System.Drawing.Size(69, 38);
            this.giocatoreinforButton.TabIndex = 16;
            this.giocatoreinforButton.Text = "Invia";
            this.giocatoreinforButton.TextColor = System.Drawing.Color.White;
            this.giocatoreinforButton.UseVisualStyleBackColor = false;
            this.giocatoreinforButton.Click += new System.EventHandler(this.giocatoreinforButton_Click);
            // 
            // cercasquadraButton
            // 
            this.cercasquadraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(181)))));
            this.cercasquadraButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(181)))));
            this.cercasquadraButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cercasquadraButton.BorderRadius = 10;
            this.cercasquadraButton.BorderSize = 2;
            this.cercasquadraButton.Enabled = false;
            this.cercasquadraButton.FlatAppearance.BorderSize = 0;
            this.cercasquadraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cercasquadraButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cercasquadraButton.ForeColor = System.Drawing.Color.White;
            this.cercasquadraButton.Location = new System.Drawing.Point(346, 110);
            this.cercasquadraButton.Name = "cercasquadraButton";
            this.cercasquadraButton.Size = new System.Drawing.Size(69, 38);
            this.cercasquadraButton.TabIndex = 15;
            this.cercasquadraButton.Text = "Cerca";
            this.cercasquadraButton.TextColor = System.Drawing.Color.White;
            this.cercasquadraButton.UseVisualStyleBackColor = false;
            this.cercasquadraButton.Click += new System.EventHandler(this.cercasquadraButton_Click);
            // 
            // cercagoalButton
            // 
            this.cercagoalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(181)))));
            this.cercagoalButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(181)))));
            this.cercagoalButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cercagoalButton.BorderRadius = 10;
            this.cercagoalButton.BorderSize = 2;
            this.cercagoalButton.Enabled = false;
            this.cercagoalButton.FlatAppearance.BorderSize = 0;
            this.cercagoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cercagoalButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cercagoalButton.ForeColor = System.Drawing.Color.White;
            this.cercagoalButton.Location = new System.Drawing.Point(346, 46);
            this.cercagoalButton.Name = "cercagoalButton";
            this.cercagoalButton.Size = new System.Drawing.Size(69, 38);
            this.cercagoalButton.TabIndex = 13;
            this.cercagoalButton.Text = "Cerca";
            this.cercagoalButton.TextColor = System.Drawing.Color.White;
            this.cercagoalButton.UseVisualStyleBackColor = false;
            this.cercagoalButton.Click += new System.EventHandler(this.cercagoalButton_Click);
            // 
            // giocatoreinforTextBox
            // 
            this.giocatoreinforTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.giocatoreinforTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.giocatoreinforTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.giocatoreinforTextBox.BorderRadius = 10;
            this.giocatoreinforTextBox.BorderSize = 2;
            this.giocatoreinforTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.giocatoreinforTextBox.ForeColor = System.Drawing.Color.White;
            this.giocatoreinforTextBox.Location = new System.Drawing.Point(148, 174);
            this.giocatoreinforTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.giocatoreinforTextBox.Multiline = false;
            this.giocatoreinforTextBox.Name = "giocatoreinforTextBox";
            this.giocatoreinforTextBox.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.giocatoreinforTextBox.PasswordChar = false;
            this.giocatoreinforTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.giocatoreinforTextBox.PlaceholderText = "";
            this.giocatoreinforTextBox.Size = new System.Drawing.Size(195, 38);
            this.giocatoreinforTextBox.TabIndex = 14;
            this.giocatoreinforTextBox.Texts = "";
            this.giocatoreinforTextBox.UnderlinedStyle = false;
            this.giocatoreinforTextBox._TextChanged += new System.EventHandler(this.giocatoreinforTextBox__TextChanged);
            // 
            // cercasquadraTextBox
            // 
            this.cercasquadraTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.cercasquadraTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cercasquadraTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.cercasquadraTextBox.BorderRadius = 10;
            this.cercasquadraTextBox.BorderSize = 2;
            this.cercasquadraTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cercasquadraTextBox.ForeColor = System.Drawing.Color.White;
            this.cercasquadraTextBox.Location = new System.Drawing.Point(148, 110);
            this.cercasquadraTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cercasquadraTextBox.Multiline = false;
            this.cercasquadraTextBox.Name = "cercasquadraTextBox";
            this.cercasquadraTextBox.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.cercasquadraTextBox.PasswordChar = false;
            this.cercasquadraTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cercasquadraTextBox.PlaceholderText = "";
            this.cercasquadraTextBox.Size = new System.Drawing.Size(195, 38);
            this.cercasquadraTextBox.TabIndex = 13;
            this.cercasquadraTextBox.Texts = "";
            this.cercasquadraTextBox.UnderlinedStyle = false;
            this.cercasquadraTextBox._TextChanged += new System.EventHandler(this.cercasquadraTextBox__TextChanged);
            // 
            // cercagoalTextBox
            // 
            this.cercagoalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.cercagoalTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.cercagoalTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.cercagoalTextBox.BorderRadius = 10;
            this.cercagoalTextBox.BorderSize = 2;
            this.cercagoalTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cercagoalTextBox.ForeColor = System.Drawing.Color.White;
            this.cercagoalTextBox.Location = new System.Drawing.Point(148, 46);
            this.cercagoalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cercagoalTextBox.Multiline = false;
            this.cercagoalTextBox.Name = "cercagoalTextBox";
            this.cercagoalTextBox.Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            this.cercagoalTextBox.PasswordChar = false;
            this.cercagoalTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cercagoalTextBox.PlaceholderText = "";
            this.cercagoalTextBox.Size = new System.Drawing.Size(195, 38);
            this.cercagoalTextBox.TabIndex = 12;
            this.cercagoalTextBox.Texts = "";
            this.cercagoalTextBox.UnderlinedStyle = false;
            this.cercagoalTextBox._TextChanged += new System.EventHandler(this.cercagoalTextBox__TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 44);
            this.label10.TabIndex = 10;
            this.label10.Text = "Giocatore\r\ninfortunato";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(39, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 44);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ricerca\r\nsquadra";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 44);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ricerca goal\r\nper giocatore";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(431, 132);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(170, 80);
            this.rjButton2.TabIndex = 7;
            this.rjButton2.Text = "Giocatori con 0 goal";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(431, 46);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(170, 80);
            this.rjButton1.TabIndex = 6;
            this.rjButton1.Text = "Media partite giocate";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Altro";
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(652, 644);
            this.Controls.Add(this.altroPanel);
            this.Controls.Add(this.datiPanel);
            this.Controls.Add(this.caricaButton);
            this.Controls.Add(this.listaPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.homeForm_Load);
            this.listaPanel.ResumeLayout(false);
            this.listaPanel.PerformLayout();
            this.datiPanel.ResumeLayout(false);
            this.datiPanel.PerformLayout();
            this.altroPanel.ResumeLayout(false);
            this.altroPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RoundedPanel listaPanel;
        private CustomControls.RJControls.RJButton caricaButton;
        private ListBox giocatoriListBox;
        private Label label6;
        private RoundedPanel datiPanel;
        private Label label7;
        private CustomControls.RJControls.RJTextBox squadraTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private RoundedPanel altroPanel;
        private Label label2;
        private CustomControls.RJControls.RJButton aggiornaButton;
        private CustomControls.RJControls.RJButton ripristinaButton;
        private CustomControls.RJControls.RJTextBox partiteTextBox;
        private CustomControls.RJControls.RJTextBox goalTextBox;
        private CustomControls.RJControls.RJTextBox giocatoreinforTextBox;
        private CustomControls.RJControls.RJTextBox cercasquadraTextBox;
        private CustomControls.RJControls.RJTextBox cercagoalTextBox;
        private Label label10;
        private Label label9;
        private Label label8;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton giocatoreinforButton;
        private CustomControls.RJControls.RJButton cercasquadraButton;
        private CustomControls.RJControls.RJButton cercagoalButton;
    }
}