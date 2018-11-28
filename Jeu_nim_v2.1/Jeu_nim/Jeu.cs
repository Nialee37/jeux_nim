using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//using System.Random;



namespace Jeu_nim
{
    public partial class Jeu : Form
    {
        public Jeu()
        {
            InitializeComponent();
        }

        #region btn Quitter
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region btn Aide
        private void btnAide_Click(object sender, EventArgs e)
        {
            frmAide frmAide = new frmAide();
            frmAide.Show();
        }
        #endregion

        private void Jeu_Load(object sender, EventArgs e)
        {
            int top = 150;
            int left = 100;
           string[] couleurs = new string[] { "jaune", "blanc", "bleu clair", "bleu", "cyan", "gris", "marron", "noir", "orange", "rose", "rouge pastel", "rouge", "vert", "violet pastel", "violet" };

            //génération des 15 boutons via une boucle
            for (int i = 0; i < 15; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Width = 50;
                button.Height = 200;
                button.BackgroundImage = Image.FromFile("./Resources/" + couleurs[i] + ".png");
                button.BackgroundImageLayout= ImageLayout.Stretch;
                button.Name = "N" + (i+1);
                button.Click += Button_Click;
                button.Tag = "Dispo";
                this.Controls.Add(button);
                left += button.Width + 2;
            }

        }
        int choix = 0;
        private void Button_Click(object sender, EventArgs e)
        {
            choix ++;
            while(choix>3)
            {
                MessageBox.Show("seulement 3 crayons peuvent étre choisis au maximum ");                
                return;
            }
            Button btn = (Button)sender;
            //MessageBox.Show(btn.Name);
            btn.Tag = "Joueur";
            if (btn.Top == 150)
            {
                for (int i = 1; i < 51; i++)
                {
                    btn.Top = btn.Top + 3;
                    btn.Height = btn.Height - 1;
                    btn.Refresh();
                    Thread.Sleep(10);
                }
            }
            
        }
        int chOrdi = 0;
        private void btnValider_Click(object sender, EventArgs e)
        {
            List<Button> lstBtnCalc = this.Controls.OfType<Button>().Where(a => a.Name.StartsWith("N")).ToList();
            foreach (Button bouton in lstBtnCalc)
            {

                int rndCra;
                int nbLancer;
                Random RNG = new Random();
                rndCra = RNG.Next(1, 16);
                nbLancer = RNG.Next(1, 4);
               
                for(int i = 1; i < nbLancer; i++)
                {
                    Ordi("N" + rndCra.ToString());
                    //MessageBox.Show("N" + rndCra.ToString());
                    //MessageBox.Show(bouton.Name + " # " + bouton.Tag);
                    
                }
                if (chOrdi > 3)
                {
                    MessageBox.Show("toto");
                    return;
                }
            }
            choix++;
            if (chOrdi > 3)
            {
                MessageBox.Show("toto");
                return;
            }

        }
        private void Ordi(string Nom)
        {
            List<Button> lstBtnCalc = this.Controls.OfType<Button>().Where(a => a.Name.StartsWith("N")).ToList();
            foreach (Button bouton in lstBtnCalc)
            {
                if (bouton.Name == Nom)
                {
                    bouton.Tag = "Ordinateur";
                    for (int i = 1; i < 38; i++)
                    {
                        bouton.Top = bouton.Top - 3;
                        bouton.Height = bouton.Height - 1;
                        bouton.Refresh();
                        Thread.Sleep(10);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Jeu Jeu = new Jeu();
            Jeu.Show();
        }
    }
}
