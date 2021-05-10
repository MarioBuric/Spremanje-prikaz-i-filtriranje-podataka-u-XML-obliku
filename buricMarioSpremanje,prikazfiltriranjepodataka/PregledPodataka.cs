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

namespace buricMarioSpremanje_prikazfiltriranjepodataka
{
    public partial class PregledPodataka : Form
    {
        public PregledPodataka()
        {
            InitializeComponent();
        }

        private void btnucitaj_Click(object sender, EventArgs e)
        {
            
        }

        private void btnodustani_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void btnfiltriraj_Click(object sender, EventArgs e)
        {
            FiltriranjePodataka filtriranjePodataka = new FiltriranjePodataka();
            this.Hide();
            filtriranjePodataka.ShowDialog();
            this.Close();
        }
    }
}
