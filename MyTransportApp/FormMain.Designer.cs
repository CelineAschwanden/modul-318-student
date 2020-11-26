namespace MyTransportApp
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonMap = new System.Windows.Forms.Button();
            this.buttonSearchPage = new System.Windows.Forms.Button();
            this.labelStart = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.radioButtonAn = new System.Windows.Forms.RadioButton();
            this.radioButtonAb = new System.Windows.Forms.RadioButton();
            this.labelAn = new System.Windows.Forms.Label();
            this.labelAb = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDatum = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxBis = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxVon = new System.Windows.Forms.TextBox();
            this.buttonBackSearch = new System.Windows.Forms.PictureBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panelConnections = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelConnections = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelMain.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBackSearch)).BeginInit();
            this.panelConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMain.Controls.Add(this.buttonMap);
            this.panelMain.Controls.Add(this.buttonSearchPage);
            this.panelMain.Controls.Add(this.labelStart);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(492, 625);
            this.panelMain.TabIndex = 0;
            // 
            // buttonMap
            // 
            this.buttonMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(181)))));
            this.buttonMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMap.Location = new System.Drawing.Point(27, 249);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(434, 68);
            this.buttonMap.TabIndex = 5;
            this.buttonMap.Text = "Karte";
            this.buttonMap.UseVisualStyleBackColor = false;
            this.buttonMap.Click += new System.EventHandler(this.toMap);
            // 
            // buttonSearchPage
            // 
            this.buttonSearchPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(181)))));
            this.buttonSearchPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchPage.Location = new System.Drawing.Point(26, 157);
            this.buttonSearchPage.Name = "buttonSearchPage";
            this.buttonSearchPage.Size = new System.Drawing.Size(434, 68);
            this.buttonSearchPage.TabIndex = 4;
            this.buttonSearchPage.Text = "Verbindung suchen";
            this.buttonSearchPage.UseVisualStyleBackColor = false;
            this.buttonSearchPage.Click += new System.EventHandler(this.toSearch);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(147, 73);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(182, 39);
            this.labelStart.TabIndex = 3;
            this.labelStart.Text = "Start Menü";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.radioButtonAn);
            this.panelSearch.Controls.Add(this.radioButtonAb);
            this.panelSearch.Controls.Add(this.labelAn);
            this.panelSearch.Controls.Add(this.labelAb);
            this.panelSearch.Controls.Add(this.labelTime);
            this.panelSearch.Controls.Add(this.timePicker);
            this.panelSearch.Controls.Add(this.labelDatum);
            this.panelSearch.Controls.Add(this.datePicker);
            this.panelSearch.Controls.Add(this.labelTo);
            this.panelSearch.Controls.Add(this.textBoxBis);
            this.panelSearch.Controls.Add(this.labelFrom);
            this.panelSearch.Controls.Add(this.textBoxVon);
            this.panelSearch.Controls.Add(this.buttonBackSearch);
            this.panelSearch.Controls.Add(this.labelSearch);
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(492, 625);
            this.panelSearch.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(181)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(27, 515);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(237, 52);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Suchen";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.toConnections);
            // 
            // radioButtonAn
            // 
            this.radioButtonAn.AutoSize = true;
            this.radioButtonAn.Location = new System.Drawing.Point(386, 451);
            this.radioButtonAn.Name = "radioButtonAn";
            this.radioButtonAn.Size = new System.Drawing.Size(17, 16);
            this.radioButtonAn.TabIndex = 17;
            this.radioButtonAn.TabStop = true;
            this.radioButtonAn.UseVisualStyleBackColor = true;
            // 
            // radioButtonAb
            // 
            this.radioButtonAb.AutoSize = true;
            this.radioButtonAb.Location = new System.Drawing.Point(279, 451);
            this.radioButtonAb.Name = "radioButtonAb";
            this.radioButtonAb.Size = new System.Drawing.Size(17, 16);
            this.radioButtonAb.TabIndex = 16;
            this.radioButtonAb.TabStop = true;
            this.radioButtonAb.UseVisualStyleBackColor = true;
            // 
            // labelAn
            // 
            this.labelAn.AutoSize = true;
            this.labelAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAn.Location = new System.Drawing.Point(341, 443);
            this.labelAn.Name = "labelAn";
            this.labelAn.Size = new System.Drawing.Size(41, 29);
            this.labelAn.TabIndex = 15;
            this.labelAn.Text = "An";
            // 
            // labelAb
            // 
            this.labelAb.AutoSize = true;
            this.labelAb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAb.Location = new System.Drawing.Point(234, 443);
            this.labelAb.Name = "labelAb";
            this.labelAb.Size = new System.Drawing.Size(42, 29);
            this.labelAb.TabIndex = 14;
            this.labelAb.Text = "Ab";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(22, 408);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(62, 29);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "Zeit:";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(27, 440);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(157, 36);
            this.timePicker.TabIndex = 12;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.Location = new System.Drawing.Point(22, 312);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(95, 29);
            this.labelDatum.TabIndex = 11;
            this.labelDatum.Text = "Datum:";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(26, 344);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(434, 36);
            this.datePicker.TabIndex = 10;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(21, 217);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(56, 29);
            this.labelTo.TabIndex = 9;
            this.labelTo.Text = "Bis:";
            // 
            // textBoxBis
            // 
            this.textBoxBis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBis.Location = new System.Drawing.Point(25, 249);
            this.textBoxBis.Name = "textBoxBis";
            this.textBoxBis.Size = new System.Drawing.Size(435, 38);
            this.textBoxBis.TabIndex = 8;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(22, 125);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(65, 29);
            this.labelFrom.TabIndex = 7;
            this.labelFrom.Text = "Von:";
            // 
            // textBoxVon
            // 
            this.textBoxVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVon.Location = new System.Drawing.Point(26, 157);
            this.textBoxVon.Name = "textBoxVon";
            this.textBoxVon.Size = new System.Drawing.Size(435, 38);
            this.textBoxVon.TabIndex = 6;
            // 
            // buttonBackSearch
            // 
            this.buttonBackSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonBackSearch.Image")));
            this.buttonBackSearch.Location = new System.Drawing.Point(10, 10);
            this.buttonBackSearch.Name = "buttonBackSearch";
            this.buttonBackSearch.Size = new System.Drawing.Size(66, 50);
            this.buttonBackSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonBackSearch.TabIndex = 5;
            this.buttonBackSearch.TabStop = false;
            this.buttonBackSearch.Click += new System.EventHandler(this.toMain);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(84, 59);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(311, 39);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Verbindung suchen";
            // 
            // panelConnections
            // 
            this.panelConnections.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelConnections.Controls.Add(this.listBox1);
            this.panelConnections.Controls.Add(this.pictureBox1);
            this.panelConnections.Controls.Add(this.labelConnections);
            this.panelConnections.Location = new System.Drawing.Point(0, 0);
            this.panelConnections.Name = "panelConnections";
            this.panelConnections.Size = new System.Drawing.Size(492, 625);
            this.panelConnections.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.toSearch);
            // 
            // labelConnections
            // 
            this.labelConnections.AutoSize = true;
            this.labelConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnections.Location = new System.Drawing.Point(127, 59);
            this.labelConnections.Name = "labelConnections";
            this.labelConnections.Size = new System.Drawing.Size(230, 39);
            this.labelConnections.TabIndex = 5;
            this.labelConnections.Text = "Verbindungen";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(25, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(444, 439);
            this.listBox1.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 627);
            this.Controls.Add(this.panelConnections);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelMain);
            this.Name = "FormMain";
            this.Text = "Transport App";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBackSearch)).EndInit();
            this.panelConnections.ResumeLayout(false);
            this.panelConnections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.Button buttonSearchPage;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.PictureBox buttonBackSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxBis;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox textBoxVon;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label labelAn;
        private System.Windows.Forms.Label labelAb;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.RadioButton radioButtonAn;
        private System.Windows.Forms.RadioButton radioButtonAb;
        private System.Windows.Forms.Panel panelConnections;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelConnections;
        private System.Windows.Forms.ListBox listBox1;
    }
}

