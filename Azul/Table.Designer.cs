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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefreshFactories = new System.Windows.Forms.Button();
            this.btnRefreshCenter = new System.Windows.Forms.Button();
            this.lstCenter = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.rdoTypeF = new System.Windows.Forms.RadioButton();
            this.rdoTypeC = new System.Windows.Forms.RadioButton();
            this.lstModel = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.flpWall = new System.Windows.Forms.FlowLayoutPanel();
            this.flpModel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnRefreshTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTiles
            // 
            this.lstTiles.FormattingEnabled = true;
            this.lstTiles.Location = new System.Drawing.Point(231, 65);
            this.lstTiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstTiles.Name = "lstTiles";
            this.lstTiles.Size = new System.Drawing.Size(91, 69);
            this.lstTiles.TabIndex = 7;
            this.lstTiles.SelectedIndexChanged += new System.EventHandler(this.lstTiles_SelectedIndexChanged);
            // 
            // lstFactories
            // 
            this.lstFactories.FormattingEnabled = true;
            this.lstFactories.Location = new System.Drawing.Point(36, 65);
            this.lstFactories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstFactories.Name = "lstFactories";
            this.lstFactories.Size = new System.Drawing.Size(91, 69);
            this.lstFactories.TabIndex = 6;
            this.lstFactories.SelectedIndexChanged += new System.EventHandler(this.lstFactories_SelectedIndexChanged);
            // 
            // lblF1
            // 
            this.lblF1.AutoSize = true;
            this.lblF1.Location = new System.Drawing.Point(34, 46);
            this.lblF1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF1.Name = "lblF1";
            this.lblF1.Size = new System.Drawing.Size(47, 13);
            this.lblF1.TabIndex = 15;
            this.lblF1.Text = "Fábricas";
            // 
            // lblF2
            // 
            this.lblF2.AutoSize = true;
            this.lblF2.Location = new System.Drawing.Point(229, 46);
            this.lblF2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblF2.Name = "lblF2";
            this.lblF2.Size = new System.Drawing.Size(46, 13);
            this.lblF2.TabIndex = 16;
            this.lblF2.Text = "Azulejos";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(134, 150);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 37);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Centro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRefreshFactories
            // 
            this.btnRefreshFactories.Location = new System.Drawing.Point(36, 5);
            this.btnRefreshFactories.Name = "btnRefreshFactories";
            this.btnRefreshFactories.Size = new System.Drawing.Size(90, 37);
            this.btnRefreshFactories.TabIndex = 19;
            this.btnRefreshFactories.Text = "Atualizar";
            this.btnRefreshFactories.UseVisualStyleBackColor = true;
            this.btnRefreshFactories.Click += new System.EventHandler(this.btnRefreshFactories_Click);
            // 
            // btnRefreshCenter
            // 
            this.btnRefreshCenter.Location = new System.Drawing.Point(328, 5);
            this.btnRefreshCenter.Name = "btnRefreshCenter";
            this.btnRefreshCenter.Size = new System.Drawing.Size(90, 37);
            this.btnRefreshCenter.TabIndex = 20;
            this.btnRefreshCenter.Text = "Atualizar";
            this.btnRefreshCenter.UseVisualStyleBackColor = true;
            this.btnRefreshCenter.Click += new System.EventHandler(this.btnRefreshCenter_Click);
            // 
            // lstCenter
            // 
            this.lstCenter.FormattingEnabled = true;
            this.lstCenter.Location = new System.Drawing.Point(328, 65);
            this.lstCenter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCenter.Name = "lstCenter";
            this.lstCenter.Size = new System.Drawing.Size(91, 69);
            this.lstCenter.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Modelo";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(428, 150);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(90, 37);
            this.btnPlay.TabIndex = 27;
            this.btnPlay.Text = "Jogar";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // rdoTypeF
            // 
            this.rdoTypeF.AutoSize = true;
            this.rdoTypeF.Checked = true;
            this.rdoTypeF.Location = new System.Drawing.Point(239, 150);
            this.rdoTypeF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTypeF.Name = "rdoTypeF";
            this.rdoTypeF.Size = new System.Drawing.Size(60, 17);
            this.rdoTypeF.TabIndex = 28;
            this.rdoTypeF.TabStop = true;
            this.rdoTypeF.Text = "Fábrica";
            this.rdoTypeF.UseVisualStyleBackColor = true;
            // 
            // rdoTypeC
            // 
            this.rdoTypeC.AutoSize = true;
            this.rdoTypeC.Location = new System.Drawing.Point(330, 150);
            this.rdoTypeC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTypeC.Name = "rdoTypeC";
            this.rdoTypeC.Size = new System.Drawing.Size(56, 17);
            this.rdoTypeC.TabIndex = 29;
            this.rdoTypeC.Text = "Centro";
            this.rdoTypeC.UseVisualStyleBackColor = true;
            // 
            // lstModel
            // 
            this.lstModel.FormattingEnabled = true;
            this.lstModel.Location = new System.Drawing.Point(134, 65);
            this.lstModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstModel.Name = "lstModel";
            this.lstModel.Size = new System.Drawing.Size(91, 69);
            this.lstModel.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tabuleiro";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(428, 62);
            this.txtTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTable.Multiline = true;
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(91, 72);
            this.txtTable.TabIndex = 31;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(552, 65);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 13);
            this.lblPassword.TabIndex = 33;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(552, 46);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 34;
            // 
            // flpWall
            // 
            this.flpWall.Location = new System.Drawing.Point(341, 258);
            this.flpWall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpWall.Name = "flpWall";
            this.flpWall.Size = new System.Drawing.Size(211, 188);
            this.flpWall.TabIndex = 35;
            // 
            // flpModel
            // 
            this.flpModel.BackColor = System.Drawing.SystemColors.Control;
            this.flpModel.Location = new System.Drawing.Point(96, 258);
            this.flpModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpModel.Name = "flpModel";
            this.flpModel.Size = new System.Drawing.Size(211, 188);
            this.flpModel.TabIndex = 36;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(96, 483);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(456, 37);
            this.flowLayoutPanel2.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 226);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Pontuação:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(503, 226);
            this.lblScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(13, 13);
            this.lblScore.TabIndex = 46;
            this.lblScore.Text = "0";
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.Location = new System.Drawing.Point(36, 150);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(90, 37);
            this.btnRefreshTable.TabIndex = 47;
            this.btnRefreshTable.Text = "Atualizar";
            this.btnRefreshTable.UseVisualStyleBackColor = true;
            this.btnRefreshTable.Click += new System.EventHandler(this.btnRefreshTable_Click);
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 566);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flpModel);
            this.Controls.Add(this.flpWall);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdoTypeC);
            this.Controls.Add(this.rdoTypeF);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lstModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCenter);
            this.Controls.Add(this.btnRefreshCenter);
            this.Controls.Add(this.btnRefreshFactories);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblF2);
            this.Controls.Add(this.lblF1);
            this.Controls.Add(this.lstTiles);
            this.Controls.Add(this.lstFactories);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshFactories;
        private System.Windows.Forms.Button btnRefreshCenter;
        private System.Windows.Forms.ListBox lstCenter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rdoTypeF;
        private System.Windows.Forms.RadioButton rdoTypeC;
        private System.Windows.Forms.ListBox lstModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.FlowLayoutPanel flpWall;
        private System.Windows.Forms.FlowLayoutPanel flpModel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnRefreshTable;
    }
}