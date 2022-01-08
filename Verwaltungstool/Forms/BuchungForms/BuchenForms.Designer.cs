namespace Verwaltungstool.Forms.BuchungForms
{
    partial class BuchenForms
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAbbruch = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxNachname = new System.Windows.Forms.TextBox();
            this.labelNachname = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBoxGastHinzufügen = new System.Windows.Forms.GroupBox();
            this.textBoxOrt = new System.Windows.Forms.TextBox();
            this.labelOrt = new System.Windows.Forms.Label();
            this.labelPLZ = new System.Windows.Forms.Label();
            this.labelHausnummer = new System.Windows.Forms.Label();
            this.labelStraße = new System.Windows.Forms.Label();
            this.textBoxPLZ = new System.Windows.Forms.TextBox();
            this.textBoxStraße = new System.Windows.Forms.TextBox();
            this.textBoxHausnummer = new System.Windows.Forms.TextBox();
            this.buttonHinzufügen = new System.Windows.Forms.Button();
            this.checkBoxPayTV = new System.Windows.Forms.CheckBox();
            this.checkBoxFrühstück = new System.Windows.Forms.CheckBox();
            this.checkBoxBabybett = new System.Windows.Forms.CheckBox();
            this.groupBoxZusatz = new System.Windows.Forms.GroupBox();
            this.groupBoxGruppe = new System.Windows.Forms.GroupBox();
            this.listBoxGruppe = new System.Windows.Forms.ListBox();
            this.buttonEntfernen = new System.Windows.Forms.Button();
            this.groupBoxGastHinzufügen.SuspendLayout();
            this.groupBoxZusatz.SuspendLayout();
            this.groupBoxGruppe.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Enabled = false;
            this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK.Location = new System.Drawing.Point(642, 234);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 25);
            this.buttonOK.TabIndex = 19;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonAbbruch
            // 
            this.buttonAbbruch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbbruch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAbbruch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbbruch.Location = new System.Drawing.Point(561, 234);
            this.buttonAbbruch.Name = "buttonAbbruch";
            this.buttonAbbruch.Size = new System.Drawing.Size(75, 25);
            this.buttonAbbruch.TabIndex = 20;
            this.buttonAbbruch.Text = "Abbrechen";
            this.buttonAbbruch.UseVisualStyleBackColor = true;
            this.buttonAbbruch.Click += new System.EventHandler(this.ButtonAbbruch_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(131, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 27);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.Tag = this.labelName;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 19);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // textBoxNachname
            // 
            this.textBoxNachname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNachname.Location = new System.Drawing.Point(131, 57);
            this.textBoxNachname.Name = "textBoxNachname";
            this.textBoxNachname.Size = new System.Drawing.Size(100, 27);
            this.textBoxNachname.TabIndex = 4;
            this.textBoxNachname.Tag = this.labelNachname;
            // 
            // labelNachname
            // 
            this.labelNachname.AutoSize = true;
            this.labelNachname.Location = new System.Drawing.Point(6, 60);
            this.labelNachname.Name = "labelNachname";
            this.labelNachname.Size = new System.Drawing.Size(82, 19);
            this.labelNachname.TabIndex = 3;
            this.labelNachname.Text = "Nachname:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Location = new System.Drawing.Point(131, 86);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 27);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.Tag = this.labelEmail;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(6, 89);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 19);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email:";
            // 
            // groupBoxGastHinzufügen
            // 
            this.groupBoxGastHinzufügen.Controls.Add(this.textBoxOrt);
            this.groupBoxGastHinzufügen.Controls.Add(this.labelOrt);
            this.groupBoxGastHinzufügen.Controls.Add(this.labelPLZ);
            this.groupBoxGastHinzufügen.Controls.Add(this.labelHausnummer);
            this.groupBoxGastHinzufügen.Controls.Add(this.labelStraße);
            this.groupBoxGastHinzufügen.Controls.Add(this.labelEmail);
            this.groupBoxGastHinzufügen.Controls.Add(this.labelNachname);
            this.groupBoxGastHinzufügen.Controls.Add(this.labelName);
            this.groupBoxGastHinzufügen.Controls.Add(this.textBoxPLZ);
            this.groupBoxGastHinzufügen.Controls.Add(this.textBoxStraße);
            this.groupBoxGastHinzufügen.Controls.Add(this.textBoxHausnummer);
            this.groupBoxGastHinzufügen.Controls.Add(this.textBoxName);
            this.groupBoxGastHinzufügen.Controls.Add(this.textBoxEmail);
            this.groupBoxGastHinzufügen.Controls.Add(this.textBoxNachname);
            this.groupBoxGastHinzufügen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGastHinzufügen.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGastHinzufügen.Name = "groupBoxGastHinzufügen";
            this.groupBoxGastHinzufügen.Size = new System.Drawing.Size(237, 251);
            this.groupBoxGastHinzufügen.TabIndex = 0;
            this.groupBoxGastHinzufügen.TabStop = false;
            this.groupBoxGastHinzufügen.Text = "Gast hinzufügen";
            // 
            // textBoxOrt
            // 
            this.textBoxOrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrt.Location = new System.Drawing.Point(131, 219);
            this.textBoxOrt.Name = "textBoxOrt";
            this.textBoxOrt.Size = new System.Drawing.Size(100, 27);
            this.textBoxOrt.TabIndex = 14;
            this.textBoxOrt.Tag = this.labelOrt;
            // 
            // labelOrt
            // 
            this.labelOrt.AutoSize = true;
            this.labelOrt.Location = new System.Drawing.Point(6, 219);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(34, 19);
            this.labelOrt.TabIndex = 13;
            this.labelOrt.Text = "Ort:";
            // 
            // labelPLZ
            // 
            this.labelPLZ.AutoSize = true;
            this.labelPLZ.Location = new System.Drawing.Point(6, 191);
            this.labelPLZ.Name = "labelPLZ";
            this.labelPLZ.Size = new System.Drawing.Size(36, 19);
            this.labelPLZ.TabIndex = 11;
            this.labelPLZ.Text = "PLZ:";
            // 
            // labelHausnummer
            // 
            this.labelHausnummer.AutoSize = true;
            this.labelHausnummer.Location = new System.Drawing.Point(6, 162);
            this.labelHausnummer.Name = "labelHausnummer";
            this.labelHausnummer.Size = new System.Drawing.Size(99, 19);
            this.labelHausnummer.TabIndex = 9;
            this.labelHausnummer.Text = "Hausnummer:";
            // 
            // labelStraße
            // 
            this.labelStraße.AutoSize = true;
            this.labelStraße.Location = new System.Drawing.Point(6, 133);
            this.labelStraße.Name = "labelStraße";
            this.labelStraße.Size = new System.Drawing.Size(54, 19);
            this.labelStraße.TabIndex = 7;
            this.labelStraße.Text = "Straße:";
            // 
            // textBoxPLZ
            // 
            this.textBoxPLZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPLZ.Location = new System.Drawing.Point(131, 188);
            this.textBoxPLZ.MaxLength = 5;
            this.textBoxPLZ.Name = "textBoxPLZ";
            this.textBoxPLZ.Size = new System.Drawing.Size(100, 27);
            this.textBoxPLZ.TabIndex = 12;
            this.textBoxPLZ.Tag = this.labelPLZ;
            this.textBoxPLZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPLZ_KeyPress);
            this.textBoxPLZ.Leave += new System.EventHandler(this.TextBoxPLZ_Leave);
            // 
            // textBoxStraße
            // 
            this.textBoxStraße.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStraße.Location = new System.Drawing.Point(131, 130);
            this.textBoxStraße.Name = "textBoxStraße";
            this.textBoxStraße.Size = new System.Drawing.Size(100, 27);
            this.textBoxStraße.TabIndex = 8;
            this.textBoxStraße.Tag = this.labelStraße;
            // 
            // textBoxHausnummer
            // 
            this.textBoxHausnummer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHausnummer.Location = new System.Drawing.Point(131, 159);
            this.textBoxHausnummer.Name = "textBoxHausnummer";
            this.textBoxHausnummer.Size = new System.Drawing.Size(100, 27);
            this.textBoxHausnummer.TabIndex = 10;
            this.textBoxHausnummer.Tag = this.labelHausnummer;
            // 
            // buttonHinzufügen
            // 
            this.buttonHinzufügen.AutoSize = true;
            this.buttonHinzufügen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHinzufügen.Location = new System.Drawing.Point(255, 98);
            this.buttonHinzufügen.Name = "buttonHinzufügen";
            this.buttonHinzufügen.Size = new System.Drawing.Size(94, 27);
            this.buttonHinzufügen.TabIndex = 15;
            this.buttonHinzufügen.Text = "Hinzufügen ->";
            this.buttonHinzufügen.UseVisualStyleBackColor = true;
            this.buttonHinzufügen.Click += new System.EventHandler(this.ButtonHinzufügen_Click);
            // 
            // checkBoxPayTV
            // 
            this.checkBoxPayTV.AutoSize = true;
            this.checkBoxPayTV.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxPayTV.Location = new System.Drawing.Point(3, 69);
            this.checkBoxPayTV.Name = "checkBoxPayTV";
            this.checkBoxPayTV.Size = new System.Drawing.Size(108, 23);
            this.checkBoxPayTV.TabIndex = 18;
            this.checkBoxPayTV.Text = "PayTV";
            this.checkBoxPayTV.UseVisualStyleBackColor = true;
            // 
            // checkBoxFrühstück
            // 
            this.checkBoxFrühstück.AutoSize = true;
            this.checkBoxFrühstück.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxFrühstück.Location = new System.Drawing.Point(3, 23);
            this.checkBoxFrühstück.Name = "checkBoxFrühstück";
            this.checkBoxFrühstück.Size = new System.Drawing.Size(108, 23);
            this.checkBoxFrühstück.TabIndex = 16;
            this.checkBoxFrühstück.Text = "Frühstück";
            this.checkBoxFrühstück.UseVisualStyleBackColor = true;
            // 
            // checkBoxBabybett
            // 
            this.checkBoxBabybett.AutoSize = true;
            this.checkBoxBabybett.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxBabybett.Location = new System.Drawing.Point(3, 46);
            this.checkBoxBabybett.Name = "checkBoxBabybett";
            this.checkBoxBabybett.Size = new System.Drawing.Size(108, 23);
            this.checkBoxBabybett.TabIndex = 17;
            this.checkBoxBabybett.Text = "Babybett";
            this.checkBoxBabybett.UseVisualStyleBackColor = true;
            // 
            // groupBoxZusatz
            // 
            this.groupBoxZusatz.Controls.Add(this.checkBoxPayTV);
            this.groupBoxZusatz.Controls.Add(this.checkBoxBabybett);
            this.groupBoxZusatz.Controls.Add(this.checkBoxFrühstück);
            this.groupBoxZusatz.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxZusatz.Location = new System.Drawing.Point(562, 12);
            this.groupBoxZusatz.Name = "groupBoxZusatz";
            this.groupBoxZusatz.Size = new System.Drawing.Size(114, 96);
            this.groupBoxZusatz.TabIndex = 21;
            this.groupBoxZusatz.TabStop = false;
            this.groupBoxZusatz.Text = "Zusatzleistungen";
            // 
            // groupBoxGruppe
            // 
            this.groupBoxGruppe.Controls.Add(this.listBoxGruppe);
            this.groupBoxGruppe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxGruppe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGruppe.Location = new System.Drawing.Point(355, 12);
            this.groupBoxGruppe.Name = "groupBoxGruppe";
            this.groupBoxGruppe.Size = new System.Drawing.Size(200, 251);
            this.groupBoxGruppe.TabIndex = 22;
            this.groupBoxGruppe.TabStop = false;
            this.groupBoxGruppe.Text = "Gruppe";
            // 
            // listBoxGruppe
            // 
            this.listBoxGruppe.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxGruppe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxGruppe.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxGruppe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxGruppe.FormattingEnabled = true;
            this.listBoxGruppe.ItemHeight = 19;
            this.listBoxGruppe.Location = new System.Drawing.Point(3, 23);
            this.listBoxGruppe.Name = "listBoxGruppe";
            this.listBoxGruppe.Size = new System.Drawing.Size(194, 225);
            this.listBoxGruppe.TabIndex = 0;
            this.listBoxGruppe.SelectedIndexChanged += new System.EventHandler(this.ListBoxGruppe_SelectedIndexChanged);
            // 
            // buttonEntfernen
            // 
            this.buttonEntfernen.AutoSize = true;
            this.buttonEntfernen.Enabled = false;
            this.buttonEntfernen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntfernen.Location = new System.Drawing.Point(256, 142);
            this.buttonEntfernen.Name = "buttonEntfernen";
            this.buttonEntfernen.Size = new System.Drawing.Size(93, 27);
            this.buttonEntfernen.TabIndex = 23;
            this.buttonEntfernen.Text = "Entfernen <-";
            this.buttonEntfernen.UseVisualStyleBackColor = true;
            this.buttonEntfernen.Click += new System.EventHandler(this.ButtonEntfernen_Click);
            // 
            // BuchenForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 272);
            this.Controls.Add(this.buttonEntfernen);
            this.Controls.Add(this.groupBoxGruppe);
            this.Controls.Add(this.groupBoxZusatz);
            this.Controls.Add(this.buttonHinzufügen);
            this.Controls.Add(this.groupBoxGastHinzufügen);
            this.Controls.Add(this.buttonAbbruch);
            this.Controls.Add(this.buttonOK);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(708, 311);
            this.Name = "BuchenForms";
            this.Text = "Buchungsformular";
            this.groupBoxGastHinzufügen.ResumeLayout(false);
            this.groupBoxGastHinzufügen.PerformLayout();
            this.groupBoxZusatz.ResumeLayout(false);
            this.groupBoxZusatz.PerformLayout();
            this.groupBoxGruppe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAbbruch;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNachname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.GroupBox groupBoxGastHinzufügen;
        private System.Windows.Forms.Label labelPLZ;
        private System.Windows.Forms.Label labelHausnummer;
        private System.Windows.Forms.Label labelStraße;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNachname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPLZ;
        private System.Windows.Forms.TextBox textBoxStraße;
        private System.Windows.Forms.TextBox textBoxHausnummer;
        private System.Windows.Forms.Button buttonHinzufügen;
        private System.Windows.Forms.TextBox textBoxOrt;
        private System.Windows.Forms.Label labelOrt;
        private System.Windows.Forms.CheckBox checkBoxPayTV;
        private System.Windows.Forms.CheckBox checkBoxFrühstück;
        private System.Windows.Forms.CheckBox checkBoxBabybett;
        private System.Windows.Forms.GroupBox groupBoxZusatz;
        private System.Windows.Forms.GroupBox groupBoxGruppe;
        private System.Windows.Forms.ListBox listBoxGruppe;
        private System.Windows.Forms.Button buttonEntfernen;
    }
}