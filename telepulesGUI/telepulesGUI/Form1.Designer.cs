namespace telepulesGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.teruletiEgysegNeveLbox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.minKozsegszam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minVarosszam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Válaszd ki a területi egység típusát";
            // 
            // teruletiEgysegNeveLbox
            // 
            this.teruletiEgysegNeveLbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.teruletiEgysegNeveLbox.FormattingEnabled = true;
            this.teruletiEgysegNeveLbox.Location = new System.Drawing.Point(287, 21);
            this.teruletiEgysegNeveLbox.Name = "teruletiEgysegNeveLbox";
            this.teruletiEgysegNeveLbox.Size = new System.Drawing.Size(274, 28);
            this.teruletiEgysegNeveLbox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(7, 286);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(781, 164);
            this.listBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Válaszd ki a minimális községszámot";
            // 
            // minKozsegszam
            // 
            this.minKozsegszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.minKozsegszam.FormattingEnabled = true;
            this.minKozsegszam.Location = new System.Drawing.Point(307, 81);
            this.minKozsegszam.Name = "minKozsegszam";
            this.minKozsegszam.Size = new System.Drawing.Size(274, 28);
            this.minKozsegszam.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Válaszd ki a minimális városszámot";
            // 
            // minVarosszam
            // 
            this.minVarosszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.minVarosszam.FormattingEnabled = true;
            this.minVarosszam.Location = new System.Drawing.Point(307, 140);
            this.minVarosszam.Name = "minVarosszam";
            this.minVarosszam.Size = new System.Drawing.Size(274, 28);
            this.minVarosszam.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minVarosszam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minKozsegszam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.teruletiEgysegNeveLbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "telepulesGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teruletiEgysegNeveLbox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox minKozsegszam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox minVarosszam;
    }
}

