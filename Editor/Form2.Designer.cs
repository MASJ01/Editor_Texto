namespace Editor
{
    partial class Form2
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
            this.LBL_EMPRESA = new System.Windows.Forms.Label();
            this.LBL_NOMBRE = new System.Windows.Forms.Label();
            this.LBL_DIRECCION = new System.Windows.Forms.Label();
            this.LBL_NUMERO = new System.Windows.Forms.Label();
            this.BTN_Acpetar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_EMPRESA
            // 
            this.LBL_EMPRESA.AutoSize = true;
            this.LBL_EMPRESA.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_EMPRESA.Location = new System.Drawing.Point(346, 21);
            this.LBL_EMPRESA.Name = "LBL_EMPRESA";
            this.LBL_EMPRESA.Size = new System.Drawing.Size(347, 32);
            this.LBL_EMPRESA.TabIndex = 0;
            this.LBL_EMPRESA.Text = "EDITORES Y ASOCIADOS";
            // 
            // LBL_NOMBRE
            // 
            this.LBL_NOMBRE.AutoSize = true;
            this.LBL_NOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NOMBRE.Location = new System.Drawing.Point(397, 84);
            this.LBL_NOMBRE.Name = "LBL_NOMBRE";
            this.LBL_NOMBRE.Size = new System.Drawing.Size(245, 20);
            this.LBL_NOMBRE.TabIndex = 1;
            this.LBL_NOMBRE.Text = "ALEXIS ZEPEDA SANABRIA";
            // 
            // LBL_DIRECCION
            // 
            this.LBL_DIRECCION.AutoSize = true;
            this.LBL_DIRECCION.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DIRECCION.Location = new System.Drawing.Point(265, 132);
            this.LBL_DIRECCION.Name = "LBL_DIRECCION";
            this.LBL_DIRECCION.Size = new System.Drawing.Size(524, 20);
            this.LBL_DIRECCION.TabIndex = 2;
            this.LBL_DIRECCION.Text = "Av. Independencia #185, Ba. de Guadalupe, San Mateo Atenco, México. ";
            // 
            // LBL_NUMERO
            // 
            this.LBL_NUMERO.AutoSize = true;
            this.LBL_NUMERO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NUMERO.Location = new System.Drawing.Point(427, 182);
            this.LBL_NUMERO.Name = "LBL_NUMERO";
            this.LBL_NUMERO.Size = new System.Drawing.Size(169, 20);
            this.LBL_NUMERO.TabIndex = 3;
            this.LBL_NUMERO.Text = "Telefono: 7226591892";
            // 
            // BTN_Acpetar
            // 
            this.BTN_Acpetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Acpetar.Location = new System.Drawing.Point(456, 463);
            this.BTN_Acpetar.Name = "BTN_Acpetar";
            this.BTN_Acpetar.Size = new System.Drawing.Size(108, 28);
            this.BTN_Acpetar.TabIndex = 5;
            this.BTN_Acpetar.Text = "ACEPTAR";
            this.BTN_Acpetar.UseVisualStyleBackColor = true;
            this.BTN_Acpetar.Click += new System.EventHandler(this.BTN_Acpetar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Editor.Properties.Resources.Editorlogo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Editor.Properties.Resources.signo_interrogacion;
            this.pictureBox1.Location = new System.Drawing.Point(411, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Editor.Properties.Resources.Editorlogo;
            this.pictureBox3.Location = new System.Drawing.Point(927, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AcceptButton = this.BTN_Acpetar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 520);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BTN_Acpetar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBL_NUMERO);
            this.Controls.Add(this.LBL_DIRECCION);
            this.Controls.Add(this.LBL_NOMBRE);
            this.Controls.Add(this.LBL_EMPRESA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_EMPRESA;
        private System.Windows.Forms.Label LBL_NOMBRE;
        private System.Windows.Forms.Label LBL_DIRECCION;
        private System.Windows.Forms.Label LBL_NUMERO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Acpetar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}