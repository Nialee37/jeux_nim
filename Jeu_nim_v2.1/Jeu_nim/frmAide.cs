﻿using System;
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
    public partial class frmAide : Form
    {
        public frmAide()
        {
            InitializeComponent();
        }
        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
