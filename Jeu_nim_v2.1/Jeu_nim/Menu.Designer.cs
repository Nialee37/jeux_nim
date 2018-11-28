namespace Jeu_nim
{
    partial class frmNim
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNim));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAide = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnJouer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Jeu_nim.Properties.Resources.Jeu_de_Nim;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(70, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 52);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Jeu_nim.Properties.Resources.font_menu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 171);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnAide
            // 
            this.btnAide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAide.BackgroundImage")));
            this.btnAide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAide.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAide.Location = new System.Drawing.Point(164, 128);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(30, 44);
            this.btnAide.TabIndex = 3;
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuitter.BackgroundImage = global::Jeu_nim.Properties.Resources.porte;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuitter.Location = new System.Drawing.Point(275, 128);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(49, 42);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnJouer
            // 
            this.btnJouer.BackColor = System.Drawing.Color.Transparent;
            this.btnJouer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJouer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJouer.FlatAppearance.BorderSize = 0;
            this.btnJouer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouer.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnJouer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJouer.Location = new System.Drawing.Point(12, 128);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(104, 39);
            this.btnJouer.TabIndex = 1;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJouer.UseVisualStyleBackColor = false;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // frmNim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(336, 318);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnJouer);
            this.DoubleBuffered = true;
            this.Name = "frmNim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu de Nim";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

