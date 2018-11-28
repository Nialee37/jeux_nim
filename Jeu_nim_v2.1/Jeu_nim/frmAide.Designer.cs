namespace Jeu_nim
{
    partial class frmAide
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
            this.lblAide = new System.Windows.Forms.Label();
            this.Aide = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnquitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAide
            // 
            this.lblAide.AutoSize = true;
            this.lblAide.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAide.Location = new System.Drawing.Point(144, 25);
            this.lblAide.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAide.Name = "lblAide";
            this.lblAide.Size = new System.Drawing.Size(51, 22);
            this.lblAide.TabIndex = 0;
            this.lblAide.Text = "Aide";
            // 
            // Aide
            // 
            this.Aide.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aide.ForeColor = System.Drawing.Color.SteelBlue;
            this.Aide.Location = new System.Drawing.Point(52, 47);
            this.Aide.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Aide.Name = "Aide";
            this.Aide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Aide.Size = new System.Drawing.Size(231, 51);
            this.Aide.TabIndex = 2;
            this.Aide.Text = "Chaque joueur, à son tour peut enlever entre 1 et 3 crayons";
            this.Aide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Aide.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(296, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Le gagnant est celui qui prend le dernier crayons";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Jeu_nim.Properties.Resources.font_menu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 171);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnquitter
            // 
            this.btnquitter.BackgroundImage = global::Jeu_nim.Properties.Resources.porte;
            this.btnquitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnquitter.Location = new System.Drawing.Point(148, 236);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(47, 44);
            this.btnquitter.TabIndex = 6;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // frmAide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(338, 292);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Aide);
            this.Controls.Add(this.lblAide);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmAide";
            this.Text = "frmAide";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAide;
        private System.Windows.Forms.Label Aide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnquitter;
    }
}