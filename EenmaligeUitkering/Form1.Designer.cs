namespace EenmaligeUitkering
{
    partial class Form1
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
            this.chbGetrouwd = new System.Windows.Forms.CheckBox();
            this.dtpGeboorteDatum = new System.Windows.Forms.DateTimePicker();
            this.txbSalaris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chbGetrouwd
            // 
            this.chbGetrouwd.AutoSize = true;
            this.chbGetrouwd.Location = new System.Drawing.Point(12, 8);
            this.chbGetrouwd.Name = "chbGetrouwd";
            this.chbGetrouwd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbGetrouwd.Size = new System.Drawing.Size(72, 17);
            this.chbGetrouwd.TabIndex = 0;
            this.chbGetrouwd.Text = "Getrouwd";
            this.chbGetrouwd.UseVisualStyleBackColor = true;
            // 
            // dtpGeboorteDatum
            // 
            this.dtpGeboorteDatum.Location = new System.Drawing.Point(107, 33);
            this.dtpGeboorteDatum.Name = "dtpGeboorteDatum";
            this.dtpGeboorteDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpGeboorteDatum.TabIndex = 1;
            // 
            // txbSalaris
            // 
            this.txbSalaris.Location = new System.Drawing.Point(139, 61);
            this.txbSalaris.Name = "txbSalaris";
            this.txbSalaris.Size = new System.Drawing.Size(168, 20);
            this.txbSalaris.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Geboorte datum: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Totaal salaris vorig jaar: ";
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(12, 92);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(43, 13);
            this.lblTotaal.TabIndex = 5;
            this.lblTotaal.Text = "Totaal: ";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(232, 4);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 6;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 120);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lblTotaal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSalaris);
            this.Controls.Add(this.dtpGeboorteDatum);
            this.Controls.Add(this.chbGetrouwd);
            this.Name = "Form1";
            this.Text = "Uitkering berekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbGetrouwd;
        private System.Windows.Forms.DateTimePicker dtpGeboorteDatum;
        private System.Windows.Forms.TextBox txbSalaris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Button btnBereken;
    }
}

