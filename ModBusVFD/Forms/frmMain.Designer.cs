
namespace ModBusV1
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip mnuMain;
            System.Windows.Forms.ToolStripMenuItem mnuFile;
            System.Windows.Forms.ToolStripSeparator mnuFile_1;
            System.Windows.Forms.ToolStripSeparator mnuFile_2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnuFileConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileDisConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.LblF = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.stsComPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsDataBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsParity = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsStopBits = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsState = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblSpeed = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.LblAmper = new System.Windows.Forms.Label();
            this.BtnInc = new System.Windows.Forms.Button();
            this.BtnDec = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BarSpeed = new System.Windows.Forms.TrackBar();
            mnuMain = new System.Windows.Forms.MenuStrip();
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuFile_1 = new System.Windows.Forms.ToolStripSeparator();
            mnuFile_2 = new System.Windows.Forms.ToolStripSeparator();
            mnuMain.SuspendLayout();
            this.stsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            mnuFile});
            mnuMain.Location = new System.Drawing.Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new System.Drawing.Size(965, 24);
            mnuMain.TabIndex = 2;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileConnect,
            this.mnuFileDisConnect,
            mnuFile_1,
            this.mnuFileSettings,
            mnuFile_2,
            this.mnuFileExit});
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(37, 20);
            mnuFile.Text = "File";
            // 
            // mnuFileConnect
            // 
            this.mnuFileConnect.Name = "mnuFileConnect";
            this.mnuFileConnect.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.mnuFileConnect.Size = new System.Drawing.Size(209, 22);
            this.mnuFileConnect.Text = "Connect";
            this.mnuFileConnect.Click += new System.EventHandler(this.MnuFileConnect_Click);
            // 
            // mnuFileDisConnect
            // 
            this.mnuFileDisConnect.Enabled = false;
            this.mnuFileDisConnect.Name = "mnuFileDisConnect";
            this.mnuFileDisConnect.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.mnuFileDisConnect.Size = new System.Drawing.Size(209, 22);
            this.mnuFileDisConnect.Text = "DisConnect";
            this.mnuFileDisConnect.Click += new System.EventHandler(this.MnuFileDisConnect_Click);
            // 
            // mnuFile_1
            // 
            mnuFile_1.Name = "mnuFile_1";
            mnuFile_1.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuFileSettings
            // 
            this.mnuFileSettings.Name = "mnuFileSettings";
            this.mnuFileSettings.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuFileSettings.Size = new System.Drawing.Size(209, 22);
            this.mnuFileSettings.Text = "Settings";
            this.mnuFileSettings.Click += new System.EventHandler(this.MnuFileSettings_Click);
            // 
            // mnuFile_2
            // 
            mnuFile_2.Name = "mnuFile_2";
            mnuFile_2.Size = new System.Drawing.Size(206, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(209, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.MnuFileExit_Click);
            // 
            // LblF
            // 
            this.LblF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LblF.Font = new System.Drawing.Font("DS-Digital", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblF.ForeColor = System.Drawing.Color.Red;
            this.LblF.Location = new System.Drawing.Point(9, 298);
            this.LblF.Margin = new System.Windows.Forms.Padding(0);
            this.LblF.Name = "LblF";
            this.LblF.Size = new System.Drawing.Size(77, 132);
            this.LblF.TabIndex = 14;
            this.LblF.Text = "F";
            this.LblF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblF.Visible = false;
            // 
            // LblA
            // 
            this.LblA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LblA.Font = new System.Drawing.Font("DS-Digital", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblA.Location = new System.Drawing.Point(555, 330);
            this.LblA.Margin = new System.Windows.Forms.Padding(0);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(79, 100);
            this.LblA.TabIndex = 15;
            this.LblA.Text = "A";
            this.LblA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblA.Visible = false;
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsComPort,
            this.stsBaudRate,
            this.stsDataBits,
            this.stsParity,
            this.stsStopBits,
            this.stsState});
            this.stsMain.Location = new System.Drawing.Point(0, 534);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(965, 22);
            this.stsMain.TabIndex = 3;
            this.stsMain.Text = "statusStrip1";
            // 
            // stsComPort
            // 
            this.stsComPort.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsComPort.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsComPort.Name = "stsComPort";
            this.stsComPort.Size = new System.Drawing.Size(4, 17);
            this.stsComPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsBaudRate
            // 
            this.stsBaudRate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsBaudRate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsBaudRate.Name = "stsBaudRate";
            this.stsBaudRate.Size = new System.Drawing.Size(4, 17);
            this.stsBaudRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsDataBits
            // 
            this.stsDataBits.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsDataBits.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsDataBits.Name = "stsDataBits";
            this.stsDataBits.Size = new System.Drawing.Size(4, 17);
            this.stsDataBits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsParity
            // 
            this.stsParity.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsParity.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsParity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stsParity.Name = "stsParity";
            this.stsParity.Size = new System.Drawing.Size(4, 17);
            // 
            // stsStopBits
            // 
            this.stsStopBits.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsStopBits.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsStopBits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stsStopBits.Name = "stsStopBits";
            this.stsStopBits.Size = new System.Drawing.Size(4, 17);
            // 
            // stsState
            // 
            this.stsState.AutoSize = false;
            this.stsState.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stsState.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stsState.ForeColor = System.Drawing.Color.DarkRed;
            this.stsState.Name = "stsState";
            this.stsState.Size = new System.Drawing.Size(930, 17);
            this.stsState.Spring = true;
            this.stsState.Text = "Disconnected";
            this.stsState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSpeed
            // 
            this.LblSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LblSpeed.Font = new System.Drawing.Font("DS-Digital", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSpeed.ForeColor = System.Drawing.Color.Red;
            this.LblSpeed.Location = new System.Drawing.Point(86, 298);
            this.LblSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.LblSpeed.Name = "LblSpeed";
            this.LblSpeed.Size = new System.Drawing.Size(284, 132);
            this.LblSpeed.TabIndex = 4;
            this.LblSpeed.Text = "16.5";
            this.LblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblSpeed.Visible = false;
            // 
            // tmr
            // 
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // LblAmper
            // 
            this.LblAmper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LblAmper.Font = new System.Drawing.Font("DS-Digital", 80.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblAmper.Location = new System.Drawing.Point(399, 330);
            this.LblAmper.Margin = new System.Windows.Forms.Padding(0);
            this.LblAmper.Name = "LblAmper";
            this.LblAmper.Size = new System.Drawing.Size(156, 100);
            this.LblAmper.TabIndex = 8;
            this.LblAmper.Text = "1.5";
            this.LblAmper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblAmper.Visible = false;
            // 
            // BtnInc
            // 
            this.BtnInc.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInc.Location = new System.Drawing.Point(274, 152);
            this.BtnInc.Margin = new System.Windows.Forms.Padding(0);
            this.BtnInc.Name = "BtnInc";
            this.BtnInc.Size = new System.Drawing.Size(96, 89);
            this.BtnInc.TabIndex = 9;
            this.BtnInc.Text = "+";
            this.BtnInc.UseVisualStyleBackColor = true;
            this.BtnInc.Visible = false;
            this.BtnInc.Click += new System.EventHandler(this.BtnInc_Click);
            // 
            // BtnDec
            // 
            this.BtnDec.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDec.Location = new System.Drawing.Point(12, 154);
            this.BtnDec.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDec.Name = "BtnDec";
            this.BtnDec.Size = new System.Drawing.Size(91, 89);
            this.BtnDec.TabIndex = 10;
            this.BtnDec.Text = "-";
            this.BtnDec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDec.UseVisualStyleBackColor = true;
            this.BtnDec.Visible = false;
            this.BtnDec.Click += new System.EventHandler(this.BtnDec_Click);
            // 
            // Pic
            // 
            this.Pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic.Image = ((System.Drawing.Image)(resources.GetObject("Pic.Image")));
            this.Pic.Location = new System.Drawing.Point(0, 27);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(965, 504);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 13;
            this.Pic.TabStop = false;
            // 
            // BtnStop
            // 
            this.BtnStop.Font = new System.Drawing.Font("Tahoma", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.ForeColor = System.Drawing.Color.Maroon;
            this.BtnStop.Location = new System.Drawing.Point(661, 100);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(215, 89);
            this.BtnStop.TabIndex = 16;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Visible = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("Tahoma", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnRight.Location = new System.Drawing.Point(661, 202);
            this.BtnRight.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(215, 89);
            this.BtnRight.TabIndex = 17;
            this.BtnRight.Text = "Right";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Visible = false;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("Tahoma", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.ForeColor = System.Drawing.Color.Navy;
            this.BtnLeft.Location = new System.Drawing.Point(661, 303);
            this.BtnLeft.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(215, 89);
            this.BtnLeft.TabIndex = 18;
            this.BtnLeft.Text = "Left";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Visible = false;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BarSpeed
            // 
            this.BarSpeed.LargeChange = 10;
            this.BarSpeed.Location = new System.Drawing.Point(12, 246);
            this.BarSpeed.Maximum = 5000;
            this.BarSpeed.Name = "BarSpeed";
            this.BarSpeed.Size = new System.Drawing.Size(358, 45);
            this.BarSpeed.TabIndex = 19;
            this.BarSpeed.TickFrequency = 10;
            this.BarSpeed.Visible = false;
            this.BarSpeed.Scroll += new System.EventHandler(this.BarSpeed_Scroll);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 556);
            this.Controls.Add(this.BarSpeed);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.LblF);
            this.Controls.Add(this.BtnDec);
            this.Controls.Add(this.BtnInc);
            this.Controls.Add(this.LblAmper);
            this.Controls.Add(this.LblSpeed);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(mnuMain);
            this.Controls.Add(this.Pic);
            this.MainMenuStrip = mnuMain;
            this.Name = "FrmMain";
            this.Text = "Modbus Comunication";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuFileConnect;
        private System.Windows.Forms.ToolStripMenuItem mnuFileDisConnect;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.ToolStripStatusLabel stsComPort;
        private System.Windows.Forms.ToolStripStatusLabel stsBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel stsDataBits;
        private System.Windows.Forms.ToolStripStatusLabel stsParity;
        private System.Windows.Forms.ToolStripStatusLabel stsStopBits;
        private System.Windows.Forms.ToolStripStatusLabel stsState;
        private System.Windows.Forms.Label LblSpeed;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Label LblAmper;
        private System.Windows.Forms.Button BtnInc;
        private System.Windows.Forms.Button BtnDec;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Label LblF;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.TrackBar BarSpeed;
    }
}

