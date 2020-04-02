namespace Azul
{
    partial class Table
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstTiles = new System.Windows.Forms.ListBox();
            this.lstFactories = new System.Windows.Forms.ListBox();
            this.lblF1 = new System.Windows.Forms.Label();
            this.lblF2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCenter = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstTiles
            // 
            this.lstTiles.FormattingEnabled = true;
            this.lstTiles.ItemHeight = 16;
            this.lstTiles.Location = new System.Drawing.Point(179, 61);
            this.lstTiles.Name = "lstTiles";
            this.lstTiles.Size = new System.Drawing.Size(120, 84);
            this.lstTiles.TabIndex = 7;
            // 
            // lstFactories
            // 
            this.lstFactories.FormattingEnabled = true;
            this.lstFactories.ItemHeight = 16;
            this.lstFactories.Location = new System.Drawing.Point(44, 61);
            this.lstFactories.Name = "lstFactories";
            this.lstFactories.Size = new System.Drawing.Size(120, 84);
            this.lstFactories.TabIndex = 6;
            this.lstFactories.SelectedIndexChanged += new System.EventHandler(this.lstFactories_SelectedIndexChanged);
            // 
            // lblF1
            // 
            this.lblF1.AutoSize = true;
            this.lblF1.Location = new System.Drawing.Point(44, 38);
            this.lblF1.Name = "lblF1";
            this.lblF1.Size = new System.Drawing.Size(62, 17);
            this.lblF1.TabIndex = 15;
            this.lblF1.Text = "Fábricas";
            // 
            // lblF2
            // 
            this.lblF2.AutoSize = true;
            this.lblF2.Location = new System.Drawing.Point(176, 38);
            this.lblF2.Name = "lblF2";
            this.lblF2.Size = new System.Drawing.Size(61, 17);
            this.lblF2.TabIndex = 16;
            this.lblF2.Text = "Azulejos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Centro";
            // 
            // lstCenter
            // 
            this.lstCenter.FormattingEnabled = true;
            this.lstCenter.ItemHeight = 16;
            this.lstCenter.Location = new System.Drawing.Point(316, 61);
            this.lstCenter.Name = "lstCenter";
            this.lstCenter.Size = new System.Drawing.Size(120, 84);
            this.lstCenter.TabIndex = 17;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCenter);
            this.Controls.Add(this.lblF2);
            this.Controls.Add(this.lblF1);
            this.Controls.Add(this.lstTiles);
            this.Controls.Add(this.lstFactories);
            this.Name = "Table";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.Table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstTiles;
        private System.Windows.Forms.ListBox lstFactories;
        private System.Windows.Forms.Label lblF1;
        private System.Windows.Forms.Label lblF2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCenter;
    }
}