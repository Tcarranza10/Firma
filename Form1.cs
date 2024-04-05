using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_chino
{
    public partial class Form1 : Form
    {
        private Bitmap imagen;
        public Form1()
        {
            InitializeComponent();

            imagen = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics objetoLoco = Graphics.FromImage(imagen))
                {
                    objetoLoco.FillEllipse(Brushes.Blue, e.X, e.Y, 5, 5);
                }

                pictureBox1.Image = imagen;
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Imagen Guardada con éxito");

            {
                imagen.Save("dibujo.png", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}
