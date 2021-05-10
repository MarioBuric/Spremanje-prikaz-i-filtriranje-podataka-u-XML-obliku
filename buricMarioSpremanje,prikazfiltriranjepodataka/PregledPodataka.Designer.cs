namespace buricMarioSpremanje_prikazfiltriranjepodataka
{
    partial class PregledPodataka
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnodustani = new System.Windows.Forms.Button();
            this.btnfiltriraj = new System.Windows.Forms.Button();
            this.btnucitaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(328, 361);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // btnodustani
            // 
            this.btnodustani.Location = new System.Drawing.Point(232, 12);
            this.btnodustani.Name = "btnodustani";
            this.btnodustani.Size = new System.Drawing.Size(108, 23);
            this.btnodustani.TabIndex = 6;
            this.btnodustani.Text = "Odustani";
            this.btnodustani.UseVisualStyleBackColor = true;
            this.btnodustani.Click += new System.EventHandler(this.btnodustani_Click);
            // 
            // btnfiltriraj
            // 
            this.btnfiltriraj.Location = new System.Drawing.Point(120, 12);
            this.btnfiltriraj.Name = "btnfiltriraj";
            this.btnfiltriraj.Size = new System.Drawing.Size(106, 23);
            this.btnfiltriraj.TabIndex = 5;
            this.btnfiltriraj.Text = "Filtriraj";
            this.btnfiltriraj.UseVisualStyleBackColor = true;
            this.btnfiltriraj.Click += new System.EventHandler(this.btnfiltriraj_Click);
            // 
            // btnucitaj
            // 
            this.btnucitaj.Location = new System.Drawing.Point(12, 12);
            this.btnucitaj.Name = "btnucitaj";
            this.btnucitaj.Size = new System.Drawing.Size(102, 23);
            this.btnucitaj.TabIndex = 4;
            this.btnucitaj.Text = "Učitaj dokument";
            this.btnucitaj.UseVisualStyleBackColor = true;
            this.btnucitaj.Click += new System.EventHandler(this.btnucitaj_Click);
            // 
            // PregledPodataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnodustani);
            this.Controls.Add(this.btnfiltriraj);
            this.Controls.Add(this.btnucitaj);
            this.Name = "PregledPodataka";
            this.Text = "PregledPodataka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnodustani;
        private System.Windows.Forms.Button btnfiltriraj;
        private System.Windows.Forms.Button btnucitaj;
    }
}