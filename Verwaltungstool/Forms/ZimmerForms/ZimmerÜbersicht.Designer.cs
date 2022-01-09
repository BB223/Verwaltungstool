
namespace Verwaltungstool.Forms.ZimmerForms
{
    partial class ZimmerÜbersicht
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
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGebäude = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelZimmer = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonZurücksetzen = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxZimmerTyp = new System.Windows.Forms.ComboBox();
            this.comboBoxTerrasseBalkon = new System.Windows.Forms.ComboBox();
            this.checkBoxKühlschrank = new System.Windows.Forms.CheckBox();
            this.checkBoxFernseher = new System.Windows.Forms.CheckBox();
            this.checkBoxHauptrasse = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDatum.Location = new System.Drawing.Point(724, 12);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(205, 22);
            this.dateTimePickerDatum.TabIndex = 0;
            this.dateTimePickerDatum.ValueChanged += new System.EventHandler(this.DateTimePickerDatum_ValueChanged);
            // 
            // comboBoxGebäude
            // 
            this.comboBoxGebäude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGebäude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGebäude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGebäude.FormattingEnabled = true;
            this.comboBoxGebäude.Location = new System.Drawing.Point(724, 41);
            this.comboBoxGebäude.Name = "comboBoxGebäude";
            this.comboBoxGebäude.Size = new System.Drawing.Size(205, 22);
            this.comboBoxGebäude.TabIndex = 1;
            this.comboBoxGebäude.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // flowLayoutPanelZimmer
            // 
            this.flowLayoutPanelZimmer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelZimmer.AutoScroll = true;
            this.flowLayoutPanelZimmer.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelZimmer.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelZimmer.Name = "flowLayoutPanelZimmer";
            this.flowLayoutPanelZimmer.Size = new System.Drawing.Size(706, 472);
            this.flowLayoutPanelZimmer.TabIndex = 2;
            // 
            // buttonZurücksetzen
            // 
            this.buttonZurücksetzen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZurücksetzen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZurücksetzen.Location = new System.Drawing.Point(833, 459);
            this.buttonZurücksetzen.Name = "buttonZurücksetzen";
            this.buttonZurücksetzen.Size = new System.Drawing.Size(96, 25);
            this.buttonZurücksetzen.TabIndex = 3;
            this.buttonZurücksetzen.Text = "Zurücksetzen";
            this.buttonZurücksetzen.UseVisualStyleBackColor = true;
            this.buttonZurücksetzen.Click += new System.EventHandler(this.ButtonZurücksetzen_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Location = new System.Drawing.Point(724, 114);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // comboBoxZimmerTyp
            // 
            this.comboBoxZimmerTyp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxZimmerTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZimmerTyp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxZimmerTyp.FormattingEnabled = true;
            this.comboBoxZimmerTyp.Location = new System.Drawing.Point(724, 143);
            this.comboBoxZimmerTyp.Name = "comboBoxZimmerTyp";
            this.comboBoxZimmerTyp.Size = new System.Drawing.Size(121, 22);
            this.comboBoxZimmerTyp.TabIndex = 5;
            this.comboBoxZimmerTyp.Visible = false;
            this.comboBoxZimmerTyp.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // comboBoxTerrasseBalkon
            // 
            this.comboBoxTerrasseBalkon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTerrasseBalkon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTerrasseBalkon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTerrasseBalkon.FormattingEnabled = true;
            this.comboBoxTerrasseBalkon.Location = new System.Drawing.Point(724, 246);
            this.comboBoxTerrasseBalkon.Name = "comboBoxTerrasseBalkon";
            this.comboBoxTerrasseBalkon.Size = new System.Drawing.Size(121, 22);
            this.comboBoxTerrasseBalkon.TabIndex = 6;
            this.comboBoxTerrasseBalkon.Visible = false;
            this.comboBoxTerrasseBalkon.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // checkBoxKühlschrank
            // 
            this.checkBoxKühlschrank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxKühlschrank.AutoSize = true;
            this.checkBoxKühlschrank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxKühlschrank.Location = new System.Drawing.Point(727, 171);
            this.checkBoxKühlschrank.Name = "checkBoxKühlschrank";
            this.checkBoxKühlschrank.Size = new System.Drawing.Size(89, 18);
            this.checkBoxKühlschrank.TabIndex = 7;
            this.checkBoxKühlschrank.Text = "Kühlschrank";
            this.checkBoxKühlschrank.UseVisualStyleBackColor = true;
            this.checkBoxKühlschrank.Visible = false;
            this.checkBoxKühlschrank.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxFernseher
            // 
            this.checkBoxFernseher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFernseher.AutoSize = true;
            this.checkBoxFernseher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxFernseher.Location = new System.Drawing.Point(727, 195);
            this.checkBoxFernseher.Name = "checkBoxFernseher";
            this.checkBoxFernseher.Size = new System.Drawing.Size(78, 18);
            this.checkBoxFernseher.TabIndex = 8;
            this.checkBoxFernseher.Text = "Fernseher";
            this.checkBoxFernseher.UseVisualStyleBackColor = true;
            this.checkBoxFernseher.Visible = false;
            this.checkBoxFernseher.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxHauptrasse
            // 
            this.checkBoxHauptrasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHauptrasse.AutoSize = true;
            this.checkBoxHauptrasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxHauptrasse.Location = new System.Drawing.Point(727, 219);
            this.checkBoxHauptrasse.Name = "checkBoxHauptrasse";
            this.checkBoxHauptrasse.Size = new System.Drawing.Size(107, 18);
            this.checkBoxHauptrasse.TabIndex = 9;
            this.checkBoxHauptrasse.Text = "An Hauptstraße";
            this.checkBoxHauptrasse.UseVisualStyleBackColor = true;
            this.checkBoxHauptrasse.Visible = false;
            this.checkBoxHauptrasse.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // ZimmerÜbersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 497);
            this.Controls.Add(this.checkBoxHauptrasse);
            this.Controls.Add(this.checkBoxFernseher);
            this.Controls.Add(this.checkBoxKühlschrank);
            this.Controls.Add(this.comboBoxTerrasseBalkon);
            this.Controls.Add(this.comboBoxZimmerTyp);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonZurücksetzen);
            this.Controls.Add(this.flowLayoutPanelZimmer);
            this.Controls.Add(this.comboBoxGebäude);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ZimmerÜbersicht";
            this.Text = "Zimmer Übersicht";
            this.Load += new System.EventHandler(this.ZimmerÜbersicht_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxGebäude;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelZimmer;
        private System.Windows.Forms.Button buttonZurücksetzen;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.ComboBox comboBoxZimmerTyp;
        private System.Windows.Forms.ComboBox comboBoxTerrasseBalkon;
        private System.Windows.Forms.CheckBox checkBoxKühlschrank;
        private System.Windows.Forms.CheckBox checkBoxFernseher;
        private System.Windows.Forms.CheckBox checkBoxHauptrasse;
        public System.Windows.Forms.DateTimePicker dateTimePickerDatum;
    }
}