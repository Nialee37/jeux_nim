using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_nim
{
    public partial class frmNim : Form
    {
        public frmNim()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            frmAide frmAide = new frmAide();
            frmAide.Show();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            Jeu Jeu = new Jeu();
            Jeu.Show();
        }
    }
}
