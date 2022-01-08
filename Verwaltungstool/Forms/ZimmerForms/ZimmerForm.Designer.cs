namespace Verwaltungstool.Forms.ZimmerForms
{
    partial class ZimmerForm
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
            this.labelZimmernummer = new System.Windows.Forms.Label();
            this.labelGebäude = new System.Windows.Forms.Label();
            this.labelZimmerTyp = new System.Windows.Forms.Label();
            this.groupBoxEigenschaften = new System.Windows.Forms.GroupBox();
            this.labelTerasseBalkon = new System.Windows.Forms.Label();
            this.labelHauptstrasse = new System.Windows.Forms.Label();
            this.labelKühlschrank = new System.Windows.Forms.Label();
            this.labelFernseher = new System.Windows.Forms.Label();
            this.buttonZurück = new System.Windows.Forms.Button();
            this.listBoxGruppe = new System.Windows.Forms.ListBox();
            this.groupBoxGruppe = new System.Windows.Forms.GroupBox();
            this.groupBoxLeistungen = new System.Windows.Forms.GroupBox();
            this.labelFruehstueck = new System.Windows.Forms.Label();
            this.labelPayTV = new System.Windows.Forms.Label();
            this.labelBabybett = new System.Windows.Forms.Label();
            this.buttonBuchen = new System.Windows.Forms.Button();
            this.buttonZurBuchung = new System.Windows.Forms.Button();
            this.pictureBoxBezahler = new System.Windows.Forms.PictureBox();
            this.groupBoxEigenschaften.SuspendLayout();
            this.groupBoxGruppe.SuspendLayout();
            this.groupBoxLeistungen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBezahler)).BeginInit();
            this.SuspendLayout();
            // 
            // labelZimmernummer
            // 
            this.labelZimmernummer.AutoSize = true;
            this.labelZimmernummer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelZimmernummer.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZimmernummer.Location = new System.Drawing.Point(189, 0);
            this.labelZimmernummer.Name = "labelZimmernummer";
            this.labelZimmernummer.Size = new System.Drawing.Size(201, 33);
            this.labelZimmernummer.TabIndex = 10;
            this.labelZimmernummer.Text = "Zimmernummer:";
            // 
            // labelGebäude
            // 
            this.labelGebäude.AutoSize = true;
            this.labelGebäude.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelGebäude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGebäude.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGebäude.Location = new System.Drawing.Point(0, 0);
            this.labelGebäude.Name = "labelGebäude";
            this.labelGebäude.Size = new System.Drawing.Size(120, 33);
            this.labelGebäude.TabIndex = 9;
            this.labelGebäude.Text = "Gebäude:";
            // 
            // labelZimmerTyp
            // 
            this.labelZimmerTyp.AutoSize = true;
            this.labelZimmerTyp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelZimmerTyp.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZimmerTyp.Location = new System.Drawing.Point(480, 0);
            this.labelZimmerTyp.Name = "labelZimmerTyp";
            this.labelZimmerTyp.Size = new System.Drawing.Size(138, 33);
            this.labelZimmerTyp.TabIndex = 8;
            this.labelZimmerTyp.Text = "ZimmerTyp";
            // 
            // groupBoxEigenschaften
            // 
            this.groupBoxEigenschaften.AutoSize = true;
            this.groupBoxEigenschaften.Controls.Add(this.labelTerasseBalkon);
            this.groupBoxEigenschaften.Controls.Add(this.labelHauptstrasse);
            this.groupBoxEigenschaften.Controls.Add(this.labelKühlschrank);
            this.groupBoxEigenschaften.Controls.Add(this.labelFernseher);
            this.groupBoxEigenschaften.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxEigenschaften.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEigenschaften.Location = new System.Drawing.Point(12, 53);
            this.groupBoxEigenschaften.Name = "groupBoxEigenschaften";
            this.groupBoxEigenschaften.Size = new System.Drawing.Size(117, 110);
            this.groupBoxEigenschaften.TabIndex = 7;
            this.groupBoxEigenschaften.TabStop = false;
            this.groupBoxEigenschaften.Text = "Eigenschaften";
            // 
            // labelTerasseBalkon
            // 
            this.labelTerasseBalkon.AutoSize = true;
            this.labelTerasseBalkon.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTerasseBalkon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTerasseBalkon.Location = new System.Drawing.Point(3, 80);
            this.labelTerasseBalkon.Name = "labelTerasseBalkon";
            this.labelTerasseBalkon.Size = new System.Drawing.Size(102, 19);
            this.labelTerasseBalkon.TabIndex = 3;
            this.labelTerasseBalkon.Text = "TerasseBalkon";
            // 
            // labelHauptstrasse
            // 
            this.labelHauptstrasse.AutoSize = true;
            this.labelHauptstrasse.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHauptstrasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHauptstrasse.Location = new System.Drawing.Point(3, 61);
            this.labelHauptstrasse.Name = "labelHauptstrasse";
            this.labelHauptstrasse.Size = new System.Drawing.Size(110, 19);
            this.labelHauptstrasse.TabIndex = 2;
            this.labelHauptstrasse.Text = "An Hauptstraße";
            // 
            // labelKühlschrank
            // 
            this.labelKühlschrank.AutoSize = true;
            this.labelKühlschrank.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelKühlschrank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelKühlschrank.Location = new System.Drawing.Point(3, 42);
            this.labelKühlschrank.Name = "labelKühlschrank";
            this.labelKühlschrank.Size = new System.Drawing.Size(87, 19);
            this.labelKühlschrank.TabIndex = 4;
            this.labelKühlschrank.Text = "Kühlschrank";
            // 
            // labelFernseher
            // 
            this.labelFernseher.AutoSize = true;
            this.labelFernseher.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFernseher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFernseher.Location = new System.Drawing.Point(3, 23);
            this.labelFernseher.Name = "labelFernseher";
            this.labelFernseher.Size = new System.Drawing.Size(73, 19);
            this.labelFernseher.TabIndex = 0;
            this.labelFernseher.Text = "Fernseher";
            // 
            // buttonZurück
            // 
            this.buttonZurück.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZurück.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZurück.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZurück.Location = new System.Drawing.Point(634, 449);
            this.buttonZurück.Name = "buttonZurück";
            this.buttonZurück.Size = new System.Drawing.Size(75, 25);
            this.buttonZurück.TabIndex = 6;
            this.buttonZurück.Text = "Zurück";
            this.buttonZurück.UseVisualStyleBackColor = true;
            this.buttonZurück.Click += new System.EventHandler(this.ButtonZurück_Click);
            // 
            // listBoxGruppe
            // 
            this.listBoxGruppe.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxGruppe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxGruppe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxGruppe.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBoxGruppe.FormattingEnabled = true;
            this.listBoxGruppe.ItemHeight = 19;
            this.listBoxGruppe.Location = new System.Drawing.Point(3, 23);
            this.listBoxGruppe.Name = "listBoxGruppe";
            this.listBoxGruppe.Size = new System.Drawing.Size(272, 364);
            this.listBoxGruppe.TabIndex = 11;
            this.listBoxGruppe.DoubleClick += new System.EventHandler(this.ListBoxGruppe_DoubleClick);
            // 
            // groupBoxGruppe
            // 
            this.groupBoxGruppe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxGruppe.Controls.Add(this.listBoxGruppe);
            this.groupBoxGruppe.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBoxGruppe.Location = new System.Drawing.Point(170, 53);
            this.groupBoxGruppe.Name = "groupBoxGruppe";
            this.groupBoxGruppe.Size = new System.Drawing.Size(278, 390);
            this.groupBoxGruppe.TabIndex = 12;
            this.groupBoxGruppe.TabStop = false;
            this.groupBoxGruppe.Text = "Gäste";
            // 
            // groupBoxLeistungen
            // 
            this.groupBoxLeistungen.Controls.Add(this.labelFruehstueck);
            this.groupBoxLeistungen.Controls.Add(this.labelPayTV);
            this.groupBoxLeistungen.Controls.Add(this.labelBabybett);
            this.groupBoxLeistungen.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBoxLeistungen.Location = new System.Drawing.Point(12, 181);
            this.groupBoxLeistungen.Name = "groupBoxLeistungen";
            this.groupBoxLeistungen.Size = new System.Drawing.Size(117, 100);
            this.groupBoxLeistungen.TabIndex = 13;
            this.groupBoxLeistungen.TabStop = false;
            this.groupBoxLeistungen.Text = "Zusatzleistung";
            // 
            // labelFruehstueck
            // 
            this.labelFruehstueck.AutoSize = true;
            this.labelFruehstueck.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFruehstueck.Location = new System.Drawing.Point(3, 61);
            this.labelFruehstueck.Name = "labelFruehstueck";
            this.labelFruehstueck.Size = new System.Drawing.Size(71, 19);
            this.labelFruehstueck.TabIndex = 2;
            this.labelFruehstueck.Text = "Frühstück";
            // 
            // labelPayTV
            // 
            this.labelPayTV.AutoSize = true;
            this.labelPayTV.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPayTV.Location = new System.Drawing.Point(3, 42);
            this.labelPayTV.Name = "labelPayTV";
            this.labelPayTV.Size = new System.Drawing.Size(49, 19);
            this.labelPayTV.TabIndex = 1;
            this.labelPayTV.Text = "PayTV";
            // 
            // labelBabybett
            // 
            this.labelBabybett.AutoSize = true;
            this.labelBabybett.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBabybett.Location = new System.Drawing.Point(3, 23);
            this.labelBabybett.Name = "labelBabybett";
            this.labelBabybett.Size = new System.Drawing.Size(67, 19);
            this.labelBabybett.TabIndex = 0;
            this.labelBabybett.Text = "Babybett";
            // 
            // buttonBuchen
            // 
            this.buttonBuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBuchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuchen.Location = new System.Drawing.Point(6, 450);
            this.buttonBuchen.Name = "buttonBuchen";
            this.buttonBuchen.Size = new System.Drawing.Size(75, 25);
            this.buttonBuchen.TabIndex = 14;
            this.buttonBuchen.Text = "Buchen";
            this.buttonBuchen.UseVisualStyleBackColor = true;
            this.buttonBuchen.Click += new System.EventHandler(this.ButtonBuchen_Click);
            // 
            // buttonZurBuchung
            // 
            this.buttonZurBuchung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZurBuchung.AutoSize = true;
            this.buttonZurBuchung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZurBuchung.Location = new System.Drawing.Point(6, 417);
            this.buttonZurBuchung.Name = "buttonZurBuchung";
            this.buttonZurBuchung.Size = new System.Drawing.Size(87, 27);
            this.buttonZurBuchung.TabIndex = 15;
            this.buttonZurBuchung.Text = "Zur Buchung";
            this.buttonZurBuchung.UseVisualStyleBackColor = true;
            this.buttonZurBuchung.Visible = false;
            this.buttonZurBuchung.Click += new System.EventHandler(this.ButtonZurBuchung_Click);
            // 
            // pictureBoxBezahler
            // 
            this.pictureBoxBezahler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxBezahler.Image = global::Verwaltungstool.Properties.Resources.Bezahler;
            this.pictureBoxBezahler.Location = new System.Drawing.Point(152, 78);
            this.pictureBoxBezahler.Name = "pictureBoxBezahler";
            this.pictureBoxBezahler.Size = new System.Drawing.Size(15, 15);
            this.pictureBoxBezahler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBezahler.TabIndex = 16;
            this.pictureBoxBezahler.TabStop = false;
            this.pictureBoxBezahler.Visible = false;
            // 
            // ZimmerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 484);
            this.Controls.Add(this.pictureBoxBezahler);
            this.Controls.Add(this.buttonZurBuchung);
            this.Controls.Add(this.buttonBuchen);
            this.Controls.Add(this.groupBoxLeistungen);
            this.Controls.Add(this.groupBoxGruppe);
            this.Controls.Add(this.labelZimmernummer);
            this.Controls.Add(this.labelGebäude);
            this.Controls.Add(this.labelZimmerTyp);
            this.Controls.Add(this.groupBoxEigenschaften);
            this.Controls.Add(this.buttonZurück);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ZimmerForm";
            this.Text = "Zimmerformular";
            this.groupBoxEigenschaften.ResumeLayout(false);
            this.groupBoxEigenschaften.PerformLayout();
            this.groupBoxGruppe.ResumeLayout(false);
            this.groupBoxLeistungen.ResumeLayout(false);
            this.groupBoxLeistungen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBezahler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZimmernummer;
        private System.Windows.Forms.Label labelGebäude;
        private System.Windows.Forms.Label labelZimmerTyp;
        private System.Windows.Forms.GroupBox groupBoxEigenschaften;
        private System.Windows.Forms.Label labelTerasseBalkon;
        private System.Windows.Forms.Label labelHauptstrasse;
        private System.Windows.Forms.Label labelKühlschrank;
        private System.Windows.Forms.Label labelFernseher;
        private System.Windows.Forms.Button buttonZurück;
        private System.Windows.Forms.ListBox listBoxGruppe;
        private System.Windows.Forms.GroupBox groupBoxGruppe;
        private System.Windows.Forms.GroupBox groupBoxLeistungen;
        private System.Windows.Forms.Label labelFruehstueck;
        private System.Windows.Forms.Label labelPayTV;
        private System.Windows.Forms.Label labelBabybett;
        private System.Windows.Forms.Button buttonBuchen;
        private System.Windows.Forms.Button buttonZurBuchung;
        private System.Windows.Forms.PictureBox pictureBoxBezahler;
    }
}