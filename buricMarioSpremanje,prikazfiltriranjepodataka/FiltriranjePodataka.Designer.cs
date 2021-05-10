namespace buricMarioSpremanje_prikazfiltriranjepodataka
{
    partial class FiltriranjePodataka
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
            this.cmbrazred = new System.Windows.Forms.ComboBox();
            this.txtprezime = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtime = new System.Windows.Forms.TextBox();
            this.lblrazred = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblprezime = new System.Windows.Forms.Label();
            this.lblime = new System.Windows.Forms.Label();
            this.btnodustani = new System.Windows.Forms.Button();
            this.btnfiltriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbrazred
            // 
            this.cmbrazred.FormattingEnabled = true;
            this.cmbrazred.Items.AddRange(new object[] {
            "1.A",
            "1.B",
            "1.C",
            "1.D",
            "2.A",
            "2.B",
            "2.C",
            "2.D",
            "3.A",
            "3.B",
            "3.C",
            "3.D",
            "4.A",
            "4.B",
            "4.C",
            "4.D"});
            this.cmbrazred.Location = new System.Drawing.Point(108, 272);
            this.cmbrazred.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbrazred.Name = "cmbrazred";
            this.cmbrazred.Size = new System.Drawing.Size(160, 24);
            this.cmbrazred.TabIndex = 25;
            // 
            // txtprezime
            // 
            this.txtprezime.Location = new System.Drawing.Point(108, 118);
            this.txtprezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprezime.Name = "txtprezime";
            this.txtprezime.Size = new System.Drawing.Size(132, 22);
            this.txtprezime.TabIndex = 24;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(108, 183);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(132, 22);
            this.txtemail.TabIndex = 23;
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(108, 54);
            this.txtime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(132, 22);
            this.txtime.TabIndex = 22;
            // 
            // lblrazred
            // 
            this.lblrazred.AutoSize = true;
            this.lblrazred.Location = new System.Drawing.Point(104, 229);
            this.lblrazred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrazred.Name = "lblrazred";
            this.lblrazred.Size = new System.Drawing.Size(54, 17);
            this.lblrazred.TabIndex = 21;
            this.lblrazred.Text = "Razred";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(104, 164);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(47, 17);
            this.lblemail.TabIndex = 20;
            this.lblemail.Text = "E-mail";
            // 
            // lblprezime
            // 
            this.lblprezime.AutoSize = true;
            this.lblprezime.Location = new System.Drawing.Point(104, 95);
            this.lblprezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprezime.Name = "lblprezime";
            this.lblprezime.Size = new System.Drawing.Size(59, 17);
            this.lblprezime.TabIndex = 19;
            this.lblprezime.Text = "Prezime";
            // 
            // lblime
            // 
            this.lblime.AutoSize = true;
            this.lblime.Location = new System.Drawing.Point(104, 34);
            this.lblime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblime.Name = "lblime";
            this.lblime.Size = new System.Drawing.Size(30, 17);
            this.lblime.TabIndex = 18;
            this.lblime.Text = "Ime";
            // 
            // btnodustani
            // 
            this.btnodustani.Location = new System.Drawing.Point(108, 409);
            this.btnodustani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnodustani.Name = "btnodustani";
            this.btnodustani.Size = new System.Drawing.Size(100, 28);
            this.btnodustani.TabIndex = 27;
            this.btnodustani.Text = "Odustani";
            this.btnodustani.UseVisualStyleBackColor = true;
            this.btnodustani.Click += new System.EventHandler(this.btnodustani_Click);
            // 
            // btnfiltriraj
            // 
            this.btnfiltriraj.Location = new System.Drawing.Point(108, 338);
            this.btnfiltriraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfiltriraj.Name = "btnfiltriraj";
            this.btnfiltriraj.Size = new System.Drawing.Size(100, 28);
            this.btnfiltriraj.TabIndex = 26;
            this.btnfiltriraj.Text = "Filtriraj";
            this.btnfiltriraj.UseVisualStyleBackColor = true;
            this.btnfiltriraj.Click += new System.EventHandler(this.btnfiltriraj_Click);
            // 
            // FiltriranjePodataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnodustani);
            this.Controls.Add(this.btnfiltriraj);
            this.Controls.Add(this.cmbrazred);
            this.Controls.Add(this.txtprezime);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtime);
            this.Controls.Add(this.lblrazred);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblprezime);
            this.Controls.Add(this.lblime);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FiltriranjePodataka";
            this.Text = "FiltriranjePodataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbrazred;
        private System.Windows.Forms.TextBox txtprezime;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.Label lblrazred;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblprezime;
        private System.Windows.Forms.Label lblime;
        private System.Windows.Forms.Button btnodustani;
        private System.Windows.Forms.Button btnfiltriraj;
    }
}