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
            this.lstGames = new System.Windows.Forms.ListBox();
            this.btnFetch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGames
            // 
            this.lstGames.FormattingEnabled = true;
            this.lstGames.Location = new System.Drawing.Point(118, 58);
            this.lstGames.Name = "lstGames";
            this.lstGames.Size = new System.Drawing.Size(177, 186);
            this.lstGames.TabIndex = 0;
            this.lstGames.SelectedIndexChanged += new System.EventHandler(this.lstGames_SelectedIndexChanged);
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(38, 58);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(74, 37);
            this.btnFetch.TabIndex = 1;
            this.btnFetch.Text = "Atualizar";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // Azul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 631);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.lstGames);
            this.Name = "Azul";
            this.Text = "Azul";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.Button btnFetch;
    }
}

