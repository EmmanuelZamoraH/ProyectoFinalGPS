
namespace ITSUR
{
    partial class Agregar
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
            this.txtNombLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarLib = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombLibro
            // 
            this.txtNombLibro.Location = new System.Drawing.Point(209, 73);
            this.txtNombLibro.Name = "txtNombLibro";
            this.txtNombLibro.Size = new System.Drawing.Size(163, 26);
            this.txtNombLibro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del autor:";
            // 
            // txtNombAutor
            // 
            this.txtNombAutor.Location = new System.Drawing.Point(210, 126);
            this.txtNombAutor.Name = "txtNombAutor";
            this.txtNombAutor.Size = new System.Drawing.Size(162, 26);
            this.txtNombAutor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Programación",
            "Matematicas",
            "Ingles",
            "Historia"});
            this.cbCategoria.Location = new System.Drawing.Point(210, 182);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(162, 28);
            this.cbCategoria.TabIndex = 6;
            // 
            // btnAgregarLib
            // 
            this.btnAgregarLib.Location = new System.Drawing.Point(254, 228);
            this.btnAgregarLib.Name = "btnAgregarLib";
            this.btnAgregarLib.Size = new System.Drawing.Size(83, 35);
            this.btnAgregarLib.TabIndex = 7;
            this.btnAgregarLib.Text = "Agregar";
            this.btnAgregarLib.UseVisualStyleBackColor = true;
            this.btnAgregarLib.Click += new System.EventHandler(this.btnAgregarLib_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ITSUR.Properties.Resources.regresar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 51);
            this.button2.TabIndex = 32;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 302);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAgregarLib);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombLibro);
            this.Name = "Agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnAgregarLib;
        private System.Windows.Forms.Button button2;
    }
}