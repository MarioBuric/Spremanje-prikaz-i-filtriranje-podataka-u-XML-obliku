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
    public partial class FiltriranjePodataka : Form
    {
        public FiltriranjePodataka()
        {
            InitializeComponent();
        }

        private void btnodustani_Click(object sender, EventArgs e)
        {
            PregledPodataka pregledPodataka = new PregledPodataka();
            this.Hide();
            pregledPodataka.ShowDialog();
            this.Close();
        }

        private void btnfiltriraj_Click(object sender, EventArgs e)
        {

        }
    }
}
