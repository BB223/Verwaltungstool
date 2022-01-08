
namespace Verwaltungstool.Forms.BuchungForms
{
    partial class BuchungsForm
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
            this.buttonZurück = new System.Windows.Forms.Button();
            this.groupBoxLeistungen = new System.Windows.Forms.GroupBox();
            this.checkBoxFrühstück = new System.Windows.Forms.CheckBox();
            this.checkBoxBabybett = new System.Windows.Forms.CheckBox();
            this.checkBoxPayTV = new System.Windows.Forms.CheckBox();
            this.groupBoxGruppe = new System.Windows.Forms.GroupBox();
            this.listBoxGruppe = new System.Windows.Forms.ListBox();
            this.labelGebäude = new System.Windows.Forms.Label();
            this.labelZimmernummer = new System.Windows.Forms.Label();
            this.labelZimmerTyp = new System.Windows.Forms.Label();
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.groupBoxZimmer = new System.Windows.Forms.GroupBox();
            this.listBoxZimmer = new System.Windows.Forms.ListBox();
            this.checkBoxHauptrasse = new System.Windows.Forms.CheckBox();
            this.checkBoxFernseher = new System.Windows.Forms.CheckBox();
            this.checkBoxKühlschrank = new System.Windows.Forms.CheckBox();
            this.comboBoxTerrasseBalkon = new System.Windows.Forms.ComboBox();
            this.comboBoxZimmerTyp = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.groupBoxLeistungen.SuspendLayout();
            this.groupBoxGruppe.SuspendLayout();
            this.groupBoxZimmer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonZurück
            // 
            this.buttonZurück.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZurück.AutoSize = true;
            this.buttonZurück.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZurück.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZurück.Location = new System.Drawing.Point(592, 443);
            this.buttonZurück.Name = "buttonZurück";
            this.buttonZurück.Size = new System.Drawing.Size(75, 30);
            this.buttonZurück.TabIndex = 12;
            this.buttonZurück.Text = "Zurück";
            this.buttonZurück.UseVisualStyleBackColor = true;
            this.buttonZurück.Click += new System.EventHandler(this.ButtonZurück_Click);
            // 
            // groupBoxLeistungen
            // 
            this.groupBoxLeistungen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLeistungen.Controls.Add(this.checkBoxFrühstück);
            this.groupBoxLeistungen.Controls.Add(this.checkBoxBabybett);
            this.groupBoxLeistungen.Controls.Add(this.checkBoxPayTV);
            this.groupBoxLeistungen.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBoxLeistungen.Location = new System.Drawing.Point(431, 269);
            this.groupBoxLeistungen.Name = "groupBoxLeistungen";
            this.groupBoxLeistungen.Size = new System.Drawing.Size(117, 107);
            this.groupBoxLeistungen.TabIndex = 14;
            this.groupBoxLeistungen.TabStop = false;
            this.groupBoxLeistungen.Text = "Zusatzleistung";
            // 
            // checkBoxFrühstück
            // 
            this.checkBoxFrühstück.AutoSize = true;
            this.checkBoxFrühstück.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxFrühstück.Location = new System.Drawing.Point(3, 69);
            this.checkBoxFrühstück.Name = "checkBoxFrühstück";
            this.checkBoxFrühstück.Size = new System.Drawing.Size(111, 23);
            this.checkBoxFrühstück.TabIndex = 17;
            this.checkBoxFrühstück.Text = "Frühstück";
            this.checkBoxFrühstück.UseVisualStyleBackColor = true;
            // 
            // checkBoxBabybett
            // 
            this.checkBoxBabybett.AutoSize = true;
            this.checkBoxBabybett.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxBabybett.Location = new System.Drawing.Point(3, 46);
            this.checkBoxBabybett.Name = "checkBoxBabybett";
            this.checkBoxBabybett.Size = new System.Drawing.Size(111, 23);
            this.checkBoxBabybett.TabIndex = 15;
            this.checkBoxBabybett.Text = "Babybett";
            this.checkBoxBabybett.UseVisualStyleBackColor = true;
            // 
            // checkBoxPayTV
            // 
            this.checkBoxPayTV.AutoSize = true;
            this.checkBoxPayTV.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxPayTV.Location = new System.Drawing.Point(3, 23);
            this.checkBoxPayTV.Name = "checkBoxPayTV";
            this.checkBoxPayTV.Size = new System.Drawing.Size(111, 23);
            this.checkBoxPayTV.TabIndex = 16;
            this.checkBoxPayTV.Text = "PayTV";
            this.checkBoxPayTV.UseVisualStyleBackColor = true;
            // 
            // groupBoxGruppe
            // 
            this.groupBoxGruppe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxGruppe.Controls.Add(this.listBoxGruppe);
            this.groupBoxGruppe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGruppe.Location = new System.Drawing.Point(10, 72);
            this.groupBoxGruppe.Name = "groupBoxGruppe";
            this.groupBoxGruppe.Size = new System.Drawing.Size(204, 401);
            this.groupBoxGruppe.TabIndex = 15;
            this.groupBoxGruppe.TabStop = false;
            this.groupBoxGruppe.Text = "Gruppe";
            // 
            // listBoxGruppe
            // 
            this.listBoxGruppe.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxGruppe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxGruppe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxGruppe.FormattingEnabled = true;
            this.listBoxGruppe.ItemHeight = 19;
            this.listBoxGruppe.Location = new System.Drawing.Point(3, 23);
            this.listBoxGruppe.Name = "listBoxGruppe";
            this.listBoxGruppe.Size = new System.Drawing.Size(198, 375);
            this.listBoxGruppe.TabIndex = 0;
            this.listBoxGruppe.DoubleClick += new System.EventHandler(this.ListBoxGruppe_DoubleClick);
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
            this.labelGebäude.TabIndex = 16;
            this.labelGebäude.Text = "Gebäude:";
            // 
            // labelZimmernummer
            // 
            this.labelZimmernummer.AutoSize = true;
            this.labelZimmernummer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelZimmernummer.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZimmernummer.Location = new System.Drawing.Point(162, 0);
            this.labelZimmernummer.Name = "labelZimmernummer";
            this.labelZimmernummer.Size = new System.Drawing.Size(201, 33);
            this.labelZimmernummer.TabIndex = 17;
            this.labelZimmernummer.Text = "Zimmernummer:";
            // 
            // labelZimmerTyp
            // 
            this.labelZimmerTyp.AutoSize = true;
            this.labelZimmerTyp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelZimmerTyp.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZimmerTyp.Location = new System.Drawing.Point(448, 0);
            this.labelZimmerTyp.Name = "labelZimmerTyp";
            this.labelZimmerTyp.Size = new System.Drawing.Size(138, 33);
            this.labelZimmerTyp.TabIndex = 18;
            this.labelZimmerTyp.Text = "ZimmerTyp";
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSpeichern.AutoSize = true;
            this.buttonSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpeichern.Location = new System.Drawing.Point(511, 443);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(75, 30);
            this.buttonSpeichern.TabIndex = 19;
            this.buttonSpeichern.Text = "Speichern";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.ButtonSpeichern_Click);
            // 
            // groupBoxZimmer
            // 
            this.groupBoxZimmer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxZimmer.Controls.Add(this.listBoxZimmer);
            this.groupBoxZimmer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxZimmer.Location = new System.Drawing.Point(219, 72);
            this.groupBoxZimmer.Name = "groupBoxZimmer";
            this.groupBoxZimmer.Size = new System.Drawing.Size(204, 401);
            this.groupBoxZimmer.TabIndex = 16;
            this.groupBoxZimmer.TabStop = false;
            this.groupBoxZimmer.Text = "Zimmer";
            // 
            // listBoxZimmer
            // 
            this.listBoxZimmer.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxZimmer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxZimmer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxZimmer.FormattingEnabled = true;
            this.listBoxZimmer.ItemHeight = 19;
            this.listBoxZimmer.Location = new System.Drawing.Point(3, 23);
            this.listBoxZimmer.Name = "listBoxZimmer";
            this.listBoxZimmer.Size = new System.Drawing.Size(198, 375);
            this.listBoxZimmer.TabIndex = 0;
            // 
            // checkBoxHauptrasse
            // 
            this.checkBoxHauptrasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHauptrasse.AutoSize = true;
            this.checkBoxHauptrasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxHauptrasse.Location = new System.Drawing.Point(429, 193);
            this.checkBoxHauptrasse.Name = "checkBoxHauptrasse";
            this.checkBoxHauptrasse.Size = new System.Drawing.Size(108, 19);
            this.checkBoxHauptrasse.TabIndex = 25;
            this.checkBoxHauptrasse.Text = "An Hauptstraße";
            this.checkBoxHauptrasse.UseVisualStyleBackColor = true;
            this.checkBoxHauptrasse.Visible = false;
            this.checkBoxHauptrasse.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxFernseher
            // 
            this.checkBoxFernseher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFernseher.AutoSize = true;
            this.checkBoxFernseher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxFernseher.Location = new System.Drawing.Point(429, 168);
            this.checkBoxFernseher.Name = "checkBoxFernseher";
            this.checkBoxFernseher.Size = new System.Drawing.Size(77, 19);
            this.checkBoxFernseher.TabIndex = 24;
            this.checkBoxFernseher.Text = "Fernseher";
            this.checkBoxFernseher.UseVisualStyleBackColor = true;
            this.checkBoxFernseher.Visible = false;
            this.checkBoxFernseher.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxKühlschrank
            // 
            this.checkBoxKühlschrank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxKühlschrank.AutoSize = true;
            this.checkBoxKühlschrank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxKühlschrank.Location = new System.Drawing.Point(429, 143);
            this.checkBoxKühlschrank.Name = "checkBoxKühlschrank";
            this.checkBoxKühlschrank.Size = new System.Drawing.Size(92, 19);
            this.checkBoxKühlschrank.TabIndex = 23;
            this.checkBoxKühlschrank.Text = "Kühlschrank";
            this.checkBoxKühlschrank.UseVisualStyleBackColor = true;
            this.checkBoxKühlschrank.Visible = false;
            this.checkBoxKühlschrank.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // comboBoxTerrasseBalkon
            // 
            this.comboBoxTerrasseBalkon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTerrasseBalkon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTerrasseBalkon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTerrasseBalkon.FormattingEnabled = true;
            this.comboBoxTerrasseBalkon.Location = new System.Drawing.Point(429, 218);
            this.comboBoxTerrasseBalkon.Name = "comboBoxTerrasseBalkon";
            this.comboBoxTerrasseBalkon.Size = new System.Drawing.Size(121, 22);
            this.comboBoxTerrasseBalkon.TabIndex = 22;
            this.comboBoxTerrasseBalkon.Visible = false;
            this.comboBoxTerrasseBalkon.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // comboBoxZimmerTyp
            // 
            this.comboBoxZimmerTyp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxZimmerTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZimmerTyp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxZimmerTyp.FormattingEnabled = true;
            this.comboBoxZimmerTyp.Location = new System.Drawing.Point(429, 115);
            this.comboBoxZimmerTyp.Name = "comboBoxZimmerTyp";
            this.comboBoxZimmerTyp.Size = new System.Drawing.Size(121, 22);
            this.comboBoxZimmerTyp.TabIndex = 21;
            this.comboBoxZimmerTyp.Visible = false;
            this.comboBoxZimmerTyp.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Location = new System.Drawing.Point(429, 86);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 20;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // BuchungsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 484);
            this.Controls.Add(this.checkBoxHauptrasse);
            this.Controls.Add(this.checkBoxFernseher);
            this.Controls.Add(this.checkBoxKühlschrank);
            this.Controls.Add(this.comboBoxTerrasseBalkon);
            this.Controls.Add(this.comboBoxZimmerTyp);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.groupBoxZimmer);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(this.labelZimmerTyp);
            this.Controls.Add(this.labelZimmernummer);
            this.Controls.Add(this.labelGebäude);
            this.Controls.Add(this.groupBoxGruppe);
            this.Controls.Add(this.groupBoxLeistungen);
            this.Controls.Add(this.buttonZurück);
            this.Font = new System.Drawing.Font("Calibri", 9.25F);
            this.Name = "BuchungsForm";
            this.Text = "Buchungs Übersicht";
            this.groupBoxLeistungen.ResumeLayout(false);
            this.groupBoxLeistungen.PerformLayout();
            this.groupBoxGruppe.ResumeLayout(false);
            this.groupBoxZimmer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZurück;
        private System.Windows.Forms.GroupBox groupBoxLeistungen;
        private System.Windows.Forms.CheckBox checkBoxFrühstück;
        private System.Windows.Forms.CheckBox checkBoxBabybett;
        private System.Windows.Forms.CheckBox checkBoxPayTV;
        private System.Windows.Forms.GroupBox groupBoxGruppe;
        private System.Windows.Forms.ListBox listBoxGruppe;
        private System.Windows.Forms.Label labelGebäude;
        private System.Windows.Forms.Label labelZimmernummer;
        private System.Windows.Forms.Label labelZimmerTyp;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.GroupBox groupBoxZimmer;
        private System.Windows.Forms.ListBox listBoxZimmer;
        private System.Windows.Forms.CheckBox checkBoxHauptrasse;
        private System.Windows.Forms.CheckBox checkBoxFernseher;
        private System.Windows.Forms.CheckBox checkBoxKühlschrank;
        private System.Windows.Forms.ComboBox comboBoxTerrasseBalkon;
        private System.Windows.Forms.ComboBox comboBoxZimmerTyp;
        private System.Windows.Forms.Button buttonFilter;
    }
}