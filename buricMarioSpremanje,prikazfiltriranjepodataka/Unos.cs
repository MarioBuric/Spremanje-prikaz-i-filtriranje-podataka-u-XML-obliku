using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace buricMarioSpremanje_prikazfiltriranjepodataka
{
    public partial class Unos : Form
    {
        List<Ucenik> listaUcenika = new List<Ucenik>();
        public Unos()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtime.Text) || string.IsNullOrEmpty(txtprezime.Text) || string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(cmbrazred.Text))
            {
                MessageBox.Show("Fale podaci", "Greška");
                return;
            }

            Ucenik ucenik = new Ucenik(txtime.Text, txtprezime.Text, txtemail.Text, cmbrazred.Text);
            listaUcenika.Add(ucenik);

            txtime.Clear();
            txtprezime.Clear();
            txtemail.Clear();
            cmbrazred.Text = " ";
        }

        private void btnzavrsi_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\Documents\xmlDokument"))
            {
                Directory.CreateDirectory(@"C:\Documents\xmlDokument");
            }

            var dokumentXmlUcenici = new XDocument(new XElement("listaUcenika",
                    from Ucenik in listaUcenika
                    select new XElement("Ucenik",
                        new XAttribute("Ime", Ucenik.Ime),
                        new XAttribute("Prezime", Ucenik.Prezime),
                        new XAttribute("EmailAdresa", Ucenik.Email),
                        new XAttribute("Razred", Ucenik.Razred)
                        )));

            dokumentXmlUcenici.Save("C:/Documents/xmlDokument/Unos.xml");

            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
