using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void guardar()
        {
            cuadro_guardar = new SaveFileDialog();
            if (cuadro_guardar.ShowDialog() == DialogResult.OK) // ShowDialogo nos permite ver algo en el proyecto, otra ventana. Para saber a que le di click, por ejemplo, cuando le das cerrar a un programa y te pregunta si deseas guardar antes de salir.
            {
                if (cuadro_guardar.FileName != "") // File name compara el nombre que inserta el usuario 
                {
                    RTF_TEXTO.SaveFile(cuadro_guardar.FileName);
                    TXT_RUTA.Text = cuadro_guardar.FileName.ToString();
                }
            }
        }

        public void guardar2()
        {
            RTF_TEXTO.SaveFile(TXT_RUTA.Text);
        }

        public void abrir()
        {
            cuadro_abrir = new OpenFileDialog();
            if (cuadro_abrir.ShowDialog() == DialogResult.OK)
            {
                RTF_TEXTO.LoadFile(cuadro_abrir.FileName);
                TXT_RUTA.Text = cuadro_abrir.FileName.ToString();
            } 

        }

        public void salir()
        {
            DialogResult resultado = MessageBox.Show("¿DESEAS GUARDAR EL ARCHIVO", "ALERTA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                guardar();
                Environment.Exit(0);
            }
            else
            {
                if (resultado == DialogResult.No)
                {
                    Environment.Exit(0); 
                }
            }
        }

        public void nuevo()
        {  
                if (RTF_TEXTO.Text != " ")
                {
                    DialogResult resultado = MessageBox.Show("¿DESEAS GUARDAR EL ARCHIVO?", "ALERTA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        guardar();
                        RTF_TEXTO.Clear();
                    }
                    else
                    {
                        if (resultado == DialogResult.No)
                        {
                            RTF_TEXTO.Clear();
                        }
                    }
                }
                if (RTF_TEXTO.Text == "")
                {
                    RTF_TEXTO.Clear();
                }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar(); 
        }

        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            guardar2(); 
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            abrir(); 
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            guardar2(); 
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salir(); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            salir(); 
        }

        private void colorFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog Fondo = new ColorDialog();
            Fondo.ShowDialog();
            RTF_TEXTO.BackColor = Fondo.Color; 
        }

        private void tipoDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuadro_fuente = new FontDialog();
            cuadro_fuente.ShowDialog();
            RTF_TEXTO.Font = cuadro_fuente.Font; 
        }

        private void colorDeLaFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuadro_color = new ColorDialog();
            cuadro_color.ShowDialog();
            RTF_TEXTO.ForeColor = cuadro_color.Color; 
        }

        private void tipoDeFuenteTextoSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuadro_fuente = new FontDialog();
            cuadro_fuente.ShowDialog();
            RTF_TEXTO.SelectionFont = cuadro_fuente.Font;
        }

        private void colorDeFuenteTextoSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuadro_color = new ColorDialog();
            cuadro_color.ShowDialog();
            RTF_TEXTO.SelectionColor = cuadro_color.Color;
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nuevo();

        }

        private void cuadro_imprimir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(RTF_TEXTO.Text, cuadro_fuente.Font, new SolidBrush(cuadro_color.Color), 50, 100);
            e.Graphics.DrawString("Elaborado en NOTEMG" + DateTime.Now.ToString(), new Font("Arial", 10), Brushes.Blue, 0, 800); // Para mostrar un fondo, como una marca de agua. 
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            cuadro_vista.Document = cuadro_imprimir;
            cuadro_seleccion.ShowDialog(); 
            cuadro_vista.ShowDialog(); // Se da una vista previa de lo que se va a imprimir
        }

        private void cortarToolStripButton_Click(object sender, EventArgs e)
        {
            RTF_TEXTO.Cut();
        }

        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {
            RTF_TEXTO.Copy(); 
        }

        private void pegarToolStripButton_Click(object sender, EventArgs e)
        {
            RTF_TEXTO.Paste(); 
        }

        private void ayudaToolStripButton_Click(object sender, EventArgs e)
        {
            Form2 mostrar = new Form2();
            mostrar.Show();
        }


        
    } 
}  //OpenFile, SaveFile, ColorDialog
//Limpiar pantalla: rtf.exto,Clear();
