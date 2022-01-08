
namespace Verwaltungstool.Forms.GästeForms
{
    partial class GastForm
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
            this.labelLangerName = new System.Windows.Forms.Label();
            this.groupBoxAdresse = new System.Windows.Forms.GroupBox();
            this.groupBoxPersönlich = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNachname = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStraßeHr = new System.Windows.Forms.Label();
            this.labelPLZ = new System.Windows.Forms.Label();
            this.labelOrt = new System.Windows.Forms.Label();
            this.buttonZurück = new System.Windows.Forms.Button();
            this.groupBoxAdresse.SuspendLayout();
            this.groupBoxPersönlich.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLangerName
            // 
            this.labelLangerName.AutoSize = true;
            this.labelLangerName.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLangerName.Location = new System.Drawing.Point(13, 13);
            this.labelLangerName.Name = "labelLangerName";
            this.labelLangerName.Size = new System.Drawing.Size(81, 33);
            this.labelLangerName.TabIndex = 0;
            this.labelLangerName.Text = "label1";
            // 
            // groupBoxAdresse
            // 
            this.groupBoxAdresse.Controls.Add(this.labelOrt);
            this.groupBoxAdresse.Controls.Add(this.labelPLZ);
            this.groupBoxAdresse.Controls.Add(this.labelStraßeHr);
            this.groupBoxAdresse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdresse.Location = new System.Drawing.Point(19, 174);
            this.groupBoxAdresse.Name = "groupBoxAdresse";
            this.groupBoxAdresse.Size = new System.Drawing.Size(197, 86);
            this.groupBoxAdresse.TabIndex = 1;
            this.groupBoxAdresse.TabStop = false;
            this.groupBoxAdresse.Text = "Adresse";
            // 
            // groupBoxPersönlich
            // 
            this.groupBoxPersönlich.Controls.Add(this.labelEmail);
            this.groupBoxPersönlich.Controls.Add(this.labelNachname);
            this.groupBoxPersönlich.Controls.Add(this.labelName);
            this.groupBoxPersönlich.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPersönlich.Location = new System.Drawing.Point(16, 80);
            this.groupBoxPersönlich.Name = "groupBoxPersönlich";
            this.groupBoxPersönlich.Size = new System.Drawing.Size(200, 88);
            this.groupBoxPersönlich.TabIndex = 2;
            this.groupBoxPersönlich.TabStop = false;
            this.groupBoxPersönlich.Text = "Persönliche Daten";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Location = new System.Drawing.Point(3, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            // 
            // labelNachname
            // 
            this.labelNachname.AutoSize = true;
            this.labelNachname.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNachname.Location = new System.Drawing.Point(3, 42);
            this.labelNachname.Name = "labelNachname";
            this.labelNachname.Size = new System.Drawing.Size(49, 19);
            this.labelNachname.TabIndex = 1;
            this.labelNachname.Text = "label2";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEmail.Location = new System.Drawing.Point(3, 61);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 19);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "label3";
            // 
            // labelStraßeHr
            // 
            this.labelStraßeHr.AutoSize = true;
            this.labelStraßeHr.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelStraßeHr.Location = new System.Drawing.Point(3, 23);
            this.labelStraßeHr.Name = "labelStraßeHr";
            this.labelStraßeHr.Size = new System.Drawing.Size(49, 19);
            this.labelStraßeHr.TabIndex = 0;
            this.labelStraßeHr.Text = "label1";
            // 
            // labelPLZ
            // 
            this.labelPLZ.AutoSize = true;
            this.labelPLZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPLZ.Location = new System.Drawing.Point(3, 42);
            this.labelPLZ.Name = "labelPLZ";
            this.labelPLZ.Size = new System.Drawing.Size(49, 19);
            this.labelPLZ.TabIndex = 1;
            this.labelPLZ.Text = "label2";
            // 
            // labelOrt
            // 
            this.labelOrt.AutoSize = true;
            this.labelOrt.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOrt.Location = new System.Drawing.Point(3, 61);
            this.labelOrt.Name = "labelOrt";
            this.labelOrt.Size = new System.Drawing.Size(49, 19);
            this.labelOrt.TabIndex = 2;
            this.labelOrt.Text = "label3";
            // 
            // buttonZurück
            // 
            this.buttonZurück.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZurück.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZurück.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZurück.Location = new System.Drawing.Point(713, 448);
            this.buttonZurück.Name = "buttonZurück";
            this.buttonZurück.Size = new System.Drawing.Size(75, 25);
            this.buttonZurück.TabIndex = 7;
            this.buttonZurück.Text = "Zurück";
            this.buttonZurück.UseVisualStyleBackColor = true;
            this.buttonZurück.Click += new System.EventHandler(this.ButtonZurück_Click);
            // 
            // GastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.buttonZurück);
            this.Controls.Add(this.groupBoxPersönlich);
            this.Controls.Add(this.groupBoxAdresse);
            this.Controls.Add(this.labelLangerName);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GastForm";
            this.Text = "Gastformular";
            this.groupBoxAdresse.ResumeLayout(false);
            this.groupBoxAdresse.PerformLayout();
            this.groupBoxPersönlich.ResumeLayout(false);
            this.groupBoxPersönlich.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLangerName;
        private System.Windows.Forms.GroupBox groupBoxAdresse;
        private System.Windows.Forms.GroupBox groupBoxPersönlich;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNachname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelOrt;
        private System.Windows.Forms.Label labelPLZ;
        private System.Windows.Forms.Label labelStraßeHr;
        private System.Windows.Forms.Button buttonZurück;
    }
}