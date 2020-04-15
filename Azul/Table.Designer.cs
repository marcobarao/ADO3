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
            this.pnlModel15 = new System.Windows.Forms.Panel();
            this.pnlModel14 = new System.Windows.Forms.Panel();
            this.pnlModel13 = new System.Windows.Forms.Panel();
            this.pnlModel12 = new System.Windows.Forms.Panel();
            this.pnlModel11 = new System.Windows.Forms.Panel();
            this.pnlModel25 = new System.Windows.Forms.Panel();
            this.pnlModel24 = new System.Windows.Forms.Panel();
            this.pnlModel23 = new System.Windows.Forms.Panel();
            this.pnlModel22 = new System.Windows.Forms.Panel();
            this.pnlModel21 = new System.Windows.Forms.Panel();
            this.pnlModel35 = new System.Windows.Forms.Panel();
            this.pnlModel34 = new System.Windows.Forms.Panel();
            this.pnlModel33 = new System.Windows.Forms.Panel();
            this.pnlModel32 = new System.Windows.Forms.Panel();
            this.pnlModel31 = new System.Windows.Forms.Panel();
            this.pnlModel45 = new System.Windows.Forms.Panel();
            this.pnlModel44 = new System.Windows.Forms.Panel();
            this.pnlModel43 = new System.Windows.Forms.Panel();
            this.pnlModel42 = new System.Windows.Forms.Panel();
            this.pnlModel41 = new System.Windows.Forms.Panel();
            this.pnlModel55 = new System.Windows.Forms.Panel();
            this.pnlModel54 = new System.Windows.Forms.Panel();
            this.pnlModel53 = new System.Windows.Forms.Panel();
            this.pnlModel52 = new System.Windows.Forms.Panel();
            this.pnlModel51 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.flpModel.SuspendLayout();
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
            this.lstModel.SelectedIndexChanged += new System.EventHandler(this.lstModel_SelectedIndexChanged);
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
            this.flpWall.Location = new System.Drawing.Point(341, 262);
            this.flpWall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpWall.Name = "flpWall";
            this.flpWall.Size = new System.Drawing.Size(211, 188);
            this.flpWall.TabIndex = 35;
            // 
            // flpModel
            // 
            this.flpModel.BackColor = System.Drawing.SystemColors.Control;
            this.flpModel.Controls.Add(this.pnlModel15);
            this.flpModel.Controls.Add(this.pnlModel14);
            this.flpModel.Controls.Add(this.pnlModel13);
            this.flpModel.Controls.Add(this.pnlModel12);
            this.flpModel.Controls.Add(this.pnlModel11);
            this.flpModel.Controls.Add(this.pnlModel25);
            this.flpModel.Controls.Add(this.pnlModel24);
            this.flpModel.Controls.Add(this.pnlModel23);
            this.flpModel.Controls.Add(this.pnlModel22);
            this.flpModel.Controls.Add(this.pnlModel21);
            this.flpModel.Controls.Add(this.pnlModel35);
            this.flpModel.Controls.Add(this.pnlModel34);
            this.flpModel.Controls.Add(this.pnlModel33);
            this.flpModel.Controls.Add(this.pnlModel32);
            this.flpModel.Controls.Add(this.pnlModel31);
            this.flpModel.Controls.Add(this.pnlModel45);
            this.flpModel.Controls.Add(this.pnlModel44);
            this.flpModel.Controls.Add(this.pnlModel43);
            this.flpModel.Controls.Add(this.pnlModel42);
            this.flpModel.Controls.Add(this.pnlModel41);
            this.flpModel.Controls.Add(this.pnlModel55);
            this.flpModel.Controls.Add(this.pnlModel54);
            this.flpModel.Controls.Add(this.pnlModel53);
            this.flpModel.Controls.Add(this.pnlModel52);
            this.flpModel.Controls.Add(this.pnlModel51);
            this.flpModel.Location = new System.Drawing.Point(148, 258);
            this.flpModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpModel.Name = "flpModel";
            this.flpModel.Size = new System.Drawing.Size(177, 188);
            this.flpModel.TabIndex = 36;
            // 
            // pnlModel15
            // 
            this.pnlModel15.BackColor = System.Drawing.Color.Transparent;
            this.pnlModel15.ForeColor = System.Drawing.Color.Blue;
            this.pnlModel15.Location = new System.Drawing.Point(2, 2);
            this.pnlModel15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel15.Name = "pnlModel15";
            this.pnlModel15.Size = new System.Drawing.Size(30, 32);
            this.pnlModel15.TabIndex = 0;
            // 
            // pnlModel14
            // 
            this.pnlModel14.BackColor = System.Drawing.Color.Transparent;
            this.pnlModel14.ForeColor = System.Drawing.Color.Yellow;
            this.pnlModel14.Location = new System.Drawing.Point(36, 2);
            this.pnlModel14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel14.Name = "pnlModel14";
            this.pnlModel14.Size = new System.Drawing.Size(30, 32);
            this.pnlModel14.TabIndex = 1;
            // 
            // pnlModel13
            // 
            this.pnlModel13.BackColor = System.Drawing.Color.Transparent;
            this.pnlModel13.ForeColor = System.Drawing.Color.Red;
            this.pnlModel13.Location = new System.Drawing.Point(70, 2);
            this.pnlModel13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel13.Name = "pnlModel13";
            this.pnlModel13.Size = new System.Drawing.Size(30, 32);
            this.pnlModel13.TabIndex = 2;
            // 
            // pnlModel12
            // 
            this.pnlModel12.BackColor = System.Drawing.Color.Transparent;
            this.pnlModel12.ForeColor = System.Drawing.Color.Black;
            this.pnlModel12.Location = new System.Drawing.Point(104, 2);
            this.pnlModel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel12.Name = "pnlModel12";
            this.pnlModel12.Size = new System.Drawing.Size(30, 32);
            this.pnlModel12.TabIndex = 3;
            // 
            // pnlModel11
            // 
            this.pnlModel11.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel11.ForeColor = System.Drawing.Color.White;
            this.pnlModel11.Location = new System.Drawing.Point(138, 2);
            this.pnlModel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel11.Name = "pnlModel11";
            this.pnlModel11.Size = new System.Drawing.Size(31, 33);
            this.pnlModel11.TabIndex = 4;
            // 
            // pnlModel25
            // 
            this.pnlModel25.BackColor = System.Drawing.Color.Transparent;
            this.pnlModel25.ForeColor = System.Drawing.Color.White;
            this.pnlModel25.Location = new System.Drawing.Point(2, 39);
            this.pnlModel25.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel25.Name = "pnlModel25";
            this.pnlModel25.Size = new System.Drawing.Size(30, 32);
            this.pnlModel25.TabIndex = 5;
            // 
            // pnlModel24
            // 
            this.pnlModel24.BackColor = System.Drawing.Color.Transparent;
            this.pnlModel24.ForeColor = System.Drawing.Color.Blue;
            this.pnlModel24.Location = new System.Drawing.Point(36, 39);
            this.pnlModel24.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel24.Name = "pnlModel24";
            this.pnlModel24.Size = new System.Drawing.Size(30, 32);
            this.pnlModel24.TabIndex = 6;
            // 
            // pnlModel23
            // 
            this.pnlModel23.BackColor = System.Drawing.Color.Transparent;
            this.pnlModel23.ForeColor = System.Drawing.Color.Yellow;
            this.pnlModel23.Location = new System.Drawing.Point(70, 39);
            this.pnlModel23.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel23.Name = "pnlModel23";
            this.pnlModel23.Size = new System.Drawing.Size(30, 32);
            this.pnlModel23.TabIndex = 7;
            // 
            // pnlModel22
            // 
            this.pnlModel22.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel22.ForeColor = System.Drawing.Color.Red;
            this.pnlModel22.Location = new System.Drawing.Point(104, 39);
            this.pnlModel22.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel22.Name = "pnlModel22";
            this.pnlModel22.Size = new System.Drawing.Size(31, 33);
            this.pnlModel22.TabIndex = 8;
            // 
            // pnlModel21
            // 
            this.pnlModel21.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel21.ForeColor = System.Drawing.Color.Black;
            this.pnlModel21.Location = new System.Drawing.Point(139, 39);
            this.pnlModel21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel21.Name = "pnlModel21";
            this.pnlModel21.Size = new System.Drawing.Size(31, 33);
            this.pnlModel21.TabIndex = 9;
            // 
            // pnlModel35
            // 
            this.pnlModel35.BackColor = System.Drawing.Color.Transparent;
            this.pnlModel35.ForeColor = System.Drawing.Color.Black;
            this.pnlModel35.Location = new System.Drawing.Point(2, 76);
            this.pnlModel35.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel35.Name = "pnlModel35";
            this.pnlModel35.Size = new System.Drawing.Size(30, 32);
            this.pnlModel35.TabIndex = 10;
            // 
            // pnlModel34
            // 
            this.pnlModel34.BackColor = System.Drawing.Color.Transparent;
            this.pnlModel34.ForeColor = System.Drawing.Color.White;
            this.pnlModel34.Location = new System.Drawing.Point(36, 76);
            this.pnlModel34.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel34.Name = "pnlModel34";
            this.pnlModel34.Size = new System.Drawing.Size(30, 32);
            this.pnlModel34.TabIndex = 11;
            // 
            // pnlModel33
            // 
            this.pnlModel33.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel33.ForeColor = System.Drawing.Color.Blue;
            this.pnlModel33.Location = new System.Drawing.Point(70, 76);
            this.pnlModel33.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel33.Name = "pnlModel33";
            this.pnlModel33.Size = new System.Drawing.Size(31, 33);
            this.pnlModel33.TabIndex = 12;
            // 
            // pnlModel32
            // 
            this.pnlModel32.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel32.ForeColor = System.Drawing.Color.Yellow;
            this.pnlModel32.Location = new System.Drawing.Point(105, 76);
            this.pnlModel32.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel32.Name = "pnlModel32";
            this.pnlModel32.Size = new System.Drawing.Size(31, 33);
            this.pnlModel32.TabIndex = 13;
            // 
            // pnlModel31
            // 
            this.pnlModel31.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel31.ForeColor = System.Drawing.Color.Red;
            this.pnlModel31.Location = new System.Drawing.Point(140, 76);
            this.pnlModel31.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel31.Name = "pnlModel31";
            this.pnlModel31.Size = new System.Drawing.Size(31, 33);
            this.pnlModel31.TabIndex = 14;
            // 
            // pnlModel45
            // 
            this.pnlModel45.BackColor = System.Drawing.Color.Transparent;
            this.pnlModel45.ForeColor = System.Drawing.Color.Red;
            this.pnlModel45.Location = new System.Drawing.Point(2, 113);
            this.pnlModel45.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel45.Name = "pnlModel45";
            this.pnlModel45.Size = new System.Drawing.Size(30, 32);
            this.pnlModel45.TabIndex = 15;
            // 
            // pnlModel44
            // 
            this.pnlModel44.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel44.ForeColor = System.Drawing.Color.Black;
            this.pnlModel44.Location = new System.Drawing.Point(36, 113);
            this.pnlModel44.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel44.Name = "pnlModel44";
            this.pnlModel44.Size = new System.Drawing.Size(31, 33);
            this.pnlModel44.TabIndex = 16;
            // 
            // pnlModel43
            // 
            this.pnlModel43.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel43.ForeColor = System.Drawing.Color.White;
            this.pnlModel43.Location = new System.Drawing.Point(71, 113);
            this.pnlModel43.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel43.Name = "pnlModel43";
            this.pnlModel43.Size = new System.Drawing.Size(31, 33);
            this.pnlModel43.TabIndex = 17;
            // 
            // pnlModel42
            // 
            this.pnlModel42.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel42.ForeColor = System.Drawing.Color.Blue;
            this.pnlModel42.Location = new System.Drawing.Point(106, 113);
            this.pnlModel42.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel42.Name = "pnlModel42";
            this.pnlModel42.Size = new System.Drawing.Size(31, 33);
            this.pnlModel42.TabIndex = 18;
            // 
            // pnlModel41
            // 
            this.pnlModel41.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel41.ForeColor = System.Drawing.Color.Yellow;
            this.pnlModel41.Location = new System.Drawing.Point(141, 113);
            this.pnlModel41.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel41.Name = "pnlModel41";
            this.pnlModel41.Size = new System.Drawing.Size(31, 33);
            this.pnlModel41.TabIndex = 19;
            // 
            // pnlModel55
            // 
            this.pnlModel55.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel55.ForeColor = System.Drawing.Color.Yellow;
            this.pnlModel55.Location = new System.Drawing.Point(2, 150);
            this.pnlModel55.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel55.Name = "pnlModel55";
            this.pnlModel55.Size = new System.Drawing.Size(31, 33);
            this.pnlModel55.TabIndex = 20;
            // 
            // pnlModel54
            // 
            this.pnlModel54.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel54.ForeColor = System.Drawing.Color.Red;
            this.pnlModel54.Location = new System.Drawing.Point(37, 150);
            this.pnlModel54.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel54.Name = "pnlModel54";
            this.pnlModel54.Size = new System.Drawing.Size(31, 33);
            this.pnlModel54.TabIndex = 21;
            // 
            // pnlModel53
            // 
            this.pnlModel53.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel53.ForeColor = System.Drawing.Color.Black;
            this.pnlModel53.Location = new System.Drawing.Point(72, 150);
            this.pnlModel53.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel53.Name = "pnlModel53";
            this.pnlModel53.Size = new System.Drawing.Size(31, 33);
            this.pnlModel53.TabIndex = 22;
            // 
            // pnlModel52
            // 
            this.pnlModel52.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel52.ForeColor = System.Drawing.Color.White;
            this.pnlModel52.Location = new System.Drawing.Point(107, 150);
            this.pnlModel52.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel52.Name = "pnlModel52";
            this.pnlModel52.Size = new System.Drawing.Size(31, 33);
            this.pnlModel52.TabIndex = 23;
            // 
            // pnlModel51
            // 
            this.pnlModel51.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlModel51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlModel51.ForeColor = System.Drawing.Color.Blue;
            this.pnlModel51.Location = new System.Drawing.Point(142, 150);
            this.pnlModel51.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlModel51.Name = "pnlModel51";
            this.pnlModel51.Size = new System.Drawing.Size(31, 33);
            this.pnlModel51.TabIndex = 24;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(150, 483);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(368, 37);
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
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 537);
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
            this.flpModel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlModel15;
        private System.Windows.Forms.Panel pnlModel14;
        private System.Windows.Forms.Panel pnlModel13;
        private System.Windows.Forms.Panel pnlModel12;
        private System.Windows.Forms.Panel pnlModel11;
        private System.Windows.Forms.Panel pnlModel25;
        private System.Windows.Forms.Panel pnlModel24;
        private System.Windows.Forms.Panel pnlModel23;
        private System.Windows.Forms.Panel pnlModel22;
        private System.Windows.Forms.Panel pnlModel21;
        private System.Windows.Forms.Panel pnlModel35;
        private System.Windows.Forms.Panel pnlModel34;
        private System.Windows.Forms.Panel pnlModel33;
        private System.Windows.Forms.Panel pnlModel32;
        private System.Windows.Forms.Panel pnlModel31;
        private System.Windows.Forms.Panel pnlModel45;
        private System.Windows.Forms.Panel pnlModel44;
        private System.Windows.Forms.Panel pnlModel43;
        private System.Windows.Forms.Panel pnlModel42;
        private System.Windows.Forms.Panel pnlModel41;
        private System.Windows.Forms.Panel pnlModel55;
        private System.Windows.Forms.Panel pnlModel54;
        private System.Windows.Forms.Panel pnlModel53;
        private System.Windows.Forms.Panel pnlModel52;
        private System.Windows.Forms.Panel pnlModel51;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblScore;
    }
}