namespace Azul
{
    partial class Azul
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Azul));
            this.lstGames = new System.Windows.Forms.ListBox();
            this.btnFetch = new System.Windows.Forms.Button();
            this.pctSenac = new System.Windows.Forms.PictureBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.btnCreateMatch = new System.Windows.Forms.Button();
            this.txtMatchName = new System.Windows.Forms.TextBox();
            this.txtPasswordCreate = new System.Windows.Forms.TextBox();
            this.lblPasswordC = new System.Windows.Forms.Label();
            this.lblMatchNameC = new System.Windows.Forms.Label();
            this.lblPasswordJoin = new System.Windows.Forms.Label();
            this.txtPasswordJoin = new System.Windows.Forms.TextBox();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.lblPlayerList = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctSenac)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGames
            // 
            this.lstGames.FormattingEnabled = true;
            this.lstGames.ItemHeight = 16;
            this.lstGames.Location = new System.Drawing.Point(60, 226);
            this.lstGames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(312, 100);
            this.lstGames.TabIndex = 0;
            this.lstGames.SelectedIndexChanged += new System.EventHandler(this.lstGames_SelectedIndexChanged);
            this.lstGames.SelectedValueChanged += new System.EventHandler(this.lstGames_SelectedValueChanged);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(56, 191);
            this.btnFetch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(316, 31);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Listar partidas abertas";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // pctSenac
            // 
            this.pctSenac.Image = ((System.Drawing.Image)(resources.GetObject("pctSenac.Image")));
            this.pctSenac.Location = new System.Drawing.Point(60, 14);
            this.pctSenac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctSenac.Name = "pctSenac";
            this.pctSenac.Size = new System.Drawing.Size(313, 133);
            this.pctSenac.TabIndex = 2;
            this.pctSenac.TabStop = false;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(61, 571);
            this.btnEntrarPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(313, 37);
            this.btnEntrarPartida.TabIndex = 19;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(61, 496);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(311, 22);
            this.txtNomeJogador.TabIndex = 18;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(61, 475);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(121, 17);
            this.lblNomeJogador.TabIndex = 17;
            this.lblNomeJogador.Text = "Nome do Jogador";
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.Location = new System.Drawing.Point(228, 418);
            this.btnCreateMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(143, 23);
            this.btnCreateMatch.TabIndex = 16;
            this.btnCreateMatch.Text = "Criar Partida";
            this.btnCreateMatch.UseVisualStyleBackColor = true;
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);
            // 
            // txtMatchName
            // 
            this.txtMatchName.Location = new System.Drawing.Point(60, 374);
            this.txtMatchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatchName.Name = "txtMatchName";
            this.txtMatchName.Size = new System.Drawing.Size(311, 22);
            this.txtMatchName.TabIndex = 15;
            // 
            // txtPasswordCreate
            // 
            this.txtPasswordCreate.Location = new System.Drawing.Point(60, 418);
            this.txtPasswordCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordCreate.Name = "txtPasswordCreate";
            this.txtPasswordCreate.Size = new System.Drawing.Size(161, 22);
            this.txtPasswordCreate.TabIndex = 14;
            // 
            // lblPasswordC
            // 
            this.lblPasswordC.AutoSize = true;
            this.lblPasswordC.Location = new System.Drawing.Point(60, 399);
            this.lblPasswordC.Name = "lblPasswordC";
            this.lblPasswordC.Size = new System.Drawing.Size(49, 17);
            this.lblPasswordC.TabIndex = 13;
            this.lblPasswordC.Text = "Senha";
            // 
            // lblMatchNameC
            // 
            this.lblMatchNameC.AutoSize = true;
            this.lblMatchNameC.Location = new System.Drawing.Point(60, 354);
            this.lblMatchNameC.Name = "lblMatchNameC";
            this.lblMatchNameC.Size = new System.Drawing.Size(114, 17);
            this.lblMatchNameC.TabIndex = 12;
            this.lblMatchNameC.Text = "Nome da Partida";
            // 
            // lblPasswordJoin
            // 
            this.lblPasswordJoin.AutoSize = true;
            this.lblPasswordJoin.Location = new System.Drawing.Point(61, 523);
            this.lblPasswordJoin.Name = "lblPasswordJoin";
            this.lblPasswordJoin.Size = new System.Drawing.Size(53, 17);
            this.lblPasswordJoin.TabIndex = 20;
            this.lblPasswordJoin.Text = "Senha:";
            // 
            // txtPasswordJoin
            // 
            this.txtPasswordJoin.Location = new System.Drawing.Point(61, 542);
            this.txtPasswordJoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordJoin.Name = "txtPasswordJoin";
            this.txtPasswordJoin.Size = new System.Drawing.Size(311, 22);
            this.txtPasswordJoin.TabIndex = 21;
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 16;
            this.lstPlayers.Location = new System.Drawing.Point(405, 33);
            this.lstPlayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(308, 68);
            this.lstPlayers.TabIndex = 22;
            // 
            // lblPlayerList
            // 
            this.lblPlayerList.AutoSize = true;
            this.lblPlayerList.Location = new System.Drawing.Point(401, 14);
            this.lblPlayerList.Name = "lblPlayerList";
            this.lblPlayerList.Size = new System.Drawing.Size(143, 17);
            this.lblPlayerList.TabIndex = 23;
            this.lblPlayerList.Text = "Jogadores na partida";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(404, 116);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(308, 31);
            this.btnStartGame.TabIndex = 24;
            this.btnStartGame.Text = "Iniciar Partida";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // Azul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 612);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblPlayerList);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.txtPasswordJoin);
            this.Controls.Add(this.lblPasswordJoin);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.btnCreateMatch);
            this.Controls.Add(this.txtMatchName);
            this.Controls.Add(this.txtPasswordCreate);
            this.Controls.Add(this.lblPasswordC);
            this.Controls.Add(this.lblMatchNameC);
            this.Controls.Add(this.pctSenac);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.lstGames);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(746, 659);
            this.MinimumSize = new System.Drawing.Size(746, 659);
            this.Name = "Azul";
            this.Text = "Azul";
            this.Load += new System.EventHandler(this.Azul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctSenac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.PictureBox pctSenac;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Button btnCreateMatch;
        private System.Windows.Forms.TextBox txtMatchName;
        private System.Windows.Forms.TextBox txtPasswordCreate;
        private System.Windows.Forms.Label lblPasswordC;
        private System.Windows.Forms.Label lblMatchNameC;
        private System.Windows.Forms.Label lblPasswordJoin;
        private System.Windows.Forms.TextBox txtPasswordJoin;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Label lblPlayerList;
        private System.Windows.Forms.Button btnStartGame;
    }
}

