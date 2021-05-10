using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buricMarioSpremanje_prikazfiltriranjepodataka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnunos_Click(object sender, EventArgs e)
        {
            Unos unos = new Unos();
            this.Hide();
            unos.ShowDialog();
            this.Close();
        }

        private void btnprikaz_Click(object sender, EventArgs e)
        {
            PregledPodataka pregledPodataka = new PregledPodataka();
            this.Hide();
            pregledPodataka.ShowDialog();
            this.Close();
        }
    }
}
