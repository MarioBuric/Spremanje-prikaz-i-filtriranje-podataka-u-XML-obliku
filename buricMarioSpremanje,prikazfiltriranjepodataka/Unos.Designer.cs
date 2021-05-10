namespace buricMarioSpremanje_prikazfiltriranjepodataka
{
    partial class Unos
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
            this.btnzavrsi = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.cmbrazred = new System.Windows.Forms.ComboBox();
            this.txtprezime = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtime = new System.Windows.Forms.TextBox();
            this.lblrazred = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblprezime = new System.Windows.Forms.Label();
            this.lblime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnzavrsi
            // 
            this.btnzavrsi.Location = new System.Drawing.Point(75, 313);
            this.btnzavrsi.Name = "btnzavrsi";
            this.btnzavrsi.Size = new System.Drawing.Size(75, 23);
            this.btnzavrsi.TabIndex = 19;
            this.btnzavrsi.Text = "Završi";
            this.btnzavrsi.UseVisualStyleBackColor = true;
            this.btnzavrsi.Click += new System.EventHandler(this.btnzavrsi_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(75, 272);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 18;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
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
            this.cmbrazred.Location = new System.Drawing.Point(50, 227);
            this.cmbrazred.Name = "cmbrazred";
            this.cmbrazred.Size = new System.Drawing.Size(121, 21);
            this.cmbrazred.TabIndex = 17;
            // 
            // txtprezime
            // 
            this.txtprezime.Location = new System.Drawing.Point(50, 102);
            this.txtprezime.Name = "txtprezime";
            this.txtprezime.Size = new System.Drawing.Size(100, 20);
            this.txtprezime.TabIndex = 16;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(50, 155);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 15;
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(50, 50);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(100, 20);
            this.txtime.TabIndex = 14;
            // 
            // lblrazred
            // 
            this.lblrazred.AutoSize = true;
            this.lblrazred.Location = new System.Drawing.Point(47, 192);
            this.lblrazred.Name = "lblrazred";
            this.lblrazred.Size = new System.Drawing.Size(41, 13);
            this.lblrazred.TabIndex = 13;
            this.lblrazred.Text = "Razred";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(47, 139);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 12;
            this.lblemail.Text = "E-mail";
            // 
            // lblprezime
            // 
            this.lblprezime.AutoSize = true;
            this.lblprezime.Location = new System.Drawing.Point(47, 83);
            this.lblprezime.Name = "lblprezime";
            this.lblprezime.Size = new System.Drawing.Size(44, 13);
            this.lblprezime.TabIndex = 11;
            this.lblprezime.Text = "Prezime";
            // 
            // lblime
            // 
            this.lblime.AutoSize = true;
            this.lblime.Location = new System.Drawing.Point(47, 34);
            this.lblime.Name = "lblime";
            this.lblime.Size = new System.Drawing.Size(24, 13);
            this.lblime.TabIndex = 10;
            this.lblime.Text = "Ime";
            // 
            // Unos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnzavrsi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.cmbrazred);
            this.Controls.Add(this.txtprezime);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtime);
            this.Controls.Add(this.lblrazred);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblprezime);
            this.Controls.Add(this.lblime);
            this.Name = "Unos";
            this.Text = "Unos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnzavrsi;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.ComboBox cmbrazred;
        private System.Windows.Forms.TextBox txtprezime;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.Label lblrazred;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblprezime;
        private System.Windows.Forms.Label lblime;
    }
}