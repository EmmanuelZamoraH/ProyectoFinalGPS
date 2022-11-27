
namespace ITSUR
{
    partial class Inicio
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
            System.Windows.Forms.Button btnRentar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCatalgo = new System.Windows.Forms.Button();
            btnRentar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRentar
            // 
            btnRentar.BackColor = System.Drawing.Color.White;
            btnRentar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnRentar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRentar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            btnRentar.FlatAppearance.BorderSize = 2;
            btnRentar.Image = ((System.Drawing.Image)(resources.GetObject("btnRentar.Image")));
            btnRentar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            btnRentar.Location = new System.Drawing.Point(159, 299);
            btnRentar.Name = "btnRentar";
            btnRentar.Size = new System.Drawing.Size(138, 49);
            btnRentar.TabIndex = 3;
            btnRentar.Text = "Rentar Libro";
            btnRentar.UseVisualStyleBackColor = false;
            btnRentar.Click += new System.EventHandler(this.btnRentar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITSUR.Properties.Resources.cent_idiomas_somb;
            this.pictureBox1.Location = new System.Drawing.Point(144, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnCatalgo
            // 
            this.btnCatalgo.BackColor = System.Drawing.Color.White;
            this.btnCatalgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCatalgo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalgo.FlatAppearance.BorderSize = 2;
            this.btnCatalgo.Location = new System.Drawing.Point(159, 378);
            this.btnCatalgo.Name = "btnCatalgo";
            this.btnCatalgo.Size = new System.Drawing.Size(138, 49);
            this.btnCatalgo.TabIndex = 4;
            this.btnCatalgo.Text = "Catalogo Libros";
            this.btnCatalgo.UseVisualStyleBackColor = false;
            this.btnCatalgo.Click += new System.EventHandler(this.btnCatalgo_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(460, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCatalgo);
            this.Controls.Add(btnRentar);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCatalgo;
    }
}