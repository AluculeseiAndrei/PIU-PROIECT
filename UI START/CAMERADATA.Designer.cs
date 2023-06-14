namespace UI_START
{
    partial class CAMERADATA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.acasa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nrcam = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Pret = new System.Windows.Forms.Label();
            this.Frigider = new System.Windows.Forms.Label();
            this.Vedere = new System.Windows.Forms.Label();
            this.Ac = new System.Windows.Forms.Label();
            this.Televizor = new System.Windows.Forms.Label();
            this.Nrpers = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.acasa);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 826);
            this.panel1.TabIndex = 0;
            // 
            // acasa
            // 
            this.acasa.BackColor = System.Drawing.SystemColors.Info;
            this.acasa.Location = new System.Drawing.Point(26, 29);
            this.acasa.Name = "acasa";
            this.acasa.Size = new System.Drawing.Size(108, 23);
            this.acasa.TabIndex = 0;
            this.acasa.Text = "Acasa";
            this.acasa.UseVisualStyleBackColor = false;
            this.acasa.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(931, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Terasa";
            // 
            // Nrcam
            // 
            this.Nrcam.AutoSize = true;
            this.Nrcam.Location = new System.Drawing.Point(285, 84);
            this.Nrcam.Name = "Nrcam";
            this.Nrcam.Size = new System.Drawing.Size(43, 13);
            this.Nrcam.TabIndex = 9;
            this.Nrcam.Text = "Camera";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(817, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bucatarie";
            // 
            // Pret
            // 
            this.Pret.AutoSize = true;
            this.Pret.Location = new System.Drawing.Point(372, 84);
            this.Pret.Name = "Pret";
            this.Pret.Size = new System.Drawing.Size(26, 13);
            this.Pret.TabIndex = 10;
            this.Pret.Text = "Pret";
            // 
            // Frigider
            // 
            this.Frigider.AutoSize = true;
            this.Frigider.Location = new System.Drawing.Point(722, 84);
            this.Frigider.Name = "Frigider";
            this.Frigider.Size = new System.Drawing.Size(41, 13);
            this.Frigider.TabIndex = 14;
            this.Frigider.Text = "Frigider";
            // 
            // Vedere
            // 
            this.Vedere.AutoSize = true;
            this.Vedere.Location = new System.Drawing.Point(457, 84);
            this.Vedere.Name = "Vedere";
            this.Vedere.Size = new System.Drawing.Size(41, 13);
            this.Vedere.TabIndex = 11;
            this.Vedere.Text = "Vedere";
            // 
            // Ac
            // 
            this.Ac.AutoSize = true;
            this.Ac.Location = new System.Drawing.Point(646, 84);
            this.Ac.Name = "Ac";
            this.Ac.Size = new System.Drawing.Size(27, 13);
            this.Ac.TabIndex = 13;
            this.Ac.Text = "A.C.";
            // 
            // Televizor
            // 
            this.Televizor.AutoSize = true;
            this.Televizor.Location = new System.Drawing.Point(545, 84);
            this.Televizor.Name = "Televizor";
            this.Televizor.Size = new System.Drawing.Size(50, 13);
            this.Televizor.TabIndex = 12;
            this.Televizor.Text = "Televizor";
            // 
            // Nrpers
            // 
            this.Nrpers.AutoSize = true;
            this.Nrpers.Location = new System.Drawing.Point(1024, 84);
            this.Nrpers.Name = "Nrpers";
            this.Nrpers.Size = new System.Drawing.Size(65, 13);
            this.Nrpers.TabIndex = 17;
            this.Nrpers.Text = "Nr.persoane";
            // 
            // CAMERADATA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1163, 569);
            this.Controls.Add(this.Nrpers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nrcam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Pret);
            this.Controls.Add(this.Frigider);
            this.Controls.Add(this.Vedere);
            this.Controls.Add(this.Ac);
            this.Controls.Add(this.Televizor);
            this.Controls.Add(this.panel1);
            this.Name = "CAMERADATA";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button acasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nrcam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Pret;
        private System.Windows.Forms.Label Frigider;
        private System.Windows.Forms.Label Vedere;
        private System.Windows.Forms.Label Ac;
        private System.Windows.Forms.Label Televizor;
        private System.Windows.Forms.Label Nrpers;
    }
}