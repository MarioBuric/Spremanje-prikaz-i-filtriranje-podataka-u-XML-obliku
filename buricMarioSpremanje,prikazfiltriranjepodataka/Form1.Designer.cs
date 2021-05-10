namespace buricMarioSpremanje_prikazfiltriranjepodataka
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
            this.btnprikaz = new System.Windows.Forms.Button();
            this.btnunos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnprikaz
            // 
            this.btnprikaz.Location = new System.Drawing.Point(42, 211);
            this.btnprikaz.Name = "btnprikaz";
            this.btnprikaz.Size = new System.Drawing.Size(75, 23);
            this.btnprikaz.TabIndex = 3;
            this.btnprikaz.Text = "Prikaz";
            this.btnprikaz.UseVisualStyleBackColor = true;
            this.btnprikaz.Click += new System.EventHandler(this.btnprikaz_Click);
            // 
            // btnunos
            // 
            this.btnunos.Location = new System.Drawing.Point(42, 165);
            this.btnunos.Name = "btnunos";
            this.btnunos.Size = new System.Drawing.Size(75, 23);
            this.btnunos.TabIndex = 2;
            this.btnunos.Text = "Unos";
            this.btnunos.UseVisualStyleBackColor = true;
            this.btnunos.Click += new System.EventHandler(this.btnunos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 255);
            this.Controls.Add(this.btnprikaz);
            this.Controls.Add(this.btnunos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnprikaz;
        private System.Windows.Forms.Button btnunos;
    }
}

