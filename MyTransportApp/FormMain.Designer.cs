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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tableConnections = new System.Windows.Forms.DataGridView();
            this.labelFromTo = new System.Windows.Forms.Label();
            this.Zeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMain.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBackSearch)).BeginInit();
            this.panelConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMain.Controls.Add(this.buttonMap);
            this.panelMain.Controls.Add(this.buttonSearchPage);
            this.panelMain.Controls.Add(this.labelStart);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(565, 637);
            this.panelMain.TabIndex = 0;
            // 
            // buttonMap
            // 
            this.buttonMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(181)))));
            this.buttonMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMap.Location = new System.Drawing.Point(27, 255);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(507, 68);
            this.buttonMap.TabIndex = 5;
            this.buttonMap.Text = "Karte";
            this.buttonMap.UseVisualStyleBackColor = false;
            this.buttonMap.Click += new System.EventHandler(this.toMap);
            // 
            // buttonSearchPage
            // 
            this.buttonSearchPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(181)))));
            this.buttonSearchPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchPage.Location = new System.Drawing.Point(26, 163);
            this.buttonSearchPage.Name = "buttonSearchPage";
            this.buttonSearchPage.Size = new System.Drawing.Size(507, 68);
            this.buttonSearchPage.TabIndex = 4;
            this.buttonSearchPage.Text = "Verbindung suchen";
            this.buttonSearchPage.UseVisualStyleBackColor = false;
            this.buttonSearchPage.Click += new System.EventHandler(this.toSearch);
            // 
            // labelStart
            // 
            this.labelStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(25, 79);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(508, 39);
            this.labelStart.TabIndex = 3;
            this.labelStart.Text = "Start Menü";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(565, 637);
            this.panelSearch.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(156)))), ((int)(((byte)(181)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(27, 521);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(237, 52);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Suchen";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.toConnections);
            // 
            // radioButtonAn
            // 
            this.radioButtonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAn.AutoSize = true;
            this.radioButtonAn.Location = new System.Drawing.Point(386, 457);
            this.radioButtonAn.Name = "radioButtonAn";
            this.radioButtonAn.Size = new System.Drawing.Size(17, 16);
            this.radioButtonAn.TabIndex = 17;
            this.radioButtonAn.TabStop = true;
            this.radioButtonAn.UseVisualStyleBackColor = true;
            // 
            // radioButtonAb
            // 
            this.radioButtonAb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAb.AutoSize = true;
            this.radioButtonAb.Location = new System.Drawing.Point(279, 457);
            this.radioButtonAb.Name = "radioButtonAb";
            this.radioButtonAb.Size = new System.Drawing.Size(17, 16);
            this.radioButtonAb.TabIndex = 16;
            this.radioButtonAb.TabStop = true;
            this.radioButtonAb.UseVisualStyleBackColor = true;
            // 
            // labelAn
            // 
            this.labelAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAn.AutoSize = true;
            this.labelAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAn.Location = new System.Drawing.Point(341, 449);
            this.labelAn.Name = "labelAn";
            this.labelAn.Size = new System.Drawing.Size(41, 29);
            this.labelAn.TabIndex = 15;
            this.labelAn.Text = "An";
            // 
            // labelAb
            // 
            this.labelAb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAb.AutoSize = true;
            this.labelAb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAb.Location = new System.Drawing.Point(234, 449);
            this.labelAb.Name = "labelAb";
            this.labelAb.Size = new System.Drawing.Size(42, 29);
            this.labelAb.TabIndex = 14;
            this.labelAb.Text = "Ab";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(22, 414);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(135, 29);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "Zeit:";
            // 
            // timePicker
            // 
            this.timePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(27, 446);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(157, 36);
            this.timePicker.TabIndex = 12;
            // 
            // labelDatum
            // 
            this.labelDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.Location = new System.Drawing.Point(22, 318);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(168, 29);
            this.labelDatum.TabIndex = 11;
            this.labelDatum.Text = "Datum:";
            // 
            // datePicker
            // 
            this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Location = new System.Drawing.Point(26, 350);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(507, 36);
            this.datePicker.TabIndex = 10;
            // 
            // labelTo
            // 
            this.labelTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(21, 223);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(129, 29);
            this.labelTo.TabIndex = 9;
            this.labelTo.Text = "Bis:";
            // 
            // textBoxBis
            // 
            this.textBoxBis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBis.Location = new System.Drawing.Point(25, 255);
            this.textBoxBis.Name = "textBoxBis";
            this.textBoxBis.Size = new System.Drawing.Size(508, 38);
            this.textBoxBis.TabIndex = 8;
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(22, 131);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(138, 29);
            this.labelFrom.TabIndex = 7;
            this.labelFrom.Text = "Von:";
            // 
            // textBoxVon
            // 
            this.textBoxVon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVon.Location = new System.Drawing.Point(26, 163);
            this.textBoxVon.Name = "textBoxVon";
            this.textBoxVon.Size = new System.Drawing.Size(508, 38);
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
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(25, 65);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(509, 39);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Verbindung suchen";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelConnections
            // 
            this.panelConnections.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelConnections.Controls.Add(this.tableConnections);
            this.panelConnections.Controls.Add(this.pictureBox1);
            this.panelConnections.Controls.Add(this.labelConnections);
            this.panelConnections.Controls.Add(this.labelFromTo);
            this.panelConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConnections.Location = new System.Drawing.Point(0, 0);
            this.panelConnections.Name = "panelConnections";
            this.panelConnections.Size = new System.Drawing.Size(565, 637);
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
            this.labelConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnections.Location = new System.Drawing.Point(27, 65);
            this.labelConnections.Name = "labelConnections";
            this.labelConnections.Size = new System.Drawing.Size(507, 39);
            this.labelConnections.TabIndex = 5;
            this.labelConnections.Text = "Verbindungen";
            this.labelConnections.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableConnections
            // 
            this.tableConnections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableConnections.ColumnHeadersHeight = 29;
            this.tableConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zeit,
            this.Linie,
            this.Gleis});
            this.tableConnections.Location = new System.Drawing.Point(30, 213);
            this.tableConnections.Name = "tableConnections";
            this.tableConnections.RowHeadersWidth = 51;
            this.tableConnections.RowTemplate.Height = 24;
            this.tableConnections.Size = new System.Drawing.Size(504, 392);
            this.tableConnections.TabIndex = 7;
            // 
            // labelFromTo
            // 
            this.labelFromTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFromTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromTo.Location = new System.Drawing.Point(27, 118);
            this.labelFromTo.Name = "labelFromTo";
            this.labelFromTo.Size = new System.Drawing.Size(506, 75);
            this.labelFromTo.TabIndex = 8;
            this.labelFromTo.Text = "Von x bis x\r\n";
            this.labelFromTo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Zeit
            // 
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zeit.DefaultCellStyle = dataGridViewCellStyle22;
            this.Zeit.HeaderText = "Zeit";
            this.Zeit.MinimumWidth = 6;
            this.Zeit.Name = "Zeit";
            this.Zeit.ReadOnly = true;
            // 
            // Linie
            // 
            this.Linie.HeaderText = "Linie";
            this.Linie.MinimumWidth = 6;
            this.Linie.Name = "Linie";
            this.Linie.ReadOnly = true;
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.MinimumWidth = 6;
            this.Gleis.Name = "Gleis";
            this.Gleis.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 637);
            this.Controls.Add(this.panelConnections);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelMain);
            this.MinimumSize = new System.Drawing.Size(510, 674);
            this.Name = "FormMain";
            this.Text = "Transport App";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBackSearch)).EndInit();
            this.panelConnections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableConnections)).EndInit();
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
        private System.Windows.Forms.DataGridView tableConnections;
        private System.Windows.Forms.Label labelFromTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
    }
}

