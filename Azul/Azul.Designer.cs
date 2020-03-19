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
            ((System.ComponentModel.ISupportInitialize)(this.pctSenac)).BeginInit();
            this.SuspendLayout();
            // 
            // lstGames
            // 
            this.lstGames.FormattingEnabled = true;
            this.lstGames.Location = new System.Drawing.Point(45, 184);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(235, 82);
            this.lstGames.TabIndex = 0;
            this.lstGames.SelectedIndexChanged += new System.EventHandler(this.lstGames_SelectedIndexChanged);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(42, 155);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(237, 25);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Listar partidas abertas";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // pctSenac
            // 
            this.pctSenac.Image = ((System.Drawing.Image)(resources.GetObject("pctSenac.Image")));
            this.pctSenac.Location = new System.Drawing.Point(45, 11);
            this.pctSenac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctSenac.Name = "pctSenac";
            this.pctSenac.Size = new System.Drawing.Size(235, 108);
            this.pctSenac.TabIndex = 2;
            this.pctSenac.TabStop = false;
            this.pctSenac.Click += new System.EventHandler(this.pctSenac_Click);
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(46, 464);
            this.btnEntrarPartida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(235, 30);
            this.btnEntrarPartida.TabIndex = 19;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(46, 403);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(234, 20);
            this.txtNomeJogador.TabIndex = 18;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(46, 386);
            this.lblNomeJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(91, 13);
            this.lblNomeJogador.TabIndex = 17;
            this.lblNomeJogador.Text = "Nome do Jogador";
            this.lblNomeJogador.Click += new System.EventHandler(this.lblNomeJogador_Click);
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.Location = new System.Drawing.Point(171, 340);
            this.btnCreateMatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(107, 19);
            this.btnCreateMatch.TabIndex = 16;
            this.btnCreateMatch.Text = "Criar Partida";
            this.btnCreateMatch.UseVisualStyleBackColor = true;
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);
            // 
            // txtMatchName
            // 
            this.txtMatchName.Location = new System.Drawing.Point(45, 304);
            this.txtMatchName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatchName.Name = "txtMatchName";
            this.txtMatchName.Size = new System.Drawing.Size(234, 20);
            this.txtMatchName.TabIndex = 15;
            // 
            // txtPasswordCreate
            // 
            this.txtPasswordCreate.Location = new System.Drawing.Point(45, 340);
            this.txtPasswordCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPasswordCreate.Name = "txtPasswordCreate";
            this.txtPasswordCreate.Size = new System.Drawing.Size(122, 20);
            this.txtPasswordCreate.TabIndex = 14;
            // 
            // lblPasswordC
            // 
            this.lblPasswordC.AutoSize = true;
            this.lblPasswordC.Location = new System.Drawing.Point(45, 324);
            this.lblPasswordC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordC.Name = "lblPasswordC";
            this.lblPasswordC.Size = new System.Drawing.Size(38, 13);
            this.lblPasswordC.TabIndex = 13;
            this.lblPasswordC.Text = "Senha";
            // 
            // lblMatchNameC
            // 
            this.lblMatchNameC.AutoSize = true;
            this.lblMatchNameC.Location = new System.Drawing.Point(45, 288);
            this.lblMatchNameC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatchNameC.Name = "lblMatchNameC";
            this.lblMatchNameC.Size = new System.Drawing.Size(86, 13);
            this.lblMatchNameC.TabIndex = 12;
            this.lblMatchNameC.Text = "Nome da Partida";
            // 
            // lblPasswordJoin
            // 
            this.lblPasswordJoin.AutoSize = true;
            this.lblPasswordJoin.Location = new System.Drawing.Point(46, 425);
            this.lblPasswordJoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordJoin.Name = "lblPasswordJoin";
            this.lblPasswordJoin.Size = new System.Drawing.Size(41, 13);
            this.lblPasswordJoin.TabIndex = 20;
            this.lblPasswordJoin.Text = "Senha:";
            this.lblPasswordJoin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPasswordJoin
            // 
            this.txtPasswordJoin.Location = new System.Drawing.Point(46, 440);
            this.txtPasswordJoin.Margin = new System.Windows.Forms.Padding(2);
            this.txtPasswordJoin.Name = "txtPasswordJoin";
            this.txtPasswordJoin.Size = new System.Drawing.Size(234, 20);
            this.txtPasswordJoin.TabIndex = 21;
            // 
            // Azul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 505);
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
            this.Name = "Azul";
            this.Text = "Azul";
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
    }
}

