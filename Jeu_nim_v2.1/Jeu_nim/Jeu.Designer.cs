namespace Jeu_nim
{
    partial class Jeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jeu));
            this.btnValider = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAide = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnValider.Location = new System.Drawing.Point(897, 426);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(140, 43);
            this.btnValider.TabIndex = 22;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Jeu_nim.Properties.Resources.rejouer;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(929, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 49);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAide
            // 
            this.btnAide.BackColor = System.Drawing.Color.Transparent;
            this.btnAide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAide.BackgroundImage")));
            this.btnAide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAide.ForeColor = System.Drawing.Color.Transparent;
            this.btnAide.Location = new System.Drawing.Point(513, 516);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(30, 40);
            this.btnAide.TabIndex = 21;
            this.btnAide.UseVisualStyleBackColor = false;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = global::Jeu_nim.Properties.Resources.porte;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitter.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(986, 507);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(51, 49);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1052, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.btnQuitter);
            this.Name = "Jeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu";
            this.Load += new System.EventHandler(this.Jeu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button button1;
    }
}